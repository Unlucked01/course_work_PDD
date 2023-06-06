namespace cours_work_PDD
{
    partial class BillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsForm));
            this.ButtonCloseGuestTable = new System.Windows.Forms.Button();
            this.ButtonAllDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonDeleteGuest = new System.Windows.Forms.Button();
            this.ButtonCreateGuest = new System.Windows.Forms.Button();
            this.billCount = new System.Windows.Forms.TextBox();
            this.labelCountGuest = new System.Windows.Forms.Label();
            this.billsGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxKolvoSearch = new System.Windows.Forms.TextBox();
            this.labelKolvoSearch = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.billsGrid)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonCloseGuestTable
            // 
            this.ButtonCloseGuestTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCloseGuestTable.BackColor = System.Drawing.Color.LemonChiffon;
            this.ButtonCloseGuestTable.Location = new System.Drawing.Point(20, 388);
            this.ButtonCloseGuestTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCloseGuestTable.Name = "ButtonCloseGuestTable";
            this.ButtonCloseGuestTable.Size = new System.Drawing.Size(92, 39);
            this.ButtonCloseGuestTable.TabIndex = 13;
            this.ButtonCloseGuestTable.Text = "Закрыть форму";
            this.ButtonCloseGuestTable.UseVisualStyleBackColor = false;
            this.ButtonCloseGuestTable.Click += new System.EventHandler(this.ButtonCloseGuestTable_Click);
            // 
            // ButtonAllDeleteGuest
            // 
            this.ButtonAllDeleteGuest.BackColor = System.Drawing.Color.MintCream;
            this.ButtonAllDeleteGuest.Location = new System.Drawing.Point(200, 21);
            this.ButtonAllDeleteGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonAllDeleteGuest.Name = "ButtonAllDeleteGuest";
            this.ButtonAllDeleteGuest.Size = new System.Drawing.Size(92, 39);
            this.ButtonAllDeleteGuest.TabIndex = 12;
            this.ButtonAllDeleteGuest.Text = "Удалить все штрафы";
            this.ButtonAllDeleteGuest.UseVisualStyleBackColor = false;
            this.ButtonAllDeleteGuest.Click += new System.EventHandler(this.ButtonAllDeleteGuest_Click);
            // 
            // ButtonDeleteGuest
            // 
            this.ButtonDeleteGuest.BackColor = System.Drawing.Color.MintCream;
            this.ButtonDeleteGuest.Location = new System.Drawing.Point(104, 21);
            this.ButtonDeleteGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonDeleteGuest.Name = "ButtonDeleteGuest";
            this.ButtonDeleteGuest.Size = new System.Drawing.Size(92, 39);
            this.ButtonDeleteGuest.TabIndex = 11;
            this.ButtonDeleteGuest.Text = "Удалить штраф";
            this.ButtonDeleteGuest.UseVisualStyleBackColor = false;
            this.ButtonDeleteGuest.Click += new System.EventHandler(this.ButtonDeleteGuest_Click);
            // 
            // ButtonCreateGuest
            // 
            this.ButtonCreateGuest.BackColor = System.Drawing.Color.MintCream;
            this.ButtonCreateGuest.Location = new System.Drawing.Point(8, 21);
            this.ButtonCreateGuest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonCreateGuest.Name = "ButtonCreateGuest";
            this.ButtonCreateGuest.Size = new System.Drawing.Size(92, 39);
            this.ButtonCreateGuest.TabIndex = 10;
            this.ButtonCreateGuest.Text = "Добавить штраф";
            this.ButtonCreateGuest.UseVisualStyleBackColor = false;
            this.ButtonCreateGuest.Click += new System.EventHandler(this.ButtonCreateGuest_Click);
            // 
            // billCount
            // 
            this.billCount.Location = new System.Drawing.Point(308, 36);
            this.billCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billCount.Name = "billCount";
            this.billCount.ReadOnly = true;
            this.billCount.Size = new System.Drawing.Size(86, 20);
            this.billCount.TabIndex = 9;
            // 
            // labelCountGuest
            // 
            this.labelCountGuest.AutoSize = true;
            this.labelCountGuest.Location = new System.Drawing.Point(298, 21);
            this.labelCountGuest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCountGuest.Name = "labelCountGuest";
            this.labelCountGuest.Size = new System.Drawing.Size(114, 13);
            this.labelCountGuest.TabIndex = 8;
            this.labelCountGuest.Text = "Количество штрафов";
            // 
            // billsGrid
            // 
            this.billsGrid.AllowUserToAddRows = false;
            this.billsGrid.AllowUserToDeleteRows = false;
            this.billsGrid.AllowUserToResizeColumns = false;
            this.billsGrid.AllowUserToResizeRows = false;
            this.billsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.billsGrid.BackgroundColor = System.Drawing.Color.Lavender;
            this.billsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.billsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.billsGrid.Location = new System.Drawing.Point(2, 15);
            this.billsGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billsGrid.Name = "billsGrid";
            this.billsGrid.RowHeadersVisible = false;
            this.billsGrid.RowHeadersWidth = 51;
            this.billsGrid.RowTemplate.Height = 24;
            this.billsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.billsGrid.Size = new System.Drawing.Size(841, 269);
            this.billsGrid.TabIndex = 7;
            this.billsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billsGrid_CellContentClick);
            this.billsGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuestTable_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ФИО водителя";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Автомобиль";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Причина штрафа";
            this.Column3.MinimumWidth = 10;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Итоговая сумма";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Оплачен?";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Фильтрация поля";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.textBoxKolvoSearch);
            this.groupBox3.Controls.Add(this.labelKolvoSearch);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(432, 312);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(419, 115);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Поиск и Фильтрация";
            // 
            // textBoxKolvoSearch
            // 
            this.textBoxKolvoSearch.Location = new System.Drawing.Point(201, 83);
            this.textBoxKolvoSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxKolvoSearch.Name = "textBoxKolvoSearch";
            this.textBoxKolvoSearch.ReadOnly = true;
            this.textBoxKolvoSearch.Size = new System.Drawing.Size(114, 20);
            this.textBoxKolvoSearch.TabIndex = 33;
            this.textBoxKolvoSearch.Visible = false;
            // 
            // labelKolvoSearch
            // 
            this.labelKolvoSearch.AutoSize = true;
            this.labelKolvoSearch.Location = new System.Drawing.Point(4, 86);
            this.labelKolvoSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelKolvoSearch.Name = "labelKolvoSearch";
            this.labelKolvoSearch.Size = new System.Drawing.Size(169, 13);
            this.labelKolvoSearch.TabIndex = 32;
            this.labelKolvoSearch.Text = "Количество найденных записей";
            this.labelKolvoSearch.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(200, 55);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(115, 20);
            this.textBox2.TabIndex = 31;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(323, 81);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 22);
            this.button2.TabIndex = 30;
            this.button2.Text = "Сбросить поиск";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MintCream;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(323, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 22);
            this.button1.TabIndex = 29;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "по";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 2);
            this.panel1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ФИО водителя",
            "Автомобилю",
            "Причина штрафа",
            "Итоговой сумме"});
            this.comboBox2.Location = new System.Drawing.Point(62, 54);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Поиск по";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ФИО водителя",
            "Автомобилю",
            "Причне штрафа",
            "Сумме штрафа"});
            this.comboBox1.Location = new System.Drawing.Point(124, 19);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(283, 19);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.billCount);
            this.groupBox2.Controls.Add(this.labelCountGuest);
            this.groupBox2.Controls.Add(this.ButtonCreateGuest);
            this.groupBox2.Controls.Add(this.ButtonAllDeleteGuest);
            this.groupBox2.Controls.Add(this.ButtonDeleteGuest);
            this.groupBox2.Location = new System.Drawing.Point(12, 312);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(416, 69);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Взаимодействие";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.billsGrid);
            this.groupBox1.Location = new System.Drawing.Point(6, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(845, 286);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Штрафы";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 6);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Показать только оплаченные";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(855, 437);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCloseGuestTable);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BillsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт штрафов";
            this.Load += new System.EventHandler(this.GuestFestivalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billsGrid)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCloseGuestTable;
        private System.Windows.Forms.Button ButtonAllDeleteGuest;
        private System.Windows.Forms.Button ButtonDeleteGuest;
        private System.Windows.Forms.Button ButtonCreateGuest;
        private System.Windows.Forms.TextBox billCount;
        private System.Windows.Forms.Label labelCountGuest;
        private System.Windows.Forms.DataGridView billsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBoxKolvoSearch;
        private System.Windows.Forms.Label labelKolvoSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}