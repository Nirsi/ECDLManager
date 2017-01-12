﻿namespace ECDLManager
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
            this.lb_about = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_menu = new System.Windows.Forms.TabPage();
            this.tp_options = new System.Windows.Forms.TabPage();
            this.chb_highlightColor = new System.Windows.Forms.CheckBox();
            this.chb_debugOnOff = new System.Windows.Forms.CheckBox();
            this.nud_contentBlockOffsetX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_contentBlockOffsetY = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tp_menu.SuspendLayout();
            this.tp_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_contentBlockOffsetX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_contentBlockOffsetY)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_startGenerator
            // 
            this.bt_startGenerator.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bt_startGenerator.Location = new System.Drawing.Point(6, 6);
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
            this.bt_startTest.Location = new System.Drawing.Point(220, 6);
            this.bt_startTest.Name = "bt_startTest";
            this.bt_startTest.Size = new System.Drawing.Size(208, 102);
            this.bt_startTest.TabIndex = 1;
            this.bt_startTest.Text = "Test";
            this.bt_startTest.UseVisualStyleBackColor = true;
            this.bt_startTest.Click += new System.EventHandler(this.bt_startTest_Click);
            // 
            // lb_about
            // 
            this.lb_about.AutoSize = true;
            this.lb_about.Font = new System.Drawing.Font("Consolas", 14.25F);
            this.lb_about.Location = new System.Drawing.Point(163, 111);
            this.lb_about.Name = "lb_about";
            this.lb_about.Size = new System.Drawing.Size(110, 22);
            this.lb_about.TabIndex = 3;
            this.lb_about.Text = "O Aplikaci";
            this.lb_about.Click += new System.EventHandler(this.lb_about_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_menu);
            this.tabControl1.Controls.Add(this.tp_options);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(445, 163);
            this.tabControl1.TabIndex = 4;
            // 
            // tp_menu
            // 
            this.tp_menu.BackColor = System.Drawing.SystemColors.Control;
            this.tp_menu.Controls.Add(this.bt_startTest);
            this.tp_menu.Controls.Add(this.lb_about);
            this.tp_menu.Controls.Add(this.bt_startGenerator);
            this.tp_menu.Location = new System.Drawing.Point(4, 22);
            this.tp_menu.Name = "tp_menu";
            this.tp_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_menu.Size = new System.Drawing.Size(437, 137);
            this.tp_menu.TabIndex = 0;
            this.tp_menu.Text = "Menu";
            // 
            // tp_options
            // 
            this.tp_options.BackColor = System.Drawing.SystemColors.Control;
            this.tp_options.Controls.Add(this.nud_contentBlockOffsetY);
            this.tp_options.Controls.Add(this.label2);
            this.tp_options.Controls.Add(this.label1);
            this.tp_options.Controls.Add(this.nud_contentBlockOffsetX);
            this.tp_options.Controls.Add(this.chb_highlightColor);
            this.tp_options.Controls.Add(this.chb_debugOnOff);
            this.tp_options.Location = new System.Drawing.Point(4, 22);
            this.tp_options.Name = "tp_options";
            this.tp_options.Padding = new System.Windows.Forms.Padding(3);
            this.tp_options.Size = new System.Drawing.Size(437, 137);
            this.tp_options.TabIndex = 1;
            this.tp_options.Text = "Nastavení";
            // 
            // chb_highlightColor
            // 
            this.chb_highlightColor.AutoSize = true;
            this.chb_highlightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_highlightColor.Font = new System.Drawing.Font("Consolas", 11F);
            this.chb_highlightColor.ForeColor = System.Drawing.Color.DarkGreen;
            this.chb_highlightColor.Location = new System.Drawing.Point(7, 34);
            this.chb_highlightColor.Name = "chb_highlightColor";
            this.chb_highlightColor.Size = new System.Drawing.Size(400, 22);
            this.chb_highlightColor.TabIndex = 3;
            this.chb_highlightColor.Text = "Zvýraznění pozastavených v testu zelená/červená";
            this.chb_highlightColor.UseVisualStyleBackColor = true;
            this.chb_highlightColor.CheckedChanged += new System.EventHandler(this.chb_highlightColor_CheckedChanged);
            // 
            // chb_debugOnOff
            // 
            this.chb_debugOnOff.AutoSize = true;
            this.chb_debugOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_debugOnOff.Font = new System.Drawing.Font("Consolas", 11F);
            this.chb_debugOnOff.ForeColor = System.Drawing.Color.Red;
            this.chb_debugOnOff.Location = new System.Drawing.Point(6, 6);
            this.chb_debugOnOff.Name = "chb_debugOnOff";
            this.chb_debugOnOff.Size = new System.Drawing.Size(192, 22);
            this.chb_debugOnOff.TabIndex = 2;
            this.chb_debugOnOff.Text = "Režim DEBUG je vypnut";
            this.chb_debugOnOff.UseVisualStyleBackColor = true;
            this.chb_debugOnOff.CheckedChanged += new System.EventHandler(this.chb_debugOnOff_CheckedChanged);
            // 
            // nud_contentBlockOffsetX
            // 
            this.nud_contentBlockOffsetX.Location = new System.Drawing.Point(117, 62);
            this.nud_contentBlockOffsetX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_contentBlockOffsetX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_contentBlockOffsetX.Name = "nud_contentBlockOffsetX";
            this.nud_contentBlockOffsetX.Size = new System.Drawing.Size(120, 20);
            this.nud_contentBlockOffsetX.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F);
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Odsazení X: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11F);
            this.label2.Location = new System.Drawing.Point(7, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Odsazení Y: ";
            // 
            // nud_contentBlockOffsetY
            // 
            this.nud_contentBlockOffsetY.Location = new System.Drawing.Point(117, 88);
            this.nud_contentBlockOffsetY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_contentBlockOffsetY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.nud_contentBlockOffsetY.Name = "nud_contentBlockOffsetY";
            this.nud_contentBlockOffsetY.Size = new System.Drawing.Size(120, 20);
            this.nud_contentBlockOffsetY.TabIndex = 7;
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 160);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entry";
            this.Text = "ECDL";
            this.tabControl1.ResumeLayout(false);
            this.tp_menu.ResumeLayout(false);
            this.tp_menu.PerformLayout();
            this.tp_options.ResumeLayout(false);
            this.tp_options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_contentBlockOffsetX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_contentBlockOffsetY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_startGenerator;
        private System.Windows.Forms.Button bt_startTest;
        private System.Windows.Forms.Label lb_about;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_menu;
        private System.Windows.Forms.TabPage tp_options;
        private System.Windows.Forms.CheckBox chb_debugOnOff;
        private System.Windows.Forms.CheckBox chb_highlightColor;
        private System.Windows.Forms.NumericUpDown nud_contentBlockOffsetY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_contentBlockOffsetX;
    }
}