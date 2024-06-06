using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LW1.Forms
{
    /// <summary>
    /// Приветственное окно
    /// </summary>
    public partial class GreetingsPage : Form
    {
        /// <summary>
        /// Таймер при закрытии формы
        /// </summary>
        System.Windows.Forms.Timer timer;

        /// <summary>
        /// Конструктор формы
        /// </summary>
        public GreetingsPage()
        {
            InitializeComponent();

        }


        private void GreetingsPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 0, 0, 0);
        }

        /// <summary>
        /// Запуск таймера после отображения окна на экране
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GreetingsPage_Shown(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 5000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        /// <summary>
        /// Закрытия окна по истечении времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Смена цвета при наведении на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Yellow;
            button1.ForeColor = Color.Black;
        }

        /// <summary>
        /// Смена цвета при выходе курсора за пределы кнопки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Transparent;
            button1.ForeColor = Color.Yellow;
        }

        /// <summary>
        /// Завершение таймера и закрытие формы при нажатии на кнопку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
        }
    }
}
