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
        }

        private string tempListContent = string.Empty;
        private string filePath = string.Empty;

        private static List<FormatedStudent> formatedStudents = new List<FormatedStudent>();
        private List<Label> nameLabelsRef = new List<Label>();
        private List<Label> timeLabelsRef = new List<Label>();
        private List<Button> continueButtonRef = new List<Button>();
        private List<Button> pauseButtonRef = new List<Button>();

        private TimeManager tm;

        #region Other methods
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
        
        #endregion

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
                        formatedStudents.Add(new FormatedStudent(data[0], data[1], int.Parse(data[2])));
                    }
                    tm = new TimeManager(formatedStudents);
                    (sender as Button).Enabled = false;


                    if (G.I.debugMod)
                    {
                        foreach (var item in formatedStudents)
                        {
                           // tempListContent += "||| Student name: " + item.name + " student lastname: " + item.lastname + " student exam-span: " + item.examDuration + " |||";
                        }
                        //G.I.dof.WriteInfo("Načtená formátovaná data\n" + tempListContent);
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
                    catch
                    {
                        G.I.dof.WriteWarning("Načtená data neprošla skrze úvodní filtr");
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
                if (G.I.debugMod)
                    l.BackColor = Color.Gray;
                l.Text = formatedStudents[i].name + "  " + formatedStudents[i].lastname;
                l.Name = i.ToString();
                Controls.Add(l);
                nameLabelsRef.Add(l);
                initialDynTop += l.Height + 7;
            }
            initialDynTop = initialTop;
            G.I.dof.WriteInfo("byly vygenerovány labely se jmény účastníků");
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
                l.Width = 200;
                if (G.I.debugMod)
                    l.BackColor = Color.LightGray;
                l.Text = tm.times[i].GetFormatedTime();

                //l.Name = Global.I.numberToWordLabel[i];
                l.Name = i.ToString();

                timeLabelsRef.Add(l);
                initialDynTop += l.Height + 7;
            }
            initialDynTop = initialTop;
            foreach (var l in timeLabelsRef)
            {
                Controls.Add(l);
            }
            G.I.dof.WriteInfo("byly vygenerovány labely s časy účastníků");
        }

        private void GenerateButtons()
        {
            //start buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = initialLeft + 760;
                b.Top = initialDynTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 38;
                b.Width = 175;
                b.Text = "Pokračovat";
                b.TextAlign = ContentAlignment.TopCenter;
                b.FlatStyle = FlatStyle.Flat;
                b.Click += new EventHandler(dynBt_continue);

                //b.Name = Global.I.numberToWordContinue[i];
                b.Name = i.ToString();

                continueButtonRef.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in continueButtonRef)
            {
                Controls.Add(b);
            }
            initialDynTop = initialTop;
            G.I.dof.WriteInfo("byly vygenerovány tlačítka pro pokračování");

            //stop buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = initialLeft + 570;
                b.Top = initialDynTop;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 38;
                b.Width = 125;
                b.Text = "Pauza";
                b.TextAlign = ContentAlignment.TopCenter;
                b.FlatStyle = FlatStyle.Flat;
                b.Click += new EventHandler(dynBt_pause);
                //b.Name = Global.I.numberToWordPause[i];
                b.Name = i.ToString();

                pauseButtonRef.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in pauseButtonRef)
            {
                Controls.Add(b);
            }
            initialDynTop = 300;
            G.I.dof.WriteInfo("byly vygenerovány tlačítka pro pozastavení");

        }

        #endregion

        #region event handlers

        private void bt_loadFile_Click(object sender, EventArgs e)
        {
            if (LoadAndCheckInput())
            {
                LoadFormatedData(sender);
                bt_start.Enabled = true;
                bt_stop.Enabled = true;
                bt_reset.Enabled = true;
            }
            else
            {

            }
        }

        private void tmr_seconds_Tick(object sender, EventArgs e)
        {
            tm.CountDown();
            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                timeLabelsRef[i].Text = tm.times[i].GetFormatedTime();
                if(tm.times[i].GetFormatedTime() == "00:00")
                {
                    timeLabelsRef[i].ForeColor = Color.Red;
                    nameLabelsRef[i].ForeColor = Color.Red;

                    continueButtonRef[i].ForeColor = Color.Red;
                    continueButtonRef[i].Enabled = false;

                    pauseButtonRef[i].ForeColor = Color.Red;
                    pauseButtonRef[i].Enabled = false;
                    
                    tm.KillTimer(i);
                    tm.PauseTimer(i);
                }

            }
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            tmr_seconds.Start();
            G.I.dof.WriteInfo("Časovač zpuštěn");
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            tmr_seconds.Stop();
            G.I.dof.WriteInfo("Časovač zastaven");
        }

        private void bt_reset_Click(object sender, EventArgs e)
        {
            tm.ResetAll();
            tm.RestoreAll();

            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                timeLabelsRef[i].Text = tm.times[i].GetFormatedTime();
                continueButtonRef[i].BackColor = SystemColors.Control;
                continueButtonRef[i].ForeColor = Color.Black;
                pauseButtonRef[i].BackColor = SystemColors.Control;
                pauseButtonRef[i].ForeColor = Color.Black;
            }

            G.I.dof.WriteInfo("Byl proveden reset a obnovení původníh hodnot");
        }

        private void dynBt_continue(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            string searchedlabelsName;
            //searchedlabelsName = Global.I.numberToWordLabel[Global.I.wordToNumberContinue[bt.Name]];
            searchedlabelsName = bt.Name;

            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                if (timeLabelsRef[i].Name == searchedlabelsName)
                    tm.RestoreTimer(i);
                if (pauseButtonRef[i].Name == bt.Name)
                {
                    pauseButtonRef[i].BackColor = SystemColors.Control;
                    pauseButtonRef[i].ForeColor = Color.Black;
                    G.I.dof.WriteInfo("Bylo obnoveno odčítaní u účastníka s číslem #" + i);
                }
            }
            bt.BackColor = SystemColors.Control;
            bt.ForeColor = Color.Black;
        }
        private void dynBt_pause(object sender, EventArgs e)
        {

            Button bt = (Button)sender;
            string searchedlabelsName;

            //searchedlabelsName= Global.I.numberToWordLabel[Global.I.wordToNumberPause[bt.Name]];
            searchedlabelsName = bt.Name;

            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                if (timeLabelsRef[i].Name == searchedlabelsName)
                    tm.PauseTimer(i);
                if (continueButtonRef[i].Name == bt.Name)
                    if (G.I.defaultHlm)
                    {
                        continueButtonRef[i].BackColor = Color.Green;
                        G.I.dof.WriteInfo("Bylo pozastaveno odčítaní u účastníka s číslem #" + i);
                    }
                    else
                    {
                        continueButtonRef[i].BackColor = Color.Black;
                        continueButtonRef[i].ForeColor = Color.White;
                    }

            }
            if (G.I.defaultHlm) bt.BackColor = Color.Red;
            else
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void lb_about_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
            G.I.dof.WriteInfo("Okno 'O aplikaci' bylo otevřeno z " + this.Text);
        }
        
        private void Presenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            G.I.entry.WindowState = FormWindowState.Normal;
            G.I.dof.WriteInfo("Okno " + this.Text + " bylo zavřeno");

            formatedStudents.Clear();
            nameLabelsRef.Clear();
            timeLabelsRef.Clear();
            continueButtonRef.Clear();
            pauseButtonRef.Clear();

            G.I.dof.WriteInfo("Všechna pole referencí vymazána");
        }

        private void lb_end_Click(object sender, EventArgs e)
        {
            Label l = (sender as Label);
            l.Visible = false;
            l.Enabled = false;
            G.I.dof.WriteInfo("Label " + l.Name + "byl skryt");
        }
        #endregion


    }
}
