﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDLManager
{
    public partial class Entry : Form
    {
        public Entry()
        {
            InitializeComponent();
        }

        private void bt_startGenerator_Click(object sender, EventArgs e)
        {
            Form preproc = new Preprocessor();
            preproc.Show();
            WindowState = FormWindowState.Minimized;
        }

        private void bt_startTest_Click(object sender, EventArgs e)
        {
            Form prez = new Prezenter();
            prez.Show();
            Global.I.GenerateNTW();
            Global.I.GenerateWTN();
            WindowState = FormWindowState.Minimized;
            
        }

        private void chb_debugOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (!Global.I.debugMod)
            {
                Global.I.debugMod = true;
                chb_debugOnOff.ForeColor = Color.Green;
                chb_debugOnOff.Text = "Režim DEBUG je zapnut";
                Text = "SPS Debug - ECDL";
            }
            else
            {
                Global.I.debugMod = false;
                chb_debugOnOff.ForeColor = Color.Red;
                chb_debugOnOff.Text = "Režim DEBUG je vypnut";
                Text = "SPS Ostrov - ECDL";
            }
        }
    }
}
