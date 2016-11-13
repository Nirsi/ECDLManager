namespace ECDLManager
{
    partial class Entry
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
            this.bt_startGenerator = new System.Windows.Forms.Button();
            this.bt_startTest = new System.Windows.Forms.Button();
            this.chb_debugOnOff = new System.Windows.Forms.CheckBox();
            this.lb_about = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_startGenerator
            // 
            this.bt_startGenerator.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_startGenerator.Location = new System.Drawing.Point(12, 12);
            this.bt_startGenerator.Name = "bt_startGenerator";
            this.bt_startGenerator.Size = new System.Drawing.Size(208, 102);
            this.bt_startGenerator.TabIndex = 0;
            this.bt_startGenerator.Text = "Generátor";
            this.bt_startGenerator.UseVisualStyleBackColor = true;
            this.bt_startGenerator.Click += new System.EventHandler(this.bt_startGenerator_Click);
            // 
            // bt_startTest
            // 
            this.bt_startTest.Font = new System.Drawing.Font("Consolas", 21.75F);
            this.bt_startTest.Location = new System.Drawing.Point(226, 12);
            this.bt_startTest.Name = "bt_startTest";
            this.bt_startTest.Size = new System.Drawing.Size(208, 100);
            this.bt_startTest.TabIndex = 1;
            this.bt_startTest.Text = "Test";
            this.bt_startTest.UseVisualStyleBackColor = true;
            this.bt_startTest.Click += new System.EventHandler(this.bt_startTest_Click);
            // 
            // chb_debugOnOff
            // 
            this.chb_debugOnOff.AutoSize = true;
            this.chb_debugOnOff.Font = new System.Drawing.Font("Consolas", 11F);
            this.chb_debugOnOff.ForeColor = System.Drawing.Color.Red;
            this.chb_debugOnOff.Location = new System.Drawing.Point(29, 120);
            this.chb_debugOnOff.Name = "chb_debugOnOff";
            this.chb_debugOnOff.Size = new System.Drawing.Size(195, 22);
            this.chb_debugOnOff.TabIndex = 2;
            this.chb_debugOnOff.Text = "Režim DEBUG je vypnut";
            this.chb_debugOnOff.UseVisualStyleBackColor = true;
            this.chb_debugOnOff.CheckedChanged += new System.EventHandler(this.chb_debugOnOff_CheckedChanged);
            // 
            // lb_about
            // 
            this.lb_about.AutoSize = true;
            this.lb_about.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_about.Location = new System.Drawing.Point(276, 118);
            this.lb_about.Name = "lb_about";
            this.lb_about.Size = new System.Drawing.Size(110, 22);
            this.lb_about.TabIndex = 3;
            this.lb_about.Text = "O Aplikaci";
            this.lb_about.Click += new System.EventHandler(this.lb_about_Click);
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 149);
            this.Controls.Add(this.lb_about);
            this.Controls.Add(this.chb_debugOnOff);
            this.Controls.Add(this.bt_startTest);
            this.Controls.Add(this.bt_startGenerator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entry";
            this.Text = "ECDL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_startGenerator;
        private System.Windows.Forms.Button bt_startTest;
        private System.Windows.Forms.CheckBox chb_debugOnOff;
        private System.Windows.Forms.Label lb_about;
    }
}