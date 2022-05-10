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

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class Login_Form : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Register_Form register_Form;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse);

        public Login_Form()
        {
            try
            {
                client = new TcpClient("127.0.0.1", 25565);
                stream = client.GetStream();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ошибка соединения с сервером.\nНекоторые функции требуют соединения с интернетом.\nПроверьте соединение с интернетом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitializeComponent();
            login_label.Visible = false;
        }

        private void login_textBox_Changed(object sender, EventArgs e)
        {
            
        }

        private void register_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            register_Form = new Register_Form(client);
            register_Form.Show();

            Thread thread = new Thread(RestoreMainForm);
            thread.Start();
        }

        private void RestoreMainForm()
        {
            while (register_Form.Visible)
            {
                Thread.Sleep(1);
            }
            Action action = () => this.Show();
            Invoke(action);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (email_TextBox.Text.Length != 0 && password_TextBox.Text.Length != 0 && !email_TextBox.Text.Equals("someone@example.com") && !password_TextBox.Text.Equals("qwertyuiopasdfghjkl"))
            {
                try
                {
                    SendRequest($"/auth- {email_TextBox.Text} {password_TextBox.Text}");
                    string answer = WaitingResult();

                    if (answer != "101")
                    {
                        var user = JsonConvert.DeserializeObject<User>(answer);
                        ShowSuccessful($"Пользователь авторизован.\n{user.first_name}");

                        Main_Form main_form = new Main_Form(client, user);
                        main_form.Show();
                        this.Hide();
                    }
                    else ShowError("Ошибка авторизации.");
                }
                catch(Exception ex)
                {
                    ShowError($"Непредвиденная ошибка.\n{ex.Message}");
                }
            }
            else ShowError("Пустые поля логина и пароля");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            SendRequest($"/auth- zerotanker33@gmail.com lovecarrots33");
            string answer = WaitingResult();

            if (answer != "101")
            {
                var user = JsonConvert.DeserializeObject<User>(answer);
                ShowSuccessful($"Добро пожаловать, {user.last_name} {user.first_name}!");

                Main_Form main_form = new Main_Form(client, user);
                main_form.Show();
                this.Hide();
            }
            else ShowError("Ошибка авторизации.");
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ShowSuccessful(string message)
        {
            MessageBox.Show(message, "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void remember_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (remember_checkBox.Checked)
                ShowSuccessful("При следующем входе не потребуется вводить логин и пароль");
        }

        private void SendRequest(string request)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(request);
                stream.Write(buffer, 0, buffer.Length);
                stream.Flush();
            }
            catch(Exception e)
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

        private void email_click_textBox(object sender, EventArgs e)
        {
            /*if (email_TextBox.Text == "Почта")
            {
                email_TextBox.ForeColor = Color.Black;
                email_TextBox.Text = "";
            }*/
        }

        private void email_leave_textBox(object sender, EventArgs e)
        {
            if (email_TextBox.Text.Trim() == "")
            {
                email_TextBox.ForeColor = Color.Gray;
                email_TextBox.Text = "someone@example.com";
            }
        }

        private void password_click_textBox(object sender, EventArgs e)
        {
            /*if (password_TextBox.Text == "123456789101112131415")
            {
                password_TextBox.ForeColor = Color.Black;
                password_TextBox.Text = "";
            }*/
        }

        private void password_leave_textBox(object sender, EventArgs e)
        {
            if (password_TextBox.Text.Trim() == "")
            {
                password_TextBox.ForeColor = Color.Gray;
                password_TextBox.Text = "qwertyuiopasdfghjkl";
            }
        }

        private void email_enter(object sender, EventArgs e)
        {
            if(email_TextBox.Text == "someone@example.com")
            {
                email_TextBox.Text = "";
                email_TextBox.ForeColor = Color.Black;
            }
        }

        private void password_enter(object sender, EventArgs e)
        {
            if (password_TextBox.Text == "qwertyuiopasdfghjkl")
            {
                password_TextBox.Text = "";
                password_TextBox.ForeColor = Color.Black;
            }
        }
    }
}
