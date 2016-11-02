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
    public partial class Preprocessor : Form
    {
        List<rawStudent> rawStudents = new List<rawStudent>();
        string tempListContent = string.Empty;


        public Preprocessor()
        {
            InitializeComponent();
        }

        private void tb_filePath_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = ofd_inputFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    tb_filePath.Text = ofd_inputFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void bt_loadData_Click(object sender, EventArgs e)
        {
            string tempListContent = string.Empty;
            using (StreamReader sr = new StreamReader(tb_filePath.Text, Encoding.ASCII))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(' ');
                    rawStudents.Add(new rawStudent(data[0], data[1]));
                }
#if DEBUG
                //foreach (var rs in rawStudents)
                //{
                //    tempListContent += "students name: " + rs.name + ", students lastname: " + rs.lastname;
                //}

                //MessageBox.Show("\n" + tempListContent,"DEBUG : rawStudents list");
#endif
            }
        }

        private void GenerateFormatedData()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MessageBox.Show(fbd.SelectedPath.ToString());



                using(StreamWriter sw = new StreamWriter(fbd.SelectedPath + @"\formatedList.csv"))
                {
                    sw.WriteLine("modul;datum;cas;trvani");
                    foreach (rawStudent rs in rawStudents)
                    {
                        sw.WriteLine(rs.name + ";" + rs.lastname + ";" + tb_testDuration.Text);
                        tempListContent += "students name: " + rs.name + ", students lastname: " + rs.lastname;
                    }
                    MessageBox.Show("\n" + tempListContent, "DEBUG : rawStudents list");
                }
            }
        }

        #region ToolTip metods

        ToolTip originFilePathToolTip;


        private void tb_filePath_MouseEnter(object sender, EventArgs e)
        {
            originFilePathToolTip = new ToolTip();
            originFilePathToolTip.IsBalloon = true;
            originFilePathToolTip.Show("Dvojklik pro otevření dialogu na výběr zdroového souboru", (TextBox)sender, 20, -35, 10000);
        }

        private void tb_filePath_MouseLeave(object sender, EventArgs e)
        {
            originFilePathToolTip.Dispose();
        }

        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateFormatedData();
        }

    }
}
