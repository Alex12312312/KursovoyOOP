namespace LW1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        TransportTable = new DataGridView();
        ModelColumn = new DataGridViewTextBoxColumn();
        NSPColumn = new DataGridViewTextBoxColumn();
        RouteColumn = new DataGridViewTextBoxColumn();
        MileageColumn = new DataGridViewTextBoxColumn();
        AddNewTransport = new Button();
        ExitButton = new Button();
        FindBtn = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        ModelSearchField = new TextBox();
        RouteSearchField = new TextBox();
        ExecuteSearch = new Button();
        ClearDB = new Button();
        panel1 = new Panel();
        FilterBtn = new Button();
        panel2 = new Panel();
        RouteBox = new CheckBox();
        AcceptFilters = new Button();
        MileageFilter = new NumericUpDown();
        MoreLessBox = new ComboBox();
        MileageBox = new CheckBox();
        DriverExistBox = new CheckBox();
        ElementsShown = new Label();
        label5 = new Label();
        CloseFilters = new Button();
        label4 = new Label();
        ((System.ComponentModel.ISupportInitialize)TransportTable).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)MileageFilter).BeginInit();
        SuspendLayout();
        // 
        // TransportTable
        // 
        TransportTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
        TransportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        TransportTable.Columns.AddRange(new DataGridViewColumn[] { ModelColumn, NSPColumn, RouteColumn, MileageColumn });
        TransportTable.Location = new Point(2, 2);
        TransportTable.MaximumSize = new Size(782, 358);
        TransportTable.Name = "TransportTable";
        TransportTable.RowTemplate.Height = 25;
        TransportTable.Size = new Size(775, 51);
        TransportTable.TabIndex = 0;
        TransportTable.CellDoubleClick += ItemEdit;
        // 
        // ModelColumn
        // 
        ModelColumn.HeaderText = "Модель";
        ModelColumn.Name = "ModelColumn";
        ModelColumn.ReadOnly = true;
        ModelColumn.Width = 190;
        // 
        // NSPColumn
        // 
        NSPColumn.HeaderText = "ФИО Водителя";
        NSPColumn.Name = "NSPColumn";
        NSPColumn.ReadOnly = true;
        NSPColumn.Width = 240;
        // 
        // RouteColumn
        // 
        RouteColumn.HeaderText = "Маршрут";
        RouteColumn.Name = "RouteColumn";
        RouteColumn.ReadOnly = true;
        RouteColumn.Width = 150;
        // 
        // MileageColumn
        // 
        MileageColumn.HeaderText = "Пробег";
        MileageColumn.Name = "MileageColumn";
        MileageColumn.ReadOnly = true;
        MileageColumn.Width = 150;
        // 
        // AddNewTransport
        // 
        AddNewTransport.BackColor = Color.Transparent;
        AddNewTransport.Cursor = Cursors.Hand;
        AddNewTransport.FlatStyle = FlatStyle.Popup;
        AddNewTransport.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        AddNewTransport.ForeColor = Color.Yellow;
        AddNewTransport.Location = new Point(0, 3);
        AddNewTransport.Name = "AddNewTransport";
        AddNewTransport.Size = new Size(247, 55);
        AddNewTransport.TabIndex = 1;
        AddNewTransport.Text = "Добавить ТС";
        AddNewTransport.UseVisualStyleBackColor = false;
        AddNewTransport.Click += AddNewTransport_Click;
        AddNewTransport.MouseEnter += button_MouseEnter;
        AddNewTransport.MouseLeave += button_MouseLeave;
        // 
        // ExitButton
        // 
        ExitButton.BackColor = Color.Transparent;
        ExitButton.Cursor = Cursors.Hand;
        ExitButton.FlatStyle = FlatStyle.Popup;
        ExitButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        ExitButton.ForeColor = Color.Yellow;
        ExitButton.Location = new Point(643, 3);
        ExitButton.Name = "ExitButton";
        ExitButton.Size = new Size(173, 55);
        ExitButton.TabIndex = 2;
        ExitButton.Text = "Выход";
        ExitButton.UseVisualStyleBackColor = false;
        ExitButton.Click += ExitButton_Click;
        ExitButton.MouseEnter += button_MouseEnter;
        ExitButton.MouseLeave += button_MouseLeave;
        // 
        // FindBtn
        // 
        FindBtn.BackColor = Color.Transparent;
        FindBtn.Cursor = Cursors.Hand;
        FindBtn.FlatStyle = FlatStyle.Popup;
        FindBtn.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        FindBtn.ForeColor = Color.Yellow;
        FindBtn.Location = new Point(256, 2);
        FindBtn.Name = "FindBtn";
        FindBtn.Size = new Size(186, 55);
        FindBtn.TabIndex = 3;
        FindBtn.Text = "Поиск";
        FindBtn.UseVisualStyleBackColor = false;
        FindBtn.Click += FindBtn_Click;
        FindBtn.MouseEnter += button_MouseEnter;
        FindBtn.MouseLeave += button_MouseLeave;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Transparent;
        label1.ForeColor = Color.Yellow;
        label1.Location = new Point(266, 83);
        label1.Name = "label1";
        label1.Size = new Size(50, 15);
        label1.TabIndex = 4;
        label1.Text = "Модель";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.BackColor = Color.Transparent;
        label2.ForeColor = Color.Yellow;
        label2.Location = new Point(20, 102);
        label2.Name = "label2";
        label2.Size = new Size(227, 15);
        label2.TabIndex = 5;
        label2.Text = "Укажите параметры искомого автобуса";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.BackColor = Color.Transparent;
        label3.ForeColor = Color.Yellow;
        label3.Location = new Point(256, 133);
        label3.Name = "label3";
        label3.Size = new Size(60, 15);
        label3.TabIndex = 6;
        label3.Text = "Маршрут";
        // 
        // ModelSearchField
        // 
        ModelSearchField.BorderStyle = BorderStyle.FixedSingle;
        ModelSearchField.Location = new Point(337, 80);
        ModelSearchField.Name = "ModelSearchField";
        ModelSearchField.Size = new Size(149, 23);
        ModelSearchField.TabIndex = 7;
        // 
        // RouteSearchField
        // 
        RouteSearchField.Location = new Point(337, 130);
        RouteSearchField.Name = "RouteSearchField";
        RouteSearchField.Size = new Size(149, 23);
        RouteSearchField.TabIndex = 8;
        // 
        // ExecuteSearch
        // 
        ExecuteSearch.BackColor = Color.Transparent;
        ExecuteSearch.Cursor = Cursors.Hand;
        ExecuteSearch.FlatStyle = FlatStyle.Popup;
        ExecuteSearch.ForeColor = Color.Yellow;
        ExecuteSearch.Location = new Point(551, 102);
        ExecuteSearch.Name = "ExecuteSearch";
        ExecuteSearch.Size = new Size(125, 35);
        ExecuteSearch.TabIndex = 9;
        ExecuteSearch.Text = "Выполнить поиск";
        ExecuteSearch.UseVisualStyleBackColor = false;
        ExecuteSearch.Click += ExecuteSearch_Click;
        ExecuteSearch.MouseEnter += button_MouseEnter;
        ExecuteSearch.MouseLeave += button_MouseLeave;
        // 
        // ClearDB
        // 
        ClearDB.BackColor = Color.Transparent;
        ClearDB.Cursor = Cursors.Hand;
        ClearDB.FlatStyle = FlatStyle.Popup;
        ClearDB.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        ClearDB.ForeColor = Color.Yellow;
        ClearDB.Location = new Point(448, 2);
        ClearDB.Name = "ClearDB";
        ClearDB.Size = new Size(189, 55);
        ClearDB.TabIndex = 10;
        ClearDB.Text = "Очистка БД";
        ClearDB.UseVisualStyleBackColor = false;
        ClearDB.Click += ClearDB_Click;
        ClearDB.MouseEnter += button_MouseEnter;
        ClearDB.MouseLeave += button_MouseLeave;
        // 
        // panel1
        // 
        panel1.BackColor = Color.Black;
        panel1.Controls.Add(ClearDB);
        panel1.Controls.Add(ExecuteSearch);
        panel1.Controls.Add(AddNewTransport);
        panel1.Controls.Add(RouteSearchField);
        panel1.Controls.Add(ModelSearchField);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(label2);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(FindBtn);
        panel1.Controls.Add(ExitButton);
        panel1.Location = new Point(2, 371);
        panel1.Name = "panel1";
        panel1.Size = new Size(819, 172);
        panel1.TabIndex = 12;
        // 
        // FilterBtn
        // 
        FilterBtn.BackgroundImage = (Image)resources.GetObject("FilterBtn.BackgroundImage");
        FilterBtn.BackgroundImageLayout = ImageLayout.Center;
        FilterBtn.Cursor = Cursors.Hand;
        FilterBtn.Location = new Point(777, 2);
        FilterBtn.Name = "FilterBtn";
        FilterBtn.Size = new Size(44, 51);
        FilterBtn.TabIndex = 13;
        FilterBtn.UseVisualStyleBackColor = true;
        FilterBtn.Click += FilterBtn_Click;
        // 
        // panel2
        // 
        panel2.BackColor = Color.Black;
        panel2.Controls.Add(RouteBox);
        panel2.Controls.Add(AcceptFilters);
        panel2.Controls.Add(MileageFilter);
        panel2.Controls.Add(MoreLessBox);
        panel2.Controls.Add(MileageBox);
        panel2.Controls.Add(DriverExistBox);
        panel2.Controls.Add(ElementsShown);
        panel2.Controls.Add(label5);
        panel2.Controls.Add(CloseFilters);
        panel2.Controls.Add(label4);
        panel2.Location = new Point(833, 4);
        panel2.Name = "panel2";
        panel2.Size = new Size(353, 540);
        panel2.TabIndex = 14;
        // 
        // RouteBox
        // 
        RouteBox.AutoSize = true;
        RouteBox.BackColor = Color.Transparent;
        RouteBox.ForeColor = Color.Yellow;
        RouteBox.Location = new Point(13, 153);
        RouteBox.Name = "RouteBox";
        RouteBox.Size = new Size(335, 19);
        RouteBox.TabIndex = 9;
        RouteBox.Text = "Показывать транспорт только с указанным маршрутом";
        RouteBox.UseVisualStyleBackColor = false;
        // 
        // AcceptFilters
        // 
        AcceptFilters.BackColor = Color.Transparent;
        AcceptFilters.Cursor = Cursors.Hand;
        AcceptFilters.FlatStyle = FlatStyle.Popup;
        AcceptFilters.ForeColor = Color.Yellow;
        AcceptFilters.Location = new Point(106, 191);
        AcceptFilters.Name = "AcceptFilters";
        AcceptFilters.Size = new Size(148, 29);
        AcceptFilters.TabIndex = 8;
        AcceptFilters.Text = "Применить";
        AcceptFilters.UseVisualStyleBackColor = false;
        AcceptFilters.Click += AcceptFilters_Click;
        AcceptFilters.MouseEnter += button_MouseEnter;
        AcceptFilters.MouseLeave += button_MouseLeave;
        // 
        // MileageFilter
        // 
        MileageFilter.Location = new Point(233, 112);
        MileageFilter.Name = "MileageFilter";
        MileageFilter.Size = new Size(107, 23);
        MileageFilter.TabIndex = 7;
        // 
        // MoreLessBox
        // 
        MoreLessBox.DropDownStyle = ComboBoxStyle.DropDownList;
        MoreLessBox.FormattingEnabled = true;
        MoreLessBox.Items.AddRange(new object[] { "больше", "меньше" });
        MoreLessBox.Location = new Point(141, 113);
        MoreLessBox.Name = "MoreLessBox";
        MoreLessBox.Size = new Size(86, 23);
        MoreLessBox.TabIndex = 6;
        // 
        // MileageBox
        // 
        MileageBox.AutoSize = true;
        MileageBox.BackColor = Color.Transparent;
        MileageBox.ForeColor = Color.Yellow;
        MileageBox.Location = new Point(13, 113);
        MileageBox.Name = "MileageBox";
        MileageBox.Size = new Size(133, 19);
        MileageBox.TabIndex = 5;
        MileageBox.Text = "Пробег транспорта";
        MileageBox.UseVisualStyleBackColor = false;
        // 
        // DriverExistBox
        // 
        DriverExistBox.AutoSize = true;
        DriverExistBox.BackColor = Color.Transparent;
        DriverExistBox.ForeColor = Color.Yellow;
        DriverExistBox.Location = new Point(13, 76);
        DriverExistBox.Name = "DriverExistBox";
        DriverExistBox.Size = new Size(327, 19);
        DriverExistBox.TabIndex = 4;
        DriverExistBox.Text = "Показывать транспорт только с указанным водителем";
        DriverExistBox.UseVisualStyleBackColor = false;
        // 
        // ElementsShown
        // 
        ElementsShown.AutoSize = true;
        ElementsShown.BackColor = Color.Transparent;
        ElementsShown.FlatStyle = FlatStyle.Popup;
        ElementsShown.ForeColor = Color.Yellow;
        ElementsShown.Location = new Point(161, 392);
        ElementsShown.Name = "ElementsShown";
        ElementsShown.Size = new Size(38, 15);
        ElementsShown.TabIndex = 3;
        ElementsShown.Text = "label6";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.BackColor = Color.Transparent;
        label5.FlatStyle = FlatStyle.Popup;
        label5.ForeColor = Color.Yellow;
        label5.Location = new Point(13, 392);
        label5.Name = "label5";
        label5.Size = new Size(142, 15);
        label5.TabIndex = 2;
        label5.Text = "Отображено элементов:";
        // 
        // CloseFilters
        // 
        CloseFilters.BackColor = Color.Transparent;
        CloseFilters.BackgroundImage = Properties.Resources.krest;
        CloseFilters.BackgroundImageLayout = ImageLayout.Center;
        CloseFilters.Cursor = Cursors.Hand;
        CloseFilters.FlatStyle = FlatStyle.Popup;
        CloseFilters.Location = new Point(292, 8);
        CloseFilters.Name = "CloseFilters";
        CloseFilters.Size = new Size(54, 48);
        CloseFilters.TabIndex = 1;
        CloseFilters.UseVisualStyleBackColor = false;
        CloseFilters.Click += CloseFilters_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Transparent;
        label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
        label4.ForeColor = Color.Yellow;
        label4.Location = new Point(138, 8);
        label4.Name = "label4";
        label4.Size = new Size(89, 25);
        label4.TabIndex = 0;
        label4.Text = "Фильтры";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        BackgroundImage = Properties.Resources.fon;
        ClientSize = new Size(822, 545);
        Controls.Add(panel2);
        Controls.Add(FilterBtn);
        Controls.Add(panel1);
        Controls.Add(TransportTable);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "ИС \"Автобусный парк\"";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)TransportTable).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)MileageFilter).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView TransportTable;
    private DataGridViewTextBoxColumn ModelColumn;
    private DataGridViewTextBoxColumn NSPColumn;
    private DataGridViewTextBoxColumn RouteColumn;
    private DataGridViewTextBoxColumn MileageColumn;
    private Button AddNewTransport;
    private Button ExitButton;
    private Button FindBtn;
    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox ModelSearchField;
    private TextBox RouteSearchField;
    private Button ExecuteSearch;
    private Button ClearDB;
    private Panel panel1;
    private Button FilterBtn;
    private Panel panel2;
    private Button CloseFilters;
    private Label label4;
    private Label ElementsShown;
    private Label label5;
    private CheckBox DriverExistBox;
    private ComboBox MoreLessBox;
    private CheckBox MileageBox;
    private NumericUpDown MileageFilter;
    private Button AcceptFilters;
    private CheckBox RouteBox;
}