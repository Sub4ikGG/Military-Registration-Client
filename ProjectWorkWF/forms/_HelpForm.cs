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
    public partial class _HelpForm : Form
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

        public _HelpForm()
        {
            InitializeComponent();
        }

        private void visible_changed(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button.Width, button.Height, 5, 5));
        }

        private void question_click(object sender, EventArgs e)
        {
            var button = (Button) sender;
            switch(button.Text)
            {
                case "Как подать заявление на постановку на учет?":
                    ShowInfo(button.Text, "Заполните паспорт в личном кабинете и перейдите в раздел Заявления");
                    break;

                case "Где подтвердить свой паспорт?":
                    ShowInfo(button.Text, "В разделе личный кабинет");
                    break;

                case "Как поменять пользователя?":
                    ShowInfo(button.Text, "Нажмите на кнопку Сменить пользователя слева в меню");
                    break;

                case "Что такое траектории?":
                    ShowInfo(button.Text, "Некий план действий, который вы должны пройти, после отправки заявления");
                    break;

                case "Сколько в среднем проверяют данные?":
                    ShowInfo(button.Text, "Сейчас данные автоматически проверяет система в течение минуты");
                    break;

                case "Как поменять свой пароль?":
                    ShowInfo(button.Text, "Пока нет возможности поменять пароль, в скором времени это будет добавлено");
                    break;

                case "Сотрудникам военкомата":
                    ShowInfo(button.Text, "Обратитесь к комиссару, для получения данных для входа в систему");
                    break;
            }
        }

        private void ShowInfo(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
