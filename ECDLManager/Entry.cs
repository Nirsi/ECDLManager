using System;
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

            Form pres = new Presenter();
            pres.Show();

            //Starts generators
            //Global.I.GenerateNTWC();
            //Global.I.GenerateWTNC();
            //Stops generators
            //Global.I.GenerateNTWP();
            //Global.I.GenerateWTNP();
            //Labels Generators
            //Global.I.GenerateNTWL();
            //Global.I.GenerateWTNL();


            WindowState = FormWindowState.Minimized;
            
        }

        private void chb_debugOnOff_CheckedChanged(object sender, EventArgs e)
        {
            if (!Global.I.debugMod)
            {
                Global.I.debugMod = true;
                chb_debugOnOff.ForeColor = Color.Green;
                chb_debugOnOff.Text = "Režim DEBUG je zapnut";
                Text = "ECDL DEBUG";
            }
            else
            {
                Global.I.debugMod = false;
                chb_debugOnOff.ForeColor = Color.Red;
                chb_debugOnOff.Text = "Režim DEBUG je vypnut";
                Text = "ECDL";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Global.I.defaultHlm)
            {
                Global.I.defaultHlm = false;
                chb_highlightColor.ForeColor = Color.Black;
                chb_highlightColor.Text = "Zvýraznění pozastavených v testu černá/bílá";
            }
            else
            {
                Global.I.defaultHlm = true;
                chb_highlightColor.ForeColor = Color.DarkGreen;
                chb_highlightColor.Text = "Zvýraznění pozastavených v testu zelená/červená";
            }

        }

        private void lb_about_Click(object sender, EventArgs e)
        {
            Form about = new AboutInfo();
            about.Show();
        }

        
    }
}
