namespace LW1.Forms
{
    partial class TransportAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransportAddEdit));
            AddEditBtn = new Button();
            DelBtn = new Button();
            BackBtn = new Button();
            TransportData = new Panel();
            label8 = new Label();
            MileageField = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            ModelField = new TextBox();
            RouteField = new TextBox();
            label1 = new Label();
            DriverData = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            PatronymicField = new TextBox();
            NameField = new TextBox();
            SurnameField = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            TransportData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MileageField).BeginInit();
            DriverData.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddEditBtn
            // 
            AddEditBtn.BackColor = Color.Transparent;
            AddEditBtn.FlatStyle = FlatStyle.Popup;
            AddEditBtn.ForeColor = Color.Yellow;
            AddEditBtn.Location = new Point(10, 10);
            AddEditBtn.Name = "AddEditBtn";
            AddEditBtn.Size = new Size(112, 50);
            AddEditBtn.TabIndex = 0;
            AddEditBtn.Text = "Добавить";
            AddEditBtn.UseVisualStyleBackColor = false;
            AddEditBtn.Click += AddEditBtn_Click;
            AddEditBtn.MouseEnter += Btn_MouseEnter;
            AddEditBtn.MouseLeave += Btn_MouseLeave;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.Transparent;
            DelBtn.FlatStyle = FlatStyle.Popup;
            DelBtn.ForeColor = Color.Yellow;
            DelBtn.Location = new Point(142, 10);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(83, 50);
            DelBtn.TabIndex = 1;
            DelBtn.Text = "Удалить";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            DelBtn.MouseEnter += Btn_MouseEnter;
            DelBtn.MouseLeave += Btn_MouseLeave;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.FlatStyle = FlatStyle.Popup;
            BackBtn.ForeColor = Color.Yellow;
            BackBtn.Location = new Point(240, 10);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(71, 50);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "Назад";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            BackBtn.MouseEnter += Btn_MouseEnter;
            BackBtn.MouseLeave += Btn_MouseLeave;
            // 
            // TransportData
            // 
            TransportData.BackColor = Color.Black;
            TransportData.BorderStyle = BorderStyle.FixedSingle;
            TransportData.Controls.Add(label8);
            TransportData.Controls.Add(MileageField);
            TransportData.Controls.Add(label4);
            TransportData.Controls.Add(label3);
            TransportData.Controls.Add(ModelField);
            TransportData.Controls.Add(RouteField);
            TransportData.Controls.Add(label1);
            TransportData.Location = new Point(2, 4);
            TransportData.Name = "TransportData";
            TransportData.Size = new Size(322, 172);
            TransportData.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.FlatStyle = FlatStyle.Popup;
            label8.ForeColor = Color.Yellow;
            label8.Location = new Point(29, 138);
            label8.Name = "label8";
            label8.Size = new Size(60, 15);
            label8.TabIndex = 8;
            label8.Text = "Маршрут";
            // 
            // MileageField
            // 
            MileageField.Location = new Point(102, 97);
            MileageField.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            MileageField.Name = "MileageField";
            MileageField.Size = new Size(207, 23);
            MileageField.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Popup;
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(29, 99);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Пробег";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Popup;
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(30, 58);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 3;
            label3.Text = "Модель";
            // 
            // ModelField
            // 
            ModelField.Location = new Point(103, 55);
            ModelField.Name = "ModelField";
            ModelField.Size = new Size(207, 23);
            ModelField.TabIndex = 1;
            ModelField.Click += ModelField_Click;
            // 
            // RouteField
            // 
            RouteField.Location = new Point(101, 135);
            RouteField.Name = "RouteField";
            RouteField.Size = new Size(208, 23);
            RouteField.TabIndex = 4;
            RouteField.Click += RouteField_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Popup;
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Данные о ТС";
            // 
            // DriverData
            // 
            DriverData.BackColor = Color.Black;
            DriverData.BorderStyle = BorderStyle.FixedSingle;
            DriverData.Controls.Add(label7);
            DriverData.Controls.Add(label6);
            DriverData.Controls.Add(label5);
            DriverData.Controls.Add(PatronymicField);
            DriverData.Controls.Add(NameField);
            DriverData.Controls.Add(SurnameField);
            DriverData.Controls.Add(label2);
            DriverData.Location = new Point(2, 182);
            DriverData.Name = "DriverData";
            DriverData.Size = new Size(322, 185);
            DriverData.TabIndex = 4;
            DriverData.Paint += DriverData_Paint;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Popup;
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(30, 138);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 7;
            label7.Text = "Отчество";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.Yellow;
            label6.Location = new Point(30, 89);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 6;
            label6.Text = "Имя";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Popup;
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(30, 33);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 5;
            label5.Text = "Фамилия";
            // 
            // PatronymicField
            // 
            PatronymicField.Location = new Point(103, 138);
            PatronymicField.Name = "PatronymicField";
            PatronymicField.Size = new Size(207, 23);
            PatronymicField.TabIndex = 3;
            // 
            // NameField
            // 
            NameField.Location = new Point(103, 89);
            NameField.Name = "NameField";
            NameField.Size = new Size(207, 23);
            NameField.TabIndex = 2;
            NameField.Click += NameField_Click;
            // 
            // SurnameField
            // 
            SurnameField.Location = new Point(103, 33);
            SurnameField.Name = "SurnameField";
            SurnameField.Size = new Size(207, 23);
            SurnameField.TabIndex = 1;
            SurnameField.Click += SurnameField_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Popup;
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 0;
            label2.Text = "Данные о водителе";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(BackBtn);
            panel1.Controls.Add(DelBtn);
            panel1.Controls.Add(AddEditBtn);
            panel1.Location = new Point(-5, 391);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 75);
            panel1.TabIndex = 5;
            // 
            // TransportAddEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.busFront1;
            ClientSize = new Size(325, 463);
            Controls.Add(panel1);
            Controls.Add(DriverData);
            Controls.Add(TransportData);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(341, 502);
            MinimumSize = new Size(341, 502);
            Name = "TransportAddEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Карта ТС";
            Load += TransportAddEdit_Load;
            TransportData.ResumeLayout(false);
            TransportData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MileageField).EndInit();
            DriverData.ResumeLayout(false);
            DriverData.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddEditBtn;
        private Button DelBtn;
        private Button BackBtn;
        private Panel TransportData;
        private Panel DriverData;
        private Label label1;
        private Label label2;
        private TextBox ModelField;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox RouteField;
        private TextBox PatronymicField;
        private TextBox NameField;
        private TextBox SurnameField;
        private Label label8;
        private NumericUpDown MileageField;
        private Panel panel1;
    }
}