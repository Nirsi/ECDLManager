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
            Form prez = new Prezenter();
            prez.Show();
            WindowState = FormWindowState.Minimized;
        }

        
    }
}
