namespace ECDLManager
{
    partial class AboutInfo
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lb_programName = new System.Windows.Forms.Label();
            this.lb_version = new System.Windows.Forms.Label();
            this.lb_author = new System.Windows.Forms.Label();
            this.lb_groupName = new System.Windows.Forms.Label();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.lb_programName, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.lb_version, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_author, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.lb_groupName, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.tb_description, 0, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(295, 265);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // lb_programName
            // 
            this.lb_programName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_programName.Location = new System.Drawing.Point(6, 0);
            this.lb_programName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lb_programName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lb_programName.Name = "lb_programName";
            this.lb_programName.Size = new System.Drawing.Size(286, 17);
            this.lb_programName.TabIndex = 19;
            this.lb_programName.Text = "Product name";
            this.lb_programName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_programName.Click += new System.EventHandler(this.lb_programName_Click);
            // 
            // lb_version
            // 
            this.lb_version.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_version.Location = new System.Drawing.Point(6, 29);
            this.lb_version.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lb_version.MaximumSize = new System.Drawing.Size(0, 17);
            this.lb_version.Name = "lb_version";
            this.lb_version.Size = new System.Drawing.Size(286, 17);
            this.lb_version.TabIndex = 0;
            this.lb_version.Text = "Version";
            this.lb_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_author
            // 
            this.lb_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_author.Location = new System.Drawing.Point(6, 58);
            this.lb_author.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lb_author.MaximumSize = new System.Drawing.Size(0, 17);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(286, 17);
            this.lb_author.TabIndex = 21;
            this.lb_author.Text = "Author";
            this.lb_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_groupName
            // 
            this.lb_groupName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_groupName.Location = new System.Drawing.Point(6, 87);
            this.lb_groupName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.lb_groupName.MaximumSize = new System.Drawing.Size(0, 17);
            this.lb_groupName.Name = "lb_groupName";
            this.lb_groupName.Size = new System.Drawing.Size(286, 17);
            this.lb_groupName.TabIndex = 22;
            this.lb_groupName.Text = "Group";
            this.lb_groupName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_description
            // 
            this.tb_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_description.Location = new System.Drawing.Point(6, 119);
            this.tb_description.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.ReadOnly = true;
            this.tb_description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_description.Size = new System.Drawing.Size(286, 143);
            this.tb_description.TabIndex = 23;
            this.tb_description.TabStop = false;
            this.tb_description.Text = "Desc";
            // 
            // AboutInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 283);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutInfo";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutInfo";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label lb_programName;
        private System.Windows.Forms.Label lb_version;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Label lb_groupName;
        private System.Windows.Forms.TextBox tb_description;
    }
}
