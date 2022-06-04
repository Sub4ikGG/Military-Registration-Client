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
    public partial class _ApplicationsForm : Form
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
        private Applications applications;

        public _ApplicationsForm(TcpClient c, User u, Applications a)
        {
            InitializeComponent();

            client = c; stream = client.GetStream();
            user = u;
            applications = a;

            if(applications != null) SetupApplications(applications.applications);
        }

        private void SetupApplications(App[] apps)
        {
            if (apps.Length == 0) return;

            foreach(var app in apps)
            {
                switch(app.title)
                {
                    case "Заявление: постановка на воинский учет":
                        button1.Text = "Подано";
                        button1.Enabled = false;
                        break;

                    case "Заявление: снятие с воинского учета":
                        button2.Text = "Подано";
                        button2.Enabled = false;
                        break;

                    case "Заявление: контрактная служба":
                        button3.Text = "Подано";
                        button3.Enabled = false;
                        break;

                    case "Заявление: отсрочка от службы":
                        button4.Text = "Подано";
                        button4.Enabled = false;
                        break;
                }
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 5, 5));
            find_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, find_button.Width, find_button.Height, 5, 5));

            apps_panel.BackColor = Color.FromArgb(252, 250, 250);
            apps_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, apps_panel.Width, apps_panel.Height, 5, 5));
            app1_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            app2_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            app3_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            app4_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            app5_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            app6_panel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, app1_panel.Width, app1_panel.Height, 10, 10));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
            button6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 10, 10));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void find_enter(object sender, EventArgs e)
        {
            if(find_textBox.Text == "Восстановление в должности")
            {
                find_textBox.Text = "";
                find_textBox.ForeColor = Color.Black;
            }
        }

        private void find_leave(object sender, EventArgs e)
        {
            if(find_textBox.Text == "")
            {
                find_textBox.Text = "Восстановление в должности";
                find_textBox.ForeColor = Color.Gray;
            }
        }

        private void find_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ShowError("Заявление не найдено.");
        }

        private void app1_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void apps_panel_Paint(object sender, PaintEventArgs e)
        {

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

        private void SendApplication(string title, Button btn)
        {
            App app = new App(user.email, "voenkomat@mil.ru", 0, title, $"{title} {user.last_name} {user.first_name}");

            SendRequest($"/sendapp- {JsonConvert.SerializeObject(app)}");
            if (WaitingResult() != "401") ShowSuccessful("Заявление отправлено.");
            else ShowError("Заявление уже существует в базе.");

            btn.Text = "Подано";
            btn.Enabled = false;
        }

        private void app_button_click1(object sender, EventArgs e)
        {
            if (user.passport != null)
            {
                if(user.passport.series != -1)
                    SendApplication("Заявление: постановка на воинский учет", button1);
                else
                    ShowError("Перейдите в раздел личный кабинет и заполните паспортные данные!");
            }
            else
                ShowError("Перейдите в раздел личный кабинет и заполните паспортные данные!");
        }

        private void app_button_click2(object sender, EventArgs e)
        {
            if (user.passport != null && user.ticket != null)
            {
                if (user.passport.series != -1 && user.ticket.ticket_id != "-1")
                    SendApplication("Заявление: снятие с воинского учета", button2);
                else
                    ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
            }
            else
                ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
        }

        private void app_button_click3(object sender, EventArgs e)
        {
            if (user.passport != null && user.ticket != null)
            {
                if (user.passport.series != -1 && user.ticket.ticket_id != "-1")
                    SendApplication("Заявление: контрактная служба", button3);
                else
                    ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
            }
            else
                ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
        }

        private void app_button_click4(object sender, EventArgs e)
        {
            if (user.passport != null && user.ticket != null)
            {
                if (user.passport.series != -1 && user.ticket.ticket_id != "-1")
                    SendApplication("Заявление: отсрочка от службы", button4);
                else
                    ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
            }
            else
                ShowError("Ошибка отправления!\nСкорее всего у вас отсутсвуют паспортные данные или ID-карта.");
        }
    }
}
