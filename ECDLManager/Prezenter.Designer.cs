namespace ECDLManager
{
    partial class Prezenter
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
            this.lb_examDuration = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_stop = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_examDuration
            // 
            this.lb_examDuration.AutoSize = true;
            this.lb_examDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_examDuration.Location = new System.Drawing.Point(590, 114);
            this.lb_examDuration.Name = "lb_examDuration";
            this.lb_examDuration.Size = new System.Drawing.Size(202, 37);
            this.lb_examDuration.TabIndex = 20;
            this.lb_examDuration.Text = "Trvání testu: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label4.Location = new System.Drawing.Point(246, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 37);
            this.label4.TabIndex = 19;
            this.label4.Text = "Čas zahájení: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label3.Location = new System.Drawing.Point(246, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 37);
            this.label3.TabIndex = 18;
            this.label3.Text = "Datum: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Modul: ";
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bt_start.Location = new System.Drawing.Point(896, 12);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(151, 47);
            this.bt_start.TabIndex = 21;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            // 
            // bt_stop
            // 
            this.bt_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bt_stop.Location = new System.Drawing.Point(986, 93);
            this.bt_stop.Name = "bt_stop";
            this.bt_stop.Size = new System.Drawing.Size(151, 47);
            this.bt_stop.TabIndex = 22;
            this.bt_stop.Text = "Stop";
            this.bt_stop.UseVisualStyleBackColor = true;
            // 
            // bt_reset
            // 
            this.bt_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.bt_reset.Location = new System.Drawing.Point(863, 188);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(151, 47);
            this.bt_reset.TabIndex = 23;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            // 
            // Prezenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 942);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_stop);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.lb_examDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "Prezenter";
            this.Text = "Prezenter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_examDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_stop;
        private System.Windows.Forms.Button bt_reset;
    }
}