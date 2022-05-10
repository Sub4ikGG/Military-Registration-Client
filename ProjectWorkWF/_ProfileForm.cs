using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class _ProfileForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);

        private TcpClient client;
        private NetworkStream stream;

        private User user;
        private Passport passport;

        public _ProfileForm(TcpClient c, User u)
        {
            InitializeComponent();

            client = c;
            user = u;
            stream = client.GetStream();

            SendRequest($"/getpassport- {user.email}");
            string result = WaitingResult();

            fio_label.Text = $"ФИО: {user.last_name} {user.first_name} {user.last_last_name}";
            birth_label.Text = $"Дата рождения: {user.birth_date}";

            if(result != "301")
            {
                passport = JsonConvert.DeserializeObject<Passport>(result);

                series_and_number_label.Text = $"Серия и номер: {passport.series} {passport.number}";
                passport_date_label.Text = $"Дата выдачи: {passport.date}";
                division_code_label.Text = $"Код подразделения: {passport.division_code}";
            }
            else
            {
                passport = new Passport(user.email, -1, -1, "-1", -1);
                series_and_number_label.Text = $"Серия и номер: отсутствуют";
                passport_date_label.Text = $"Дата выдачи: отсутствует";
                division_code_label.Text = $"Код подразделения: отсутствует";

                ShowError("У вас отсутствуют введенные паспортные данные\nНажмите 'Внести правки', чтобы продолжить");
            }
            edit_info_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, edit_info_button.Width, edit_info_button.Height, 10, 10));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            if (edit_info_button.Text == "Внести правки")
            {
                edit_info_button.Text = "Отмена";
                series_and_number_label.Text = "Серия и номер:";
                passport_date_label.Text = "Дата выдачи:";
                division_code_label.Text = "Код подразделения:";
                edit_info_button.BackColor = Color.DarkSeaGreen;


                email_textBox.Text = user.email;
                series_and_number_textBox.Text = passport.series != -1 ? $"{passport.series} {passport.number}" : "";
                passport_date_textBox.Text = passport.date != "-1" ? passport.date : "";
                division_code_textBox.Text = passport.division_code != -1 ? $"{passport.division_code}" : "";

                series_and_number_textBox.Visible = true;
                passport_date_textBox.Visible = true;
                division_code_textBox.Visible = true;
                email_textBox.Visible = true;
            }
            else
            {
                if (series_and_number_textBox.Text.Length*passport_date_textBox.Text.Length*division_code_textBox.Text.Length != 0 && ($"{passport.series} {passport.number}" != series_and_number_textBox.Text || passport.date != passport_date_textBox.Text || passport.division_code.ToString() != division_code_textBox.Text))
                {
                    if (MessageBox.Show($"Паспорт:\nСерия и номер: {series_and_number_textBox.Text}\nДата выдачи: {passport_date_textBox.Text}\nКод подразделения: {division_code_textBox.Text}\n\nСогласны?", "Внесение правок", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        edit_info_button.Text = "Внести правки";

                        passport.series = Int32.Parse(series_and_number_textBox.Text.Split()[0]);
                        passport.number = Int32.Parse(series_and_number_textBox.Text.Split()[1]);
                        passport.date = passport_date_textBox.Text;
                        passport.division_code = Int32.Parse(division_code_textBox.Text);
                        SendRequest($"/setpassport- {JsonConvert.SerializeObject(passport)}");
                        var result = WaitingResult();

                        if (result == "OK") ShowSuccessful("Данные отправлены на проверку!");
                        else ShowError("Непредвиденная ошибка, попробуйте попозже!");
                    }
                }

                edit_info_button.Text = "Внести правки";
                series_and_number_textBox.Visible = false;
                passport_date_textBox.Visible = false;
                division_code_textBox.Visible = false;
                email_textBox.Visible = false;
                edit_info_button.BackColor = Color.DarkSalmon;

                var snn = passport.series != -1 ? $"{passport.series} {passport.number}" : "отсутствуют";
                var pd = passport.date != "-1" ? passport.date : "отсутствует";
                var dc = passport.division_code != -1 ? $"{passport.division_code}" : "отсутствует";
                series_and_number_label.Text = $"Серия и номер: {snn}";
                passport_date_label.Text = $"Дата выдачи: {pd}";
                division_code_label.Text = $"Код подразделения: {dc}";
            }
        }

        private void SendRequest(string request)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            catch (Exception e)
            {
                ShowError($"Непредвиденная ошибка.\n{e.Message}");
            }
        }

        private string WaitingResult()
        {
            try
            {
                byte[] bufferResult = new byte[256];
                int length = stream.Read(bufferResult, 0, bufferResult.Length);
                string answer = Encoding.UTF8.GetString(bufferResult, 0, length).Trim();

                return answer;
            }
            catch (Exception e)
            {
                ShowError($"Непредвиденная ошибка.\n{e.Message}");

                return "";
            }
        }

        private void ShowSuccessful(string message)
        {
            MessageBox.Show(message, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void avatar_picture_Click(object sender, EventArgs e)
        {

        }

        private void series_and_number_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_info_button.Text = series_and_number_textBox.TextLength*passport_date_textBox.TextLength*division_code_textBox.TextLength == 0 ? "Отмена" : "Подтвердить правки";
        }

        private void passport_date_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_info_button.Text = series_and_number_textBox.TextLength * passport_date_textBox.TextLength * division_code_textBox.TextLength == 0 ? "Отмена" : "Подтвердить правки";
        }

        private void division_code_textBox_TextChanged(object sender, EventArgs e)
        {
            edit_info_button.Text = series_and_number_textBox.TextLength * passport_date_textBox.TextLength * division_code_textBox.TextLength == 0 ? "Отмена" : "Подтвердить правки";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void account_id_label_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}