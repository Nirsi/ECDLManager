using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ECDLManager
{
    public partial class DebugOutputForm : Form
    {
        public DebugOutputForm()
        {
            InitializeComponent();
        }

        #region Method for writing to log
        public void testRun()
        {
            for (int i = 0; i < 8; i++)
            {
                rtb_debugLog.AppendText("Test log input #" + i + Environment.NewLine);
            }
            WriteInfo("This is info text");
            WriteWarning("This is warning text");
            WriteError("This is error text");
            
        }
        /// <summary>
        /// Standartní zápis do logu bílou barvou
        /// </summary>
        /// <param name="input"> Zpráva k zobrazení</param>
        public void WriteNormal(string input)
        {
            if (G.I.debugMod)
                rtb_debugLog.AppendText(input + Environment.NewLine);
        }
        /// <summary>
        /// Zápis 'informace' do logu modrou barvou
        /// </summary>
        /// <param name="input"> Zpráva k zobrazení</param>
        public void WriteInfo(string input)
        {
            if (G.I.debugMod)
            {
                rtb_debugLog.SelectionStart = rtb_debugLog.TextLength;
                rtb_debugLog.SelectionLength = 0;
                rtb_debugLog.SelectionColor = Color.Blue;
                rtb_debugLog.AppendText(input + Environment.NewLine);
                rtb_debugLog.SelectionColor = rtb_debugLog.ForeColor; 
            }

        }

        /// <summary>
        /// Zápis 'upozornění' do logu žlutou barvou
        /// </summary>
        /// <param name="input"> Zpráva k zobrazení</param>
        public void WriteWarning(string input)
        {
            if (G.I.debugMod)
            {
                rtb_debugLog.SelectionStart = rtb_debugLog.TextLength;
                rtb_debugLog.SelectionLength = 0;
                rtb_debugLog.SelectionColor = Color.Yellow;
                rtb_debugLog.AppendText(input + Environment.NewLine);
                rtb_debugLog.SelectionColor = rtb_debugLog.ForeColor; 
            }
        }

        /// <summary>
        /// Zápis 'chyby' do logu červenou barvou
        /// </summary>
        /// <param name="input"> Zpráva k zobrazení</param>
        public void WriteError(string input)
        {
            if (G.I.debugMod)
            {
                rtb_debugLog.SelectionStart = rtb_debugLog.TextLength;
                rtb_debugLog.SelectionLength = 0;
                rtb_debugLog.SelectionColor = Color.Red;
                rtb_debugLog.AppendText(input + Environment.NewLine);
                rtb_debugLog.SelectionColor = rtb_debugLog.ForeColor; 
            }
        }


        #endregion

        private void bt_saveLogToFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            DateTime dateTimeNow = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                string outputFileName = @"\" + dateTimeNow.ToShortDateString() + "_" + dateTimeNow.ToShortTimeString().Replace(':', '-') + "_log.txt";
                using (StreamWriter sw = new StreamWriter(new FileStream(fbd.SelectedPath + outputFileName, FileMode.Create, FileAccess.ReadWrite), Encoding.Default))
                {
                    sw.WriteLine(DateTime.Now);
                    sw.WriteLine("*");
                    sw.WriteLine(rtb_debugLog.Text);

                }
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            rtb_debugLog.Clear();
        }

        private void DebugOutputForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            G.I.debugMod = false;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message msg = Message.Create(Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            }
        }
    }
}
