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
    public partial class _PlansForm : Form
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

        public _PlansForm()
        {
            InitializeComponent();
        }

        private void _PlansForm_Load(object sender, EventArgs e)
        {
            button_plan_1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button_plan_1.Width, button_plan_1.Height, 10, 10));
            button_plan_2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button_plan_2.Width, button_plan_2.Height, 10, 10));
            button_plan_3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button_plan_3.Width, button_plan_3.Height, 10, 10));
            button_plan_4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button_plan_4.Width, button_plan_4.Height, 10, 10));
        }

        private void button_plan_1_Click(object sender, EventArgs e)
        {
            Color color = button_plan_1.BackColor == Color.Wheat ? Color.DarkSeaGreen : Color.Wheat;
            button_plan_1.BackColor = color;

            if(color == Color.Wheat)
            {
                button_plan_2.BackColor = color;
                button_plan_3.BackColor = color;
                button_plan_4.BackColor = color;
            }
        }

        private void button_plan_2_Click(object sender, EventArgs e)
        {
            Color color = button_plan_2.BackColor == Color.Wheat ? Color.DarkSeaGreen : Color.Wheat;
            button_plan_2.BackColor = color;

            if (color == Color.Wheat)
            {
                button_plan_3.BackColor = color;
                button_plan_4.BackColor = color;
            }
            else
            {
                button_plan_1.BackColor = color;
            }
        }

        private void button_plan_3_Click(object sender, EventArgs e)
        {
            Color color = button_plan_3.BackColor == Color.Wheat ? Color.DarkSeaGreen : Color.Wheat;
            button_plan_3.BackColor = color;

            if (color == Color.Wheat)
            {
                button_plan_4.BackColor = color;
            }
            else
            {
                button_plan_1.BackColor = color;
                button_plan_2.BackColor = color;
            }
        }

        private void button_plan_4_Click(object sender, EventArgs e)
        {
            Color color = button_plan_4.BackColor == Color.Wheat ? Color.DarkSeaGreen : Color.Wheat;
            button_plan_1.BackColor = color;
            button_plan_2.BackColor = color;
            button_plan_3.BackColor = color;
            button_plan_4.BackColor = color;

            if(color == Color.DarkSeaGreen)
            {
                plan_label.Text = "Траектория: постановка на воинский учет выполнена!";
            }
        }
    }
}
