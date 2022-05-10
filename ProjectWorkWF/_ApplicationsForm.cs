using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public _ApplicationsForm()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            find_button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, find_button.Width, find_button.Height, 5, 5));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void find_enter(object sender, EventArgs e)
        {
            if(find_textBox.Text == " Поиск заявлений")
            {
                find_textBox.Text = "";
                find_textBox.ForeColor = Color.Black;
            }
        }

        private void find_leave(object sender, EventArgs e)
        {
            if(find_textBox.Text == "")
            {
                find_textBox.Text = " Поиск заявлений";
                find_textBox.ForeColor = Color.Gray;
            }
        }
    }
}
