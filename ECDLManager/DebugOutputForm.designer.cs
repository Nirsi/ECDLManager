namespace ECDLManager
{
    partial class DebugOutputForm
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
            this.rtb_debugLog = new System.Windows.Forms.RichTextBox();
            this.bt_saveLogToFile = new System.Windows.Forms.Button();
            this.bt_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_debugLog
            // 
            this.rtb_debugLog.BackColor = System.Drawing.Color.Black;
            this.rtb_debugLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_debugLog.ForeColor = System.Drawing.Color.White;
            this.rtb_debugLog.Location = new System.Drawing.Point(12, 12);
            this.rtb_debugLog.Name = "rtb_debugLog";
            this.rtb_debugLog.ReadOnly = true;
            this.rtb_debugLog.Size = new System.Drawing.Size(578, 210);
            this.rtb_debugLog.TabIndex = 0;
            this.rtb_debugLog.Text = "";
            // 
            // bt_saveLogToFile
            // 
            this.bt_saveLogToFile.BackColor = System.Drawing.Color.LightGray;
            this.bt_saveLogToFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_saveLogToFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_saveLogToFile.Location = new System.Drawing.Point(366, 228);
            this.bt_saveLogToFile.Name = "bt_saveLogToFile";
            this.bt_saveLogToFile.Size = new System.Drawing.Size(140, 34);
            this.bt_saveLogToFile.TabIndex = 1;
            this.bt_saveLogToFile.Text = "Export log";
            this.bt_saveLogToFile.UseVisualStyleBackColor = false;
            this.bt_saveLogToFile.Click += new System.EventHandler(this.bt_saveLogToFile_Click);
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.LightGray;
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_clear.Location = new System.Drawing.Point(85, 228);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(140, 34);
            this.bt_clear.TabIndex = 2;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // DebugOutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(602, 264);
            this.Controls.Add(this.bt_clear);
            this.Controls.Add(this.bt_saveLogToFile);
            this.Controls.Add(this.rtb_debugLog);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebugOutputForm";
            this.Text = "DebugOutputForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugOutputForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_debugLog;
        private System.Windows.Forms.Button bt_saveLogToFile;
        private System.Windows.Forms.Button bt_clear;
    }
}