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

                (sender as Button).Enabled = false;
                bt_saveFormatedData.Enabled = true;
                lb_inputDataStatus.Text = "Vstuptní data NAČTENA";
                lb_inputDataStatus.ForeColor = Color.Green;


#if DEBUG
                //foreach (var rs in rawStudents)
                //{
                //    tempListContent += "students name: " + rs.name + ", students lastname: " + rs.lastname;
                //}

                //MessageBox.Show("\n" + tempListContent,"DEBUG : rawStudents list");
#endif
            }
        }

        private void GenerateAndSaveFormatedData()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            DialogResult result = fbd.ShowDialog();

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                MessageBox.Show(fbd.SelectedPath.ToString());


                //enforcement of ASCII text format
                using (StreamWriter sw = new StreamWriter(new FileStream(fbd.SelectedPath + @"\formatedList.csv", FileMode.Create, FileAccess.ReadWrite), Encoding.ASCII))
                {
                    //modul,date,time,test duration
                    sw.WriteLine(tb_modulName.Text + ";" + tb_date.Text + ";" + tb_time.Text + ";" + tb_testDuration.Text);
                    foreach (rawStudent rs in rawStudents)
                    {
                        //student's name, student's lastname, exam duration in minutes
                        sw.WriteLine(rs.name + ";" + rs.lastname + ";" + tb_testDuration.Text);
                    }
                }
            }
        }

        private void bt_saveFormatedData_Click(object sender, EventArgs e)
        {
            GenerateAndSaveFormatedData();
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
    }
}
