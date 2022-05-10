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

        private TcpClient client;
        private NetworkStream stream;

        private User user;
        private Form currentForm;

        private Color selected = Color.FromArgb(255, 255, 192);
        private Color unSelected = Color.White;

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
            user = u;

            profile_button_Click(profile_button, null);
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
            OpenChildForm(new _NotificationsForm(client, user));
            MarkButton(Forms.notifications);
        }

        private void applications_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _ApplicationsForm());
            MarkButton(Forms.applications);
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            OpenChildForm(new _PlansForm());
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
    }
}