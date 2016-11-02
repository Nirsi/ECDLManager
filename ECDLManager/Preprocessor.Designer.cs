namespace ECDLManager
{
    partial class Preprocessor
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_modulName = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_time = new System.Windows.Forms.TextBox();
            this.tb_filePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_originFileName = new System.Windows.Forms.Label();
            this.bt_loadData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ofd_inputFile = new System.Windows.Forms.OpenFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_testDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_modulName
            // 
            this.tb_modulName.Location = new System.Drawing.Point(87, 62);
            this.tb_modulName.MaxLength = 2;
            this.tb_modulName.Name = "tb_modulName";
            this.tb_modulName.Size = new System.Drawing.Size(188, 20);
            this.tb_modulName.TabIndex = 0;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(87, 115);
            this.tb_date.MaxLength = 10;
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(188, 20);
            this.tb_date.TabIndex = 1;
            // 
            // tb_time
            // 
            this.tb_time.Location = new System.Drawing.Point(339, 67);
            this.tb_time.MaxLength = 5;
            this.tb_time.Name = "tb_time";
            this.tb_time.Size = new System.Drawing.Size(185, 20);
            this.tb_time.TabIndex = 2;
            // 
            // tb_filePath
            // 
            this.tb_filePath.Location = new System.Drawing.Point(157, 11);
            this.tb_filePath.Name = "tb_filePath";
            this.tb_filePath.Size = new System.Drawing.Size(473, 20);
            this.tb_filePath.TabIndex = 3;
            this.tb_filePath.DoubleClick += new System.EventHandler(this.tb_filePath_DoubleClick);
            this.tb_filePath.MouseEnter += new System.EventHandler(this.tb_filePath_MouseEnter);
            this.tb_filePath.MouseLeave += new System.EventHandler(this.tb_filePath_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cesta k seznamu: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Modul: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(281, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Čas: ";
            // 
            // lb_originFileName
            // 
            this.lb_originFileName.AutoSize = true;
            this.lb_originFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lb_originFileName.Location = new System.Drawing.Point(232, 273);
            this.lb_originFileName.Name = "lb_originFileName";
            this.lb_originFileName.Size = new System.Drawing.Size(234, 24);
            this.lb_originFileName.TabIndex = 8;
            this.lb_originFileName.Text = "název zdrojového souboru";
            // 
            // bt_loadData
            // 
            this.bt_loadData.Location = new System.Drawing.Point(637, 9);
            this.bt_loadData.Name = "bt_loadData";
            this.bt_loadData.Size = new System.Drawing.Size(75, 23);
            this.bt_loadData.TabIndex = 9;
            this.bt_loadData.Text = "Načíst";
            this.bt_loadData.UseVisualStyleBackColor = true;
            this.bt_loadData.Click += new System.EventHandler(this.bt_loadData_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Location = new System.Drawing.Point(267, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "Vygenerovat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ofd_inputFile
            // 
            this.ofd_inputFile.FileName = "seznam";
            this.ofd_inputFile.Filter = "CSV|*.csv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label5.Location = new System.Drawing.Point(281, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Trvání testu: ";
            // 
            // tb_testDuration
            // 
            this.tb_testDuration.Location = new System.Drawing.Point(403, 114);
            this.tb_testDuration.MaxLength = 2;
            this.tb_testDuration.Name = "tb_testDuration";
            this.tb_testDuration.Size = new System.Drawing.Size(121, 20);
            this.tb_testDuration.TabIndex = 11;
            // 
            // Preprocessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 464);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_testDuration);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_loadData);
            this.Controls.Add(this.lb_originFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_filePath);
            this.Controls.Add(this.tb_time);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_modulName);
            this.Name = "Preprocessor";
            this.Text = "Preprocessor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_modulName;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_time;
        private System.Windows.Forms.TextBox tb_filePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_originFileName;
        private System.Windows.Forms.Button bt_loadData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ofd_inputFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_testDuration;
    }
}

