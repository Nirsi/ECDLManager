namespace ECDLManager
{
    partial class Presenter
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
            this.lb_examDuration = new System.Windows.Forms.Label();
            this.lb_examBeginning = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_modul = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.bt_loadFile = new System.Windows.Forms.Button();
            this.ofd_inputFile = new System.Windows.Forms.OpenFileDialog();
            this.tmr_seconds = new System.Windows.Forms.Timer(this.components);
            this.lb_about = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_examDuration
            // 
            this.lb_examDuration.AutoSize = true;
            this.lb_examDuration.Font = new System.Drawing.Font("Consolas", 24F);
            this.lb_examDuration.Location = new System.Drawing.Point(246, 103);
            this.lb_examDuration.Name = "lb_examDuration";
            this.lb_examDuration.Size = new System.Drawing.Size(269, 37);
            this.lb_examDuration.TabIndex = 20;
            this.lb_examDuration.Text = "Trvání testu: ";
            // 
            // lb_examBeginning
            // 
            this.lb_examBeginning.AutoSize = true;
            this.lb_examBeginning.Font = new System.Drawing.Font("Consolas", 24F);
            this.lb_examBeginning.Location = new System.Drawing.Point(246, 58);
            this.lb_examBeginning.Name = "lb_examBeginning";
            this.lb_examBeginning.Size = new System.Drawing.Size(269, 37);
            this.lb_examBeginning.TabIndex = 19;
            this.lb_examBeginning.Text = "Čas zahájení: ";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Font = new System.Drawing.Font("Consolas", 24F);
            this.lb_date.Location = new System.Drawing.Point(246, 8);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(143, 37);
            this.lb_date.TabIndex = 18;
            this.lb_date.Text = "Datum: ";
            // 
            // lb_modul
            // 
            this.lb_modul.AutoSize = true;
            this.lb_modul.Font = new System.Drawing.Font("Consolas", 24F);
            this.lb_modul.Location = new System.Drawing.Point(12, 9);
            this.lb_modul.Name = "lb_modul";
            this.lb_modul.Size = new System.Drawing.Size(143, 37);
            this.lb_modul.TabIndex = 17;
            this.lb_modul.Text = "Modul: ";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Consolas", 24F);
            this.bt_start.Location = new System.Drawing.Point(707, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(151, 47);
            this.bt_start.TabIndex = 21;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("Consolas", 24F);
            this.bt_stop.Location = new System.Drawing.Point(864, 12);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(151, 47);
            this.bt_stop.TabIndex = 22;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            this.bt_stop.Click += new System.EventHandler(this.bt_stop_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_reset.Location = new System.Drawing.Point(1021, 12);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(151, 47);
            this.bt_reset.TabIndex = 23;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // bt_loadFile
            // 
            this.bt_loadFile.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_loadFile.Location = new System.Drawing.Point(12, 58);
            this.bt_loadFile.Name = "bt_loadFile";
            this.bt_loadFile.Size = new System.Drawing.Size(198, 37);
            this.bt_loadFile.TabIndex = 24;
            this.bt_loadFile.Text = "Načíst Data";
            this.bt_loadFile.UseVisualStyleBackColor = true;
            this.bt_loadFile.Click += new System.EventHandler(this.bt_loadFile_Click);
            // 
            // ofd_inputFile
            // 
            this.ofd_inputFile.FileName = "formatedList";
            this.ofd_inputFile.Filter = "CSV|*.csv";
            // 
            // tmr_seconds
            // 
            this.tmr_seconds.Interval = 1000;
            this.tmr_seconds.Tick += new System.EventHandler(this.tmr_seconds_Tick);
            // 
            // lb_about
            // 
            this.lb_about.AutoSize = true;
            this.lb_about.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_about.Location = new System.Drawing.Point(521, 911);
            this.lb_about.Name = "lb_about";
            this.lb_about.Size = new System.Drawing.Size(110, 22);
            this.lb_about.TabIndex = 25;
            this.lb_about.Text = "O aplikaci";
            this.lb_about.Click += new System.EventHandler(this.lb_about_Click);
            // 
            // Presenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 942);
            this.Controls.Add(this.lb_about);
            this.Controls.Add(this.bt_loadFile);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_examDuration);
            this.Controls.Add(this.lb_examBeginning);
            this.Controls.Add(this.lb_date);
            this.Controls.Add(this.lb_modul);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Presenter";
            this.Text = "ECDL Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_examDuration;
        private System.Windows.Forms.Label lb_examBeginning;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label lb_modul;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.Button bt_loadFile;
        private System.Windows.Forms.OpenFileDialog ofd_inputFile;
        private System.Windows.Forms.Timer tmr_seconds;
        private System.Windows.Forms.Label lb_about;
    }
}