using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class Register_Form : Form
    {
        private TcpClient client;
        private NetworkStream stream;

        public Register_Form(TcpClient client)
        {
            this.client = client;
            this.stream = client.GetStream();

            InitializeComponent();
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

            var sex = man_checkBox.Checked ? "мужской" : "женский";

            if(fn.Length * ln.Length * lnn.Length * email.Length * password.Length != 0 && (man_checkBox.Checked || woman_checkBox.Checked))
            {
                if (MessageBox.Show($"ФИО: {ln} {fn} {lnn}\nПол: {sex}\nДата рождения: {date_TimePicker.Text}\n\nПочта: {email}\nПароль: {password}\n\nСогласны?", "Регистрация", MessageBoxButtons.YesNo, MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    var user = new User(ln, fn, lnn, sex, date_TimePicker.Text, email, password);
                    string json = JsonConvert.SerializeObject(user);

                    var user2 = JsonConvert.DeserializeObject<User>(json);

                    SendRequest($"/signup-{json}");
                    var result = WaitingResult();

                    if (result == "200")
                    {
                        Close();
                        ShowSuccessful($"Пользователь успешно зарегистрирован.\n\nПочта: {email}\nПароль: {password}\nПод этими данными необходимо войти в аккаунт.");
                    }
                    else
                        ShowError("Ошибка регистрации.\nПопробуйте ещё раз.");
                }
            }
            else
            {
                ShowError("Заполните все пустые поля и маркеры");
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessful(string message)
        {
            MessageBox.Show(message, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SendRequest(string request)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(request);
            stream.Write(buffer, 0, buffer.Length);
            stream.Flush();
        }

        private string WaitingResult()
        {
            byte[] bufferResult = new byte[256];
            int length = stream.Read(bufferResult, 0, bufferResult.Length);
            string answer = Encoding.UTF8.GetString(bufferResult, 0, length).Trim();

            return answer;
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
    }
}
