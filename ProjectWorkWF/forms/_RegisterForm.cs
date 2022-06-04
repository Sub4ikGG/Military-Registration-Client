using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectWorkWF.mods;

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class Register_Form : Form
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

        private ServerHandler server_Handler;
        private FormsHandler forms_Handler = new FormsHandler();

        public Register_Form(TcpClient client)
        {
            this.client = client;
            this.stream = client.GetStream();
            server_Handler = new ServerHandler(stream);

            InitializeComponent();

            register_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, register_button.Width, register_button.Height, 10, 10));
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            var fn = last_name_textBox.Text.Trim();
            var ln = first_name_textBox.Text.Trim();
            var lnn = last_last_name_textBox.Text.Trim();
            var email = email_textBox.Text.Trim();
            var password = password_textBox.Text.Trim();

            var city = city_textBox.Text.Trim();
            var street = street_textBox.Text.Trim();
            var house_number = house_number_textBox.Text.Trim();
            var flat_number = flat_number_textBox.Text.Trim();

            var sex = man_checkBox.Checked ? "мужской" : "женский";
            try
            {
                if (fn.Length * ln.Length * lnn.Length * email.Length * password.Length * city.Length * street.Length * house_number.Length * flat_number.Length != 0 && (man_checkBox.Checked || woman_checkBox.Checked))
                {
                    if (!isEmail(email))
                    {
                        forms_Handler.ShowError("Ошибка регистрации.\nПочта не соответствует формату: 'email@mail.ru'");
                        return;
                    }
                    if(!isYoung(date_TimePicker.Value.Year))
                    {
                        forms_Handler.ShowError("Ошибка регистрации.\nРегистрация доступна только с 16 лет.");
                        return;
                    }
                    if (MessageBox.Show($"ФИО: {ln} {fn} {lnn}\nПол: {sex}\nДата рождения: {date_TimePicker.Text}\n\nГород: {city}\nУлица: {street}\nДом: {house_number}\nКвартира: {flat_number}\n\nПочта: {email}\nПароль: {password}\n\nСогласны?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        var address = new Address(email, city, street, house_number, Int32.Parse(flat_number));
                        var user = new User(ln, fn, lnn, sex, date_TimePicker.Text, email, password);
                        user.address = address;
                        string json = JsonConvert.SerializeObject(user);

                        server_Handler.SendRequest($"/signup-{json}");
                        var result = server_Handler.WaitingResult();

                        if (result == "200")
                        {
                            Close();
                            forms_Handler.ShowSuccessful($"Пользователь успешно зарегистрирован.\n\nПочта: {email}\nПароль: {password}\nПод этими данными необходимо войти в аккаунт.");
                        }
                        else
                            forms_Handler.ShowError("Ошибка регистрации.\nПопробуйте ещё раз.");
                    }
                }
                else
                {
                    forms_Handler.ShowError("Заполните все пустые поля и маркеры");
                }
            }
            catch(Exception ex)
            {
                forms_Handler.ShowError($"Ошибка регистрации.\nПопробуйте ещё раз.\n{ex.Message}");
            }
        }

        private Boolean isEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private Boolean isYoung(int year)
        {
            return 2022 - year >= 16;
        }

        private void Register_Form_Load(object sender, EventArgs e)
        {

        }

        private void man_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(man_checkBox.Checked) woman_checkBox.Checked = false;
        }

        private void woman_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if(woman_checkBox.Checked) man_checkBox.Checked = false;
        }

        private void enterance_data_label_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}