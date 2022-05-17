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

using Newtonsoft.Json;

namespace ProjectWorkWF
{
    public partial class Main_Form : Form
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

        private Form loginForm;

        private TcpClient client;
        private NetworkStream stream;

        private User user;
        private Form currentForm;

        private Applications applications;
        private Notifications notifications; private int notification_count = 0;

        private Color selected = Color.White;
        private Color unSelected = Color.FromArgb(240, 240, 240);

        public bool canOpenChildForm = true;

        private enum Forms
        {
            profile,
            notifications,
            applications,
            plans,
            help
        }

        public Main_Form(TcpClient c, User u)
        {
            InitializeComponent();

            client = c;
            stream = client.GetStream();
            user = u;

            SendRequest($"/getpassport- {user.email}");
            string result = WaitingResult(); if (result != "301") user.passport = JsonConvert.DeserializeObject<Passport>(result);

            SendRequest($"/getuseraddress- {user.email}");
            result = WaitingResult(); user.address = JsonConvert.DeserializeObject<Address>(result);

            SendRequest($"/getuserapps- {user.email}");
            result = WaitingResult(); if(result != "501") applications = JsonConvert.DeserializeObject<Applications>(result);

            SendRequest($"/getusernot- {user.email}");
            result = WaitingResult(); if (result != "601")
            {
                notifications = JsonConvert.DeserializeObject<Notifications>(result); notification_count = notifications.notifications.Length;
                notifications_button.Text = $"Уведомления ({notification_count})";
            }

            profile_button_Click(profile_button, null);
            panel1.BackColor = Color.FromArgb(208, 205, 181);

            Thread notify_thread = new Thread(CheckNotifications);
            notify_thread.Start();
        }

        private void CheckNotifications()
        {
            try
            {
                while (this != null)
                {
                    Thread.Sleep(1000);
                    SendRequest($"/getusernot- {user.email}");

                    var result = WaitingResult(); if (result != "601")
                    {
                        notifications = JsonConvert.DeserializeObject<Notifications>(result);

                        Action action = () => notifications_button.Text = $"Уведомления ({notifications.notifications.Length})";
                        Invoke(action);

                        if (currentForm.Text == "Уведомления" && notifications.notifications.Length != notification_count)
                        {
                            action = () => OpenChildForm(new _NotificationsForm(client, user, notifications));
                            Invoke(action);
                        }

                        notification_count = notifications.notifications.Length;
                    }
                }
            }
            catch { }
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
                byte[] bufferResult = new byte[2048];
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            profile_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            notifications_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            applications_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            plans_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            help_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            change_user_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
            exit_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, profile_button.Width, profile_button.Height, 10, 10));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profile_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void profile_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _ProfileForm(client, user));
            MarkButton(Forms.profile);
        }

        private void notifications_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _NotificationsForm(client, user, notifications));
            MarkButton(Forms.notifications);
        }

        private void applications_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _ApplicationsForm(client, user, applications));
            MarkButton(Forms.applications);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _HelpForm());
            MarkButton(Forms.help);
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(Form form)
        {
            if(currentForm != null) currentForm.Close();

            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            profile_panel.Controls.Add(form);
            profile_panel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void MarkButton(Forms form)
        {
            switch(form)
            {
                case Forms.profile:
                    profile_button.BackColor = selected;
                    notifications_button.BackColor = unSelected;
                    plans_button.BackColor = unSelected;
                    applications_button.BackColor = unSelected;
                    help_button.BackColor = unSelected;
                    break;

                case Forms.notifications:
                    profile_button.BackColor = unSelected;
                    notifications_button.BackColor = selected;
                    plans_button.BackColor = unSelected;
                    applications_button.BackColor = unSelected;
                    help_button.BackColor = unSelected;
                    break;

                case Forms.plans:
                    profile_button.BackColor = unSelected;
                    notifications_button.BackColor = unSelected;
                    plans_button.BackColor = selected;
                    applications_button.BackColor = unSelected;
                    help_button.BackColor = unSelected;
                    break;

                case Forms.applications:
                    profile_button.BackColor = unSelected;
                    notifications_button.BackColor = unSelected;
                    plans_button.BackColor = unSelected;
                    applications_button.BackColor = selected;
                    help_button.BackColor = unSelected;
                    break;

                case Forms.help:
                    profile_button.BackColor = unSelected;
                    notifications_button.BackColor = unSelected;
                    plans_button.BackColor = unSelected;
                    applications_button.BackColor = unSelected;
                    help_button.BackColor = selected;
                    break;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void plans_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _PlansForm());
            MarkButton(Forms.plans);
        }

        private void change_user_button_Click(object sender, EventArgs e)
        {
            Settings.Default["Email"] = "";
            Settings.Default["Password"] = "";
            Settings.Default.Save();

            this.Close();
            Login_Form lf = new Login_Form();
            lf.Show();
        }
    }
}