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
            Icon = new Icon("ecdl_ico.ico");
        }

        private string tempListContent = string.Empty;
        private string filePath = string.Empty;
        private int XOffset = G.I.PresenterContentBlockXOffset, YOffset = G.I.PresenterContentBlockYOffset;

        private static List<FormatedStudent> formatedStudents = new List<FormatedStudent>();

        private List<Label> moduleLabelsRef = new List<Label>();
        private List<Label> nameLabelsRef = new List<Label>();
        private List<Label> timeLabelsRef = new List<Label>();
        
        private List<Button> continueButtonRef = new List<Button>();
        private List<Button> pauseButtonRef = new List<Button>();
        private List<Button> endButtonRef = new List<Button>();

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

        private void killLine(int index, string status)
        {
            moduleLabelsRef[index].ForeColor = Color.Red;
            timeLabelsRef[index].ForeColor = Color.Red;
            nameLabelsRef[index].ForeColor = Color.Red;

            continueButtonRef[index].ForeColor = Color.Red;
            continueButtonRef[index].Enabled = false;

            pauseButtonRef[index].ForeColor = Color.Red;
            pauseButtonRef[index].Enabled = false;

            endButtonRef[index].ForeColor = Color.Red;
            endButtonRef[index].Enabled = false;

            tm.PauseTimer(index);
            tm.KillTimer(index, status);
        }

        #endregion

        #region IO operations

        private void LoadFormatedData(object sender)
        {

            if (!(filePath == "#null"))
            {
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    string line;
                    line = sr.ReadLine();
                    //,date,time of beginning,exam duration
                    string[] _data = line.Split(';');

                    lb_date.Text = "Datum: " + _data[0];
                    lb_examBeginning.Text = "Čas zahájení: " + _data[1];
                    lb_examDuration.Text = "Trvání testu: " + _data[2] + " minut";



                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(';');
                        //G.I.dof.WriteNormal(string.Format("Jméno: {0}, Přímení: {1}, Trvání: {2}, Modul: {3}",data[0], data[1], data[2], data[3]));
                        formatedStudents.Add(new FormatedStudent(data[0], data[1], int.Parse(data[2]), data[3]));
                    }

                    tm = new TimeManager(formatedStudents);
                    (sender as Button).Enabled = false;

                    GenerateModulesOfStudens();
                    GenerateNamesOfStudents();
                    GenerateTimeOfStudents();
                    GenerateButtons();

                } 
            }
            else
            {
                MessageBox.Show("Nebyl vybrán žádný vstupní soubor!", "Upozornění", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                G.I.Dof.WriteWarning("Nebyl vybrán žádný soubor pro vstup");
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

                        lb_date.Text = "Datum: " + data[0];
                        lb_examBeginning.Text = "Čas zahájení: " + data[1];
                        lb_examDuration.Text = "Trvání testu: " + data[2] + " minut";

                        lb_date.Text = "Datum: ";
                        lb_examBeginning.Text = "Čas zahájení: ";
                        lb_examDuration.Text = "Trvání testu: ";

                        data = sr.ReadLine().Split(';');
                        FormatedStudent[] fs = new FormatedStudent[1];
                        fs[0] = new FormatedStudent(data[0], data[1], int.Parse(data[2]), data[3]);

                        return true;
                    }
                    catch
                    {
                        G.I.Dof.WriteError("Načtená data neprošla skrze úvodní filtr");
                        return false;
                    }
                }
            }
            else
                return false;
        }

        #endregion
        
        #region Generators
        int initialLeft = 100;
        int initialTop = 200;

        int initialDynTop = 200;

        private void GenerateModulesOfStudens()
        {
            for (int i = 0; i < formatedStudents.Count; i++)
            {
                Label l = new Label();
                l.Left = (initialLeft - 60) + XOffset;
                l.Top = initialDynTop + YOffset;
                l.Font = new Font("Consolas", 20.0f, FontStyle.Regular);
                l.Height = 35;
                l.Width = 60;
                if (G.I.debugMod)
                    l.BackColor = Color.LightBlue;
                l.Text = formatedStudents[i].module;
                l.Name = i.ToString();
                moduleLabelsRef.Add(l);
                Controls.Add(l);
                initialDynTop += l.Height + 7;
            }
            initialDynTop = initialTop;
            G.I.Dof.WriteInfo("byly vygenerovány labely s moduly účastníků");

        }

        private void GenerateNamesOfStudents()
        {
            for (int i = 0; i < formatedStudents.Count; i++)
            {
                Label l = new Label();
                l.Left = initialLeft + XOffset;
                l.Top = initialDynTop + YOffset;
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
            G.I.Dof.WriteInfo("byly vygenerovány labely se jmény účastníků");
        }

        private void GenerateTimeOfStudents()
        {
            for (int i = 0; i < tm.times.Count; i++)
            {
                Label l = new Label();
                l.Left = (initialLeft + 325) + XOffset;
                l.Top = initialDynTop + YOffset;
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
            G.I.Dof.WriteInfo("byly vygenerovány labely s časy účastníků");
        }

        private void GenerateButtons()
        {
            //Continue buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = (initialLeft + 690) + XOffset;
                b.Top = initialDynTop + YOffset;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 38;
                b.Width = 175;
                b.Text = "Pokračovat";
                b.TextAlign = ContentAlignment.TopCenter;
                b.FlatStyle = FlatStyle.Flat;
                b.Click += new EventHandler(dynBt_continue);
                b.Name = i.ToString();

                continueButtonRef.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in continueButtonRef)
            {
                Controls.Add(b);
            }
            initialDynTop = initialTop;
            G.I.Dof.WriteInfo("byly vygenerovány tlačítka pro pokračování");

            //Pause buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = (initialLeft + 530) + XOffset;
                b.Top = initialDynTop + YOffset;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 38;
                b.Width = 125;
                b.Text = "Pauza";
                b.TextAlign = ContentAlignment.TopCenter;
                b.FlatStyle = FlatStyle.Flat;
                b.Click += new EventHandler(dynBt_pause);
                b.Name = i.ToString();
                pauseButtonRef.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in pauseButtonRef)
            {
                Controls.Add(b);
            }
            initialDynTop = initialTop;
            G.I.Dof.WriteInfo("byly vygenerovány tlačítka pro pozastavení");

            //End buttons
            for (int i = 0; i < tm.times.Count; i++)
            {

                Button b = new Button();
                b.Left = (initialLeft + 900) + XOffset;
                b.Top = initialDynTop + YOffset;
                b.Font = new Font("Consolas", 21.0f, FontStyle.Regular);
                b.Height = 38;
                b.Width = 150;
                b.Text = "Ukončit";
                b.TextAlign = ContentAlignment.TopCenter;
                b.FlatStyle = FlatStyle.Flat;
                b.Click += new EventHandler(dynBt_end);
                b.Name = i.ToString();

                endButtonRef.Add(b);
                initialDynTop += b.Height + 4;
            }
            foreach (var b in endButtonRef)
            {
                Controls.Add(b);
            }
            initialDynTop = initialTop;
            G.I.Dof.WriteInfo("byly vygenerovány tlačítka pro pozastavení");

        }

        #endregion

        #region event handlers

        //Timer event hhandler
        private void tmr_seconds_Tick(object sender, EventArgs e)
        {
            tm.CountDown();
            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                timeLabelsRef[i].Text = tm.times[i].GetFormatedTime();
                if(tm.times[i].GetFormatedTime() == "00:00")
                {
                    killLine(i, "Čas vypršel");
                }

            }
        }

        //Butonts event handlers
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

        private void bt_start_Click(object sender, EventArgs e)
        {
            tmr_seconds.Start();
            G.I.Dof.WriteInfo("Časovač spuštěn");
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            tmr_seconds.Stop();
            G.I.Dof.WriteInfo("Časovač zastaven");
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

            G.I.Dof.WriteInfo("Byl proveden reset a obnovení do původníh hodnot");
        }
        
        //Labels click event handlers
        private void lb_about_Click(object sender, EventArgs e)
        {
            Form about = new About();
            about.Show();
            G.I.Dof.WriteInfo("Okno 'O aplikaci' bylo otevřeno z " + this.Text);
        }

        private void lb_end_Click(object sender, EventArgs e)
        {
            Label l = (sender as Label);
            l.Visible = false;
            l.Enabled = false;
            G.I.Dof.WriteInfo("Label " + l.Name + "byl skryt");
        }

        //Dynamic buttons event handler
        private void dynBt_continue(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                if (timeLabelsRef[i].Name == bt.Name)
                    tm.RestoreTimer(i);
                if (pauseButtonRef[i].Name == bt.Name)
                {
                    pauseButtonRef[i].BackColor = SystemColors.Control;
                    pauseButtonRef[i].ForeColor = Color.Black;
                    G.I.Dof.WriteInfo("Bylo obnoveno odčítaní u účastníka s číslem #" + i);
                }
            }
            bt.BackColor = SystemColors.Control;
            bt.ForeColor = Color.Black;
        }

        private void dynBt_pause(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                if (timeLabelsRef[i].Name == bt.Name)
                    tm.PauseTimer(i);
                if (continueButtonRef[i].Name == bt.Name)
                    if (G.I.defaultHlm)
                    {
                        continueButtonRef[i].BackColor = Color.Green;
                        G.I.Dof.WriteInfo("Bylo pozastaveno odčítaní u účastníka s číslem #" + i);
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

        private void dynBt_end(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            
            for (int i = 0; i < timeLabelsRef.Count; i++)
            {
                if (timeLabelsRef[i].Name == bt.Name)
                {
                    killLine(i, "Test ukončen");

                    pauseButtonRef[i].BackColor = SystemColors.Control;
                    pauseButtonRef[i].ForeColor = Color.Black;

                    continueButtonRef[i].BackColor = SystemColors.Control;
                    continueButtonRef[i].ForeColor = Color.Black;
                }
            }
        }

        //This form close event handler
        private void Presenter_FormClosed(object sender, FormClosedEventArgs e)
        {
            G.I.entry.WindowState = FormWindowState.Normal;
            G.I.Dof.WriteInfo("Okno " + Text + " bylo zavřeno");

            formatedStudents.Clear();
            nameLabelsRef.Clear();
            timeLabelsRef.Clear();
            continueButtonRef.Clear();
            pauseButtonRef.Clear();

            G.I.Dof.WriteInfo("Všechna pole referencí vymazána");
        }
        #endregion


    }
}
