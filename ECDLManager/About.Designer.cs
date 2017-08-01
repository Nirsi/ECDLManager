namespace ECDLManager
{
    partial class About
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
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
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_appName = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_author = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.lb_projectLink = new System.Windows.Forms.Label();
            this.lb_license = new System.Windows.Forms.Label();
            this.lb_feedback = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_appName
            // 
            this.lb_appName.AutoSize = true;
            this.lb_appName.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_appName.Location = new System.Drawing.Point(100, 9);
            this.lb_appName.Name = "lb_appName";
            this.lb_appName.Size = new System.Drawing.Size(105, 32);
            this.lb_appName.TabIndex = 0;
            this.lb_appName.Text = "label1";
            // 
            // lb_version
            // 
            this.lb_version.AutoSize = true;
            this.lb_version.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_version.Location = new System.Drawing.Point(102, 52);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(110, 22);
            this.lb_version.TabIndex = 1;
            this.lb_version.Text = "lb_version";
            // 
            // lb_author
            // 
            this.lb_author.AutoSize = true;
            this.lb_author.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_author.Location = new System.Drawing.Point(96, 92);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(100, 22);
            this.lb_author.TabIndex = 2;
            this.lb_author.Text = "lb_author";
            // 
            // tb_description
            // 
            this.tb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_description.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_description.Location = new System.Drawing.Point(44, 168);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.Size = new System.Drawing.Size(285, 93);
            this.tb_description.TabIndex = 4;
            this.tb_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_projectLink
            // 
            this.lb_projectLink.AutoSize = true;
            this.lb_projectLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_projectLink.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_projectLink.Location = new System.Drawing.Point(102, 274);
            this.lb_projectLink.Name = "lb_projectLink";
            this.lb_projectLink.Size = new System.Drawing.Size(150, 22);
            this.lb_projectLink.TabIndex = 5;
            this.lb_projectLink.Text = "lb_projectLink";
            this.lb_projectLink.Click += new System.EventHandler(this.lb_projectLink_Click);
            // 
            // lb_license
            // 
            this.lb_license.AutoSize = true;
            this.lb_license.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_license.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_license.Location = new System.Drawing.Point(128, 137);
            this.lb_license.Name = "lb_license";
            this.lb_license.Size = new System.Drawing.Size(110, 22);
            this.lb_license.TabIndex = 6;
            this.lb_license.Text = "lb_license";
            this.lb_license.Click += new System.EventHandler(this.lb_license_Click);
            // 
            // lb_feedback
            // 
            this.lb_feedback.AutoSize = true;
            this.lb_feedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_feedback.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_feedback.Location = new System.Drawing.Point(116, 315);
            this.lb_feedback.Name = "lb_feedback";
            this.lb_feedback.Size = new System.Drawing.Size(120, 22);
            this.lb_feedback.TabIndex = 7;
            this.lb_feedback.Text = "lb_feedBack";
            this.lb_feedback.Click += new System.EventHandler(this.lb_feedback_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 346);
            this.Controls.Add(this.lb_feedback);
            this.Controls.Add(this.lb_license);
            this.Controls.Add(this.lb_projectLink);
            this.Controls.Add(this.tb_description);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_version);
            this.Controls.Add(this.lb_appName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_appName;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.TextBox tb_description;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Label lb_projectLink;
        private System.Windows.Forms.Label lb_license;
        private System.Windows.Forms.Label lb_feedback;
    }
}
