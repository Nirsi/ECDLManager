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
    public partial class Prezenter : Form
    {
        public Prezenter()
        {
            InitializeComponent();
            if (Global.I.debugMod)
                Text = "SPS Debug - ECDL : Prezentér";
        }

        private string tempListContent = string.Empty;
        private string filePath = string.Empty;

        private static List<FormatedStudent> formatedStudents = new List<FormatedStudent>();
        private List<Label> timeLabelsRefences = new List<Label>();
        private List<Button> continueButtonReferences = new List<Button>();
        private List<Button> pauseButtonReferences = new List<Button>();

        private TimeManager tm;

        
        private void bt_loadFile_Click(object sender, EventArgs e)
        {
            filePath = getFilePath();

            //Error : if file selector is closed exceptio <Prázdná cesta není platná> will be throwed;
            using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
            {
                string line;
                line = sr.ReadLine();
                //modul,date,time of beginning,exam duration
                string[] _data = line.Split(';');

                lb_modul.Text = "Modul: " + _data[0];
                lb_date.Text = "Datum: " + _data[1];
                lb_examBeginning.Text = "Čas zahájení: " + _data[2];
                lb_examDuration.Text = "Trvání testu: " + _data[3] + " minut";



                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(';');
                    //rawStudents.Add(new rawStudent(data[0], data[1]));
                    formatedStudents.Add(new FormatedStudent(data[0], data[1], int.Parse(data[2])));
                }
                tm = new TimeManager(formatedStudents);
                (sender as Button).Enabled = false;
                //(sender as Button).Visible = false;

                if (Global.I.debugMod)
                {
                    foreach (var item in formatedStudents)
                    {
                        tempListContent += "||| Student name: " + item.name + " student lastname: " + item.lastname + " student exam-span: " + item.examDuration + " |||";
                    }
                    MessageBox.Show(tempListContent, "|DEBUG| : formated students");
                }

                GenerateNamesOfStudents();
                GenerateTimeOfStudents();
                GenerateButtons();

            }
        }

        private string getFilePath()
        {
            try
            {
                DialogResult result = ofd_inputFile.ShowDialog();
                if (result == DialogResult.OK)
                {
                    return ofd_inputFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }
            return string.Empty;
        }
        
        #region Generators

        int initialTop = 300;
        int initialLeft = 100;

        private void GenerateNamesOfStudents()
        {
            for (int i = 0; i < formatedStudents.Count; i++)
            {
                Label l = new Label();
                l.Left = initialLeft;
                l.Top = initialTop;
                l.Font = new Font("Consolas", 20.0f, FontStyle.Regular);
                l.Height = 35;
                l.Width = 300;
                l.Text = formatedStudents[i].name + "  " + formatedStudents[i].lastname;
                Controls.Add(l);
                initialTop += l.Height + 4;
            }
            initialTop = 300;
        }

        private void GenerateTimeOfStudents()
        {
            for (int i = 0; i < tm.times.Count; i++)
            {
                Label l = new Label();
                l.Left = initialLeft + 325;
                l.Top = initialTop;
                l.Font = new Font("Consolas", 20.0f, FontStyle.Regular);
                l.Height = 35;
                l.Width = 80;
                l.Text = tm.times[i].GetFormatedTime();
                timeLabelsRefences.Add(l);
                initialTop += l.Height + 4;
            }
            initialTop = 300;
            foreach (var l in timeLabelsRefences)
            {
                Controls.Add(l);
            }
        }

        private void GenerateButtons()
        {
            //start buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = initialLeft + 570;
                b.Top = initialTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 35;
                b.Width = 175;
                b.Text = "Pokračovat";
                b.Click += new EventHandler(dynBt_continue);
                b.Name = Global.I.numberToWordContinue[i];
                continueButtonReferences.Add(b);
                initialTop += b.Height + 4;
            }
            foreach (var b in continueButtonReferences)
            {
                Controls.Add(b);
            }
            initialTop = 300;


            //stop buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = initialLeft + 800;
                b.Top = initialTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 35;
                b.Width = 125;
                b.Text = "Pauza";
                b.Click += new EventHandler(dynBt_pause);
                b.Name = Global.I.numberToWordPause[i];
                pauseButtonReferences.Add(b);
                initialTop += b.Height + 4;
            }
            foreach (var b in pauseButtonReferences)
            {
                Controls.Add(b);
            }
            initialTop = 300;
        }

        #endregion

        #region event handlers

        private void tmr_seconds_Tick(object sender, EventArgs e)
        {
            tm.CountDown();
            for (int i = 0; i < timeLabelsRefences.Count; i++)
            {
                timeLabelsRefences[i].Text = tm.times[i].GetFormatedTime();
            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            tmr_seconds.Start();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            tmr_seconds.Stop();
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tm.ResetAllTimes();
        }

        private void dynBt_continue(object sender, EventArgs e)
        {
            MessageBox.Show("Continue button pressed");
        }
        private void dynBt_pause(object sender, EventArgs e)
        {
            MessageBox.Show("Pause button pressed");
        }

        #endregion
    }
}
