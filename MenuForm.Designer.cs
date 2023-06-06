namespace cours_work_PDD
{
    partial class MenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.ButtonAccountingFilm = new System.Windows.Forms.Button();
            this.ButtonAccountingGuest = new System.Windows.Forms.Button();
            this.ButtonCloseMainForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonAccountingFilm
            // 
            this.ButtonAccountingFilm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAccountingFilm.BackColor = System.Drawing.Color.MintCream;
            this.ButtonAccountingFilm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.ButtonAccountingFilm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccountingFilm.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAccountingFilm.Location = new System.Drawing.Point(222, 107);
            this.ButtonAccountingFilm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonAccountingFilm.Name = "ButtonAccountingFilm";
            this.ButtonAccountingFilm.Size = new System.Drawing.Size(205, 73);
            this.ButtonAccountingFilm.TabIndex = 2;
            this.ButtonAccountingFilm.Text = "Учёт водителей и транспортных средств";
            this.ButtonAccountingFilm.UseVisualStyleBackColor = false;
            this.ButtonAccountingFilm.Click += new System.EventHandler(this.ButtonAccountingFilm_Click);
            // 
            // ButtonAccountingGuest
            // 
            this.ButtonAccountingGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonAccountingGuest.BackColor = System.Drawing.Color.MintCream;
            this.ButtonAccountingGuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.ButtonAccountingGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAccountingGuest.Font = new System.Drawing.Font("Verdana", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAccountingGuest.Location = new System.Drawing.Point(222, 196);
            this.ButtonAccountingGuest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonAccountingGuest.Name = "ButtonAccountingGuest";
            this.ButtonAccountingGuest.Size = new System.Drawing.Size(205, 48);
            this.ButtonAccountingGuest.TabIndex = 5;
            this.ButtonAccountingGuest.Text = "Учёт штрафов";
            this.ButtonAccountingGuest.UseVisualStyleBackColor = false;
            this.ButtonAccountingGuest.Click += new System.EventHandler(this.ButtonAccountingGuest_Click);
            // 
            // ButtonCloseMainForm
            // 
            this.ButtonCloseMainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseMainForm.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ButtonCloseMainForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCloseMainForm.Location = new System.Drawing.Point(526, 317);
            this.ButtonCloseMainForm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ButtonCloseMainForm.Name = "ButtonCloseMainForm";
            this.ButtonCloseMainForm.Size = new System.Drawing.Size(107, 39);
            this.ButtonCloseMainForm.TabIndex = 6;
            this.ButtonCloseMainForm.Text = "Закрыть проект";
            this.ButtonCloseMainForm.UseVisualStyleBackColor = false;
            this.ButtonCloseMainForm.Click += new System.EventHandler(this.ButtonCloseMainForm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LemonChiffon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "     Меню приложения    ";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(642, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonCloseMainForm);
            this.Controls.Add(this.ButtonAccountingGuest);
            this.Controls.Add(this.ButtonAccountingFilm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonAccountingFilm;
        private System.Windows.Forms.Button ButtonAccountingGuest;
        private System.Windows.Forms.Button ButtonCloseMainForm;
        private System.Windows.Forms.Label label1;
    }
}

