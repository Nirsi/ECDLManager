using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECDLManager
{
    public partial class Presenter : Form
    {
        public Presenter()
        {
            InitializeComponent();
            if (Global.I.debugMod)
                Text = "ECDL Test - DEBUG";
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
            if(LoadAndCheckInput())
                LoadFormatedData(sender);
            else if (!Global.I.debugMod)
                MessageBox.Show("Soubor, který jste zvolili jako vstupní má nesprávný formát nebo je jinak poškozen", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                else
                    return "#null";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return string.Empty;
            }
        }

        #region IO operations

        private void LoadFormatedData(object sender)
        {

            //filePath = getFilePath();

            if (!(filePath == "#null"))
            {
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
            else
            {
                MessageBox.Show("Nebyl vybrán žádný vstupní soubor!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool LoadAndCheckInput()
        {
            filePath = getFilePath();

            if (!(filePath == "#null"))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    try
                    {
                        //modul,date,time of beginning,exam duration
                        string[] data = sr.ReadLine().Split(';');

                        lb_modul.Text = "Modul: " + data[0];
                        lb_date.Text = "Datum: " + data[1];
                        lb_examBeginning.Text = "Čas zahájení: " + data[2];
                        lb_examDuration.Text = "Trvání testu: " + data[3] + " minut";

                        lb_modul.Text = "Modul: ";
                        lb_date.Text = "Datum: ";
                        lb_examBeginning.Text = "Čas zahájení: ";
                        lb_examDuration.Text = "Trvání testu: ";

                        data = sr.ReadLine().Split(';');
                        FormatedStudent[] fs = new FormatedStudent[1];
                        fs[0] = new FormatedStudent(data[0], data[1], int.Parse(data[2]));

                        return true;
                    }
                    catch (Exception ex)
                    {
                        if (Global.I.debugMod)
                            MessageBox.Show(ex.ToString(), "Debug output", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
            else
                return true;
        }

        #endregion
        
        #region Generators
        int initialLeft = 100;
        int initialTop = 200;

        int initialDynTop = 200;
        

        private void GenerateNamesOfStudents()
        {
            for (int i = 0; i < formatedStudents.Count; i++)
            {
                Label l = new Label();
                l.Left = initialLeft;
                l.Top = initialDynTop;
                l.Font = new Font("Consolas", 20.0f, FontStyle.Regular);
                l.Height = 35;
                l.Width = 300;
                l.Text = formatedStudents[i].name + "  " + formatedStudents[i].lastname;
                Controls.Add(l);
                initialDynTop += l.Height + 4;
            }
            initialDynTop = initialTop;
        }

        private void GenerateTimeOfStudents()
        {
            for (int i = 0; i < tm.times.Count; i++)
            {
                Label l = new Label();
                l.Left = initialLeft + 325;
                l.Top = initialDynTop;
                l.Font = new Font("Consolas", 20.0f, FontStyle.Regular);
                l.Height = 35;
                l.Width = 100;
                l.Text = tm.times[i].GetFormatedTime();
                l.Name = Global.I.numberToWordLabel[i];
                timeLabelsRefences.Add(l);
                initialDynTop += l.Height + 4;
            }
            initialDynTop = initialTop;
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
                b.Top = initialDynTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 35;
                b.Width = 175;
                b.Text = "Pokračovat";
                b.Click += new EventHandler(dynBt_continue);
                b.Name = Global.I.numberToWordContinue[i];
                continueButtonReferences.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in continueButtonReferences)
            {
                Controls.Add(b);
            }
            initialDynTop = initialTop;


            //stop buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = initialLeft + 800;
                b.Top = initialDynTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 35;
                b.Width = 125;
                b.Text = "Pauza";
                b.Click += new EventHandler(dynBt_pause);
                b.Name = Global.I.numberToWordPause[i];
                pauseButtonReferences.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in pauseButtonReferences)
            {
                Controls.Add(b);
            }
            initialDynTop = 300;
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
            Button bt = (Button)sender;
            string searchedlabelsName = Global.I.numberToWordLabel[Global.I.wordToNumberContinue[bt.Name]];

            for (int i = 0; i < timeLabelsRefences.Count; i++)
            {
                if (timeLabelsRefences[i].Name == searchedlabelsName)
                    tm.RestoreTimer(i);
            }
          
        }
        private void dynBt_pause(object sender, EventArgs e)
        {

            Button bt = (Button)sender;
            string searchedlabelsName = Global.I.numberToWordLabel[Global.I.wordToNumberPause[bt.Name]];

            for (int i = 0; i < timeLabelsRefences.Count; i++)
            {
                if(timeLabelsRefences[i].Name == searchedlabelsName)
                    tm.PauseTimer(i);
            }
        }

        private void lb_about_Click(object sender, EventArgs e)
        {
            Form about = new AboutInfo();
            about.Show();
        }
        #endregion

       
    }
}
