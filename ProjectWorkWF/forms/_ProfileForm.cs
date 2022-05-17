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

        public _ProfileForm(TcpClient c, User u)
        {
            InitializeComponent();

            client = c;
            user = u;

            stream = client.GetStream();

            fio_label.Text = $"ФИО: {user.last_name} {user.first_name} {user.last_last_name}";
            birth_label.Text = $"Дата рождения: {user.birth_date}";
            email_label.Text = $"Почта: {user.email}";

            if (user.sex == "мужской") woman_picture.Visible = false;
            else man_picture.Visible = false;

            if (user.passport != null)
            {
                series_and_number_label.Text = $"Серия и номер: {user.passport.series} {user.passport.number}";
                passport_date_label.Text = $"Дата выдачи: {user.passport.date}";
                division_code_label.Text = $"Код подразделения: {user.passport.division_code}";

                if(user.passport.series == -1)
                {
                    series_and_number_label.Text = $"Серия и номер: отсутствуют";
                    passport_date_label.Text = $"Дата выдачи: отсутствует";
                    division_code_label.Text = $"Код подразделения: отсутствует";
                }
            }
            else
            {
                series_and_number_label.Text = $"Серия и номер: отсутствуют";
                passport_date_label.Text = $"Дата выдачи: отсутствует";
                division_code_label.Text = $"Код подразделения: отсутствует";

                user.passport = new Passport(user.email, -1, -1, "-1", -1);
                ShowError("У вас отсутствуют введенные паспортные данные\nНажмите 'Внести правки', чтобы продолжить");
            }

            if(user.ticket.ticket_id != "-1")
            {
                army_passport_id_label.Text = $"ID-карта: {user.ticket.ticket_id}";
            }

            this.BackColor = Color.FromArgb(250, 252, 255);

            edit_info_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, edit_info_button.Width, edit_info_button.Height, 10, 10));
            email_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, email_panel.Width, email_panel.Height, 10, 10));
            series_and_number_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, series_and_number_panel.Width, series_and_number_panel.Height, 10, 10));
            date_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, date_panel.Width, date_panel.Height, 10, 10));
            division_code_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, division_code_panel.Width, division_code_panel.Height, 10, 10));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void edit_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_info_button.Text == "Внести правки")
                {
                    series_and_number_label.Text = "Серия и номер:";
                    passport_date_label.Text = "Дата выдачи:";
                    division_code_label.Text = "Код подразделения:";
                    edit_info_button.BackColor = Color.DarkSeaGreen;

                    email_textBox.Text = user.email;
                    series_and_number_textBox.Text = user.passport.series != -1 ? $"{user.passport.series} {user.passport.number}" : "";
                    passport_date_textBox.Text = user.passport.date != "-1" ? user.passport.date : "";
                    division_code_textBox.Text = user.passport.division_code != -1 ? $"{user.passport.division_code}" : "";

                    email_panel.Visible = true;
                    series_and_number_panel.Visible = true;
                    date_panel.Visible = true;
                    division_code_panel.Visible = true;

                    edit_info_button.Text = "Отмена";
                }
                else
                {
                    if (series_and_number_textBox.Text.Length * passport_date_textBox.Text.Length * division_code_textBox.Text.Length != 0 && ($"{user.passport.series} {user.passport.number}" != series_and_number_textBox.Text || user.passport.date != passport_date_textBox.Text || user.passport.division_code.ToString() != division_code_textBox.Text))
                    {
                        if (MessageBox.Show($"Паспорт:\nСерия и номер: {series_and_number_textBox.Text}\nДата выдачи: {passport_date_textBox.Text}\nКод подразделения: {division_code_textBox.Text}\n\nСогласны?", "Внесение правок", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            edit_info_button.Text = "Внести правки";

                            user.passport.series = Int32.Parse(series_and_number_textBox.Text.Split()[0]);
                            user.passport.number = Int32.Parse(series_and_number_textBox.Text.Split()[1]);
                            user.passport.date = passport_date_textBox.Text;
                            user.passport.division_code = Int32.Parse(division_code_textBox.Text);
                            SendRequest($"/setpassport- {JsonConvert.SerializeObject(user.passport)}");
                            var result = WaitingResult();

                            if (result == "OK") ShowSuccessful("Данные отправлены на проверку!");
                            else ShowError("Непредвиденная ошибка, попробуйте попозже!");
                        }
                    }

                    edit_info_button.Text = "Внести правки";
                    email_panel.Visible = false;
                    series_and_number_panel.Visible = false;
                    date_panel.Visible = false;
                    division_code_panel.Visible = false;
                    edit_info_button.BackColor = Color.PeachPuff;

                    var snn = user.passport.series != -1 ? $"{user.passport.series} {user.passport.number}" : "отсутствуют";
                    var pd = user.passport.date != "-1" ? user.passport.date : "отсутствует";
                    var dc = user.passport.division_code != -1 ? $"{user.passport.division_code}" : "отсутствует";
                    series_and_number_label.Text = $"Серия и номер: {snn}";
                    passport_date_label.Text = $"Дата выдачи: {pd}";
                    division_code_label.Text = $"Код подразделения: {dc}";
                }
            }
            catch
            {
                ShowError("Возникла ошибка при вводе данных.\n\nФормат серии и номера: 01234-5678\nФормат кода подразделения: ABCD (проверьте вводимые данные)");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void email_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void series_and_number_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void date_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void division_code_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void to_passport_button_Click(object sender, EventArgs e)
        {
            to_address_button.Visible = true;
            to_passport_button.Visible = false;
            edit_info_button.Enabled = true;

            groupBox2.Text = "Паспортные данные и военный билет";
            if (user.passport.series != -1)
            {
                email_label.Text = $"Почта: {user.email}";
                series_and_number_label.Text = $"Серия и номер: {user.passport.series} {user.passport.number}";
                passport_date_label.Text = $"Дата выдачи: {user.passport.date}";
                division_code_label.Text = $"Код подразделения: {user.passport.division_code}";
            }
            else
            {
                series_and_number_label.Text = $"Серия и номер: отсутствуют";
                passport_date_label.Text = $"Дата выдачи: отсутствует";
                division_code_label.Text = $"Код подразделения: отсутствует";
            }
        }

        private void to_address_button_Click(object sender, EventArgs e)
        {
            to_address_button.Visible = false;
            to_passport_button.Visible = true;
            edit_info_button.Enabled = false;

            email_panel.Visible = false;
            email_textBox.Visible = false;

            series_and_number_panel.Visible = false;
            series_and_number_textBox.Visible = false;

            date_panel.Visible = false;
            passport_date_textBox.Visible = false;

            division_code_panel.Visible = false;
            division_code_textBox.Visible = false;

            series_and_number_label.Text = "Страна: Россия";
            passport_date_label.Text = $"Город: {user.address.city}";
            division_code_label.Text = $"Улица, дом, кв: {user.address.street} {user.address.house_number}, {user.address.flat_number}";
        }
    }
}