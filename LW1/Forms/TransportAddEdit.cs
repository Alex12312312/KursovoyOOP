using LW1.Models.Service;
using LW1.Services.Interfaces;
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
    /// Форма для взаимодействия с выбранным автобусом
    /// </summary>
    public partial class TransportAddEdit : Form
    {
        /// <summary>
        /// Объект класса Транспорт с которым работает форма
        /// </summary>
        private Transport transport;
        private ITransportService transportService;
        private int status;

        /// <summary>
        /// Конструктор при добавлении нового автобуса
        /// </summary>
        /// <param name="transportService">Сервис для работы с базой данных</param>
        public TransportAddEdit(ITransportService transportService)
        {
            transport = new Transport();
            status = 0;
            this.transportService = transportService;
            InitializeComponent();
            DelBtn.Enabled = false;
            DelBtn.Visible = false;
        }

        /// <summary>
        /// Констуктор при работе с 
        /// </summary>
        /// <param name="transportService"></param>
        /// <param name="transport"></param>
        public TransportAddEdit(ITransportService transportService, Transport transport)
        {
            this.transport = transport;
            status = 1;
            this.transportService = transportService;
            InitializeComponent();
            AddEditBtn.Text = "Редактировать";
            ModelField.Text = transport.Model;
            NameField.Text = transport.Name;
            SurnameField.Text = transport.Surname;
            PatronymicField.Text = transport.Patronymic;
            MileageField.Text = transport.Mileage.ToString();
            RouteField.Text = transport.Route;

        }

        /// <summary>
        /// Обработка нажатия на кнопку "Назад"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Добавить"/"Редактировать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEditBtn_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (NameField.Text != "")
            {
                if (SurnameField.Text == "")
                {
                    flag = true;
                    SurnameField.BackColor = Color.Coral;
                }
                if (RouteField.Text == "")
                {
                    flag = true;
                    RouteField.BackColor = Color.Coral;
                }
            }
            if (SurnameField.Text != "")
            {
                if (NameField.Text == "")
                {
                    flag = true;
                    NameField.BackColor = Color.Coral;
                }
                if (RouteField.Text == "")
                {
                    RouteField.BackColor = Color.Coral;
                    flag = true;
                }
            }
            if (PatronymicField.Text != "")
            {
                if (NameField.Text == "")
                {
                    flag = true;
                    NameField.BackColor = Color.Coral;
                }
                if (SurnameField.Text == "")
                {
                    flag = true;
                    SurnameField.BackColor = Color.Coral;
                }
                if (RouteField.Text == "")
                {
                    RouteField.BackColor = Color.Coral;
                    flag = true;
                }
            }
            if (flag) return;
            if (status == 0) AddTransport();
            else EditTransport();
        }

        /// <summary>
        /// Добавление нового автобуса в базу данных
        /// </summary>
        private void AddTransport()
        {
            ModelField.BackColor = SystemColors.Control;
            if (ModelField.Text == "")
            {
                if (ModelField.Text == "") ModelField.BackColor = Color.Coral;
                return;
            }
            transport.Model = ModelField.Text;
            transport.Mileage = Int32.Parse(MileageField.Text);
            transport.Name = NameField.Text;
            transport.Surname = SurnameField.Text;
            transport.Patronymic = PatronymicField.Text;
            transport.Route = RouteField.Text;
            transportService.Add(transport);
            Close();
        }

        /// <summary>
        /// Изменение данных об автобусе в базе данных
        /// </summary>
        private void EditTransport()
        {
            ModelField.BackColor = SystemColors.Control;
            if (ModelField.Text == "")
            {
                if (ModelField.Text == "") ModelField.BackColor = Color.Coral;
                return;
            }
            transport.Model = ModelField.Text;
            transport.Mileage = Int32.Parse(MileageField.Text);
            transport.Name = NameField.Text;
            transport.Surname = SurnameField.Text;
            transport.Patronymic = PatronymicField.Text;
            transport.Route = RouteField.Text;
            transportService.Update(transport);
            Close();
        }

        private void DriverData_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Обработка нажатия на кнопку "Удалить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DelBtn_Click(object sender, EventArgs e)
        {
            transportService.Delete(transport.Id);
            Close();
        }

        private void ModelField_Click(object sender, EventArgs e)
        {
            ModelField.BackColor = SystemColors.Control;
        }

        private void SurnameField_Click(object sender, EventArgs e)
        {
            SurnameField.BackColor = SystemColors.Control;
        }

        private void NameField_Click(object sender, EventArgs e)
        {
            NameField.BackColor = SystemColors.Control;
        }

        private void RouteField_Click(object sender, EventArgs e)
        {
            RouteField.BackColor = SystemColors.Control;
        }

        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Yellow;
            btn.ForeColor = Color.Black;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.Yellow;
        }

        private void TransportAddEdit_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(128, 0, 0, 0);
            DriverData.BackColor = Color.FromArgb(128, 0, 0, 0);
            TransportData.BackColor = Color.FromArgb(128, 0, 0, 0);
        }
    }
}
