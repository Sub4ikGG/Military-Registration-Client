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
    public partial class _NotificationsForm : Form
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
        private Notifications notifications;

        public _NotificationsForm(TcpClient c, User u, Notifications n)
        {
            InitializeComponent();

            client = c;
            user = u;
            notifications = n;
            stream = client.GetStream();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            /*SendRequest($"/getnotifications- {user.email}");
            var notifications = WaitingResult();*/

            if (notifications.notifications != null)
            {
                notifications_label.Text = $"Уведомления ({notifications.notifications.Length})";
                foreach (var notify in notifications.notifications.Reverse())
                {
                    ListViewItem item = new ListViewItem(notify.sender);
                    item.SubItems.Add(notify.message);

                    notifications_listView.Items.Add(item);
                }
            }
        }

        private void only_first_class_checkBox_CheckedChanged(object sender, EventArgs e)
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
    }
}