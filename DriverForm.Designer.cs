namespace cours_work_PDD
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.TextBox();
            this.BirthDate = new System.Windows.Forms.DateTimePicker();
            this.License = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 75);
            this.label5.TabIndex = 4;
            this.label5.Text = "Серия и номер\r\nводительского \r\nудостоверения";
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(208, 23);
            this.Surname.Margin = new System.Windows.Forms.Padding(4);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(192, 31);
            this.Surname.TabIndex = 5;
            this.Surname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            this.Surname.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(208, 65);
            this.Name.Margin = new System.Windows.Forms.Padding(4);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(192, 31);
            this.Name.TabIndex = 6;
            this.Name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            this.Name.Validated += new System.EventHandler(this.textBox2_Validated);
            // 
            // Lastname
            // 
            this.Lastname.Location = new System.Drawing.Point(208, 112);
            this.Lastname.Margin = new System.Windows.Forms.Padding(4);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(192, 31);
            this.Lastname.TabIndex = 7;
            this.Lastname.Validating += new System.ComponentModel.CancelEventHandler(this.lastname_Validating);
            this.Lastname.Validated += new System.EventHandler(this.lastname_Validated);
            // 
            // BirthDate
            // 
            this.BirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthDate.Location = new System.Drawing.Point(208, 158);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(4);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(192, 31);
            this.BirthDate.TabIndex = 8;
            this.BirthDate.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // License
            // 
            this.License.Location = new System.Drawing.Point(208, 225);
            this.License.Margin = new System.Windows.Forms.Padding(4);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(192, 31);
            this.License.TabIndex = 9;
            this.License.Validating += new System.ComponentModel.CancelEventHandler(this.license_Validating);
            this.License.Validated += new System.EventHandler(this.license_Validated);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LemonChiffon;
            this.button1.Location = new System.Drawing.Point(22, 315);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 52);
            this.button1.TabIndex = 10;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MintCream;
            this.button2.Location = new System.Drawing.Point(268, 315);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 52);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(464, 387);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.License);
            this.Controls.Add(this.BirthDate);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            //this.Name = "Добавление штрафа";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Добавление водителя";
            this.Load += new System.EventHandler(this.DriverForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Lastname;
        private System.Windows.Forms.DateTimePicker BirthDate;
        private System.Windows.Forms.TextBox License;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}