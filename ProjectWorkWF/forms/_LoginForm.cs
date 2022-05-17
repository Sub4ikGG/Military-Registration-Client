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
using ProjectWorkWF.Properties;
using ProjectWorkWF.mods;

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class Login_Form : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Register_Form register_Form;

        private ServerHandler server_Handler;
        private FormsHandler forms_Handler = new FormsHandler();

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

                server_Handler = new ServerHandler(stream);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("Ошибка соединения с сервером.\nНекоторые функции требуют соединения с интернетом.\nПроверьте соединение с интернетом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InitializeComponent();

            login_label.Visible = false;
            login_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, login_button.Width, login_button.Height, 10, 10));
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
            if (true || email_TextBox.Text.Length != 0 && password_TextBox.Text.Length != 0 && !email_TextBox.Text.Equals("someone@example.com") && !password_TextBox.Text.Equals("qwertyuiopasdfghjkl"))
            {
                Login();
            }
            else forms_Handler.ShowError("Пустые поля логина и пароля");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread waiting = new Thread(CheckingFormLoad);
            waiting.Start();
        }

        private void CheckingFormLoad()
        {
            if (server_Handler == null) Thread.Sleep(2000);
            if (server_Handler == null) return;
            if (Settings.Default["Email"].ToString() != "" && Settings.Default["Password"].ToString() != "")
            {
                Action action = () => Login(true);
                Invoke(action);
            }
        }

        private void Login(bool auto = false)
        {
            try
            {
                if (auto) server_Handler.SendRequest($"/auth- {Settings.Default["Email"]} {Settings.Default["Password"]}");
                else server_Handler.SendRequest($"/auth- {email_TextBox.Text} {password_TextBox.Text}");
                string answer = server_Handler.WaitingResult();

                if (answer != "101")
                {
                    var user = JsonConvert.DeserializeObject<User>(answer);

                    server_Handler.SendRequest($"/getarmyticket- {email_TextBox.Text}");
                    var ans = server_Handler.WaitingResult();
                    if (ans != "701") user.ticket = JsonConvert.DeserializeObject<ArmyTicket>(ans);

                    forms_Handler.ShowSuccessful($"Пользователь авторизован.\n\nДобро пожаловать, {user.last_name} {user.first_name}!");

                    Main_Form main_form = new Main_Form(client, user);
                    main_form.Show();
                    this.Hide();

                    if (remember_checkBox.Checked)
                    {
                        Settings.Default["Email"] = user.email;
                        Settings.Default["Password"] = user.password;
                        Settings.Default.Save();
                    }
                }
                else forms_Handler.ShowError("Ошибка авторизации.");
            }
            catch (Exception ex)
            {
                forms_Handler.ShowError($"Непредвиденная ошибка.\n{ex.Message}");
            }
        }

        private void remember_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (remember_checkBox.Checked)
                forms_Handler.ShowSuccessful("При следующем входе не потребуется вводить логин и пароль");
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
