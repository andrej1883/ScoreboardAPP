using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class ControlForm : Form
    {

        private ScoreboardForm formScoreBoard;
        private bool blackActive = false;
        private Form blacForm = null;
        private bool fOpen = false;
        private int penaltyCount = 4;
        private Color[] colors =
        {
            Color.Red,
            Color.Orange,
            Color.Yellow,
            Color.Chartreuse,
            Color.Green,
            Color.SpringGreen,
            Color.Cyan,
            Color.Azure,
            Color.Blue, 
            Color.Violet,
            Color.Magenta,
            Color.MistyRose,
            Color.Black,
            Color.White
        };

        public ControlForm()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            formScoreBoard = ScoreboardForm.GetInstance();

            if (!formScoreBoard.GetActive())
            {
                formScoreBoard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                formScoreBoard.MinimizeBox = false;
                formScoreBoard.MaximizeBox = false;
                formScoreBoard.ControlBox = false;
                formScoreBoard.SetSize(Decimal.ToInt32(scoreBWidth.Value), Decimal.ToInt32(scoreBHeight.Value));
                var area = Screen.AllScreens[0].Bounds;
                var location = area.Location;
                location.Offset((area.Width - formScoreBoard.Width) / 2, (area.Height - formScoreBoard.Height) / 2);
                formScoreBoard.Location = location;
                formScoreBoard.Show();
                formScoreBoard.SetActive(true);
            }
            else if (!formScoreBoard.IsDisposed)
            {
                formScoreBoard.SetSize(Decimal.ToInt32(scoreBWidth.Value), Decimal.ToInt32(scoreBHeight.Value));
                var area = Screen.AllScreens[0].Bounds;
                var location = area.Location;
                location.Offset((area.Width - formScoreBoard.Width) / 2, (area.Height - formScoreBoard.Height) / 2);
                formScoreBoard.Location = location;
                formScoreBoard.BringToFront();
            }

            foreach (Color color in colors)
            {
                backgrClr.Items.Add(color);
                scoreLC.Items.Add(color);
                scoreSC.Items.Add(color);
                timeLC.Items.Add(color);
                timeCC.Items.Add(color);
                periodLC.Items.Add(color);
                periodPC.Items.Add(color);
                penaltyLC.Items.Add(color);
                penaltyPDC.Items.Add(color);
            }

            backgrClr.Items.Add(DefaultBackColor);
            InitDropdowns();

            for (int i = 1; i <= penaltyCount; i++)
            {
                formScoreBoard.HidePenalty(i);
            }
            GameForm game = new GameForm(formScoreBoard);
            game.Show();
        }

        private void InitDropdowns()
        {
            backgrClr.Text = formScoreBoard.BackgrColor.Name;
            scoreLC.Text = formScoreBoard.ScoLColor.Name;
            scoreSC.Text = formScoreBoard.ScoSColor.Name;
            timeLC.Text = formScoreBoard.TimeLColor.Name;
            timeCC.Text = formScoreBoard.TimeCColor.Name;
            periodLC.Text = formScoreBoard.PeriodLColor.Name;
            periodPC.Text = formScoreBoard.PeriodColor.Name;
            penaltyLC.Text = formScoreBoard.PenaltyLColor.Name;
            penaltyPDC.Text = formScoreBoard.PenaltyDColor.Name;

            scoreLblSize.Value = (int)formScoreBoard.ScoLSize;
            timeLblSize.Value = (int) formScoreBoard.TimeLSize;
            periodLblSize.Value = (int) formScoreBoard.PeriodLSize;
            penaltyLblSize.Value = (int) formScoreBoard.PenaltyLSize;
            scoreSize.Value = (int) formScoreBoard.ScoSSize;
            clockSize.Value = (int) formScoreBoard.TimeCSize;
            periodSize.Value = (int) formScoreBoard.PeriodPSize;
            penaltyDataSize.Value = (int) formScoreBoard.PenaltyDSize;
            scoreBWidth.Value = (int) formScoreBoard.Width;
            scoreBHeight.Value = (int) formScoreBoard.Height;
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (!fOpen)
            {
                scoreBWidth.Value = formScoreBoard.Width;
                fOpen = true;
            }

            
            formScoreBoard.Width = Decimal.ToInt32(scoreBWidth.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (!fOpen)
            {
                scoreBHeight.Value = formScoreBoard.Height;
                fOpen = true;
            }
            
            formScoreBoard.Height = Decimal.ToInt32(scoreBHeight.Value);
        }

        private void blackBcgrBtn_Click(object sender, EventArgs e)
        {
            if (!blackActive)
            {
                blacForm = new Form();
                blacForm.MinimizeBox = false;
                blacForm.MaximizeBox = false;
                blacForm.ControlBox = false;
                blacForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Text = String.Empty;
                blacForm.Size = Size;
                blacForm.BackColor = Color.Black;
                Screen[] screens = Screen.AllScreens;
                Rectangle bounds = screens[1].Bounds;
                blacForm.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                blacForm.StartPosition = FormStartPosition.Manual;
                blacForm.Show();
                blackActive = true;
            }
            else
            {
                blacForm.Dispose();
                blackActive = false;
            }

        }

        private void closeScoreboardBtn_Click(object sender, EventArgs e)
        {
            if (formScoreBoard != null)
            {
                formScoreBoard.Dispose();
                formScoreBoard.ResetInstance();
                formScoreBoard.SetActive(false);
                fOpen = false;
                importPath.Clear();
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            if (formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                location.Offset((area.Width - formScoreBoard.Width) / 2, (area.Height - formScoreBoard.Height) / 2);
                formScoreBoard.Location = location;
            }
        }

        private void kv1Btn_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            if (formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                location.Offset((area.Width - formScoreBoard.Width), (0));
                formScoreBoard.Location = location;
            }

        }

        private void kv2Btn_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            if (formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                location.Offset((0), (0));
                formScoreBoard.Location = location;
            }
        }

        private void kv3Btn_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            if (formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                location.Offset((0), (area.Height - formScoreBoard.Height));
                formScoreBoard.Location = location;
            }
        }

        private void kv4Btn_Click(object sender, EventArgs e)
        {
            Screen[] screens = Screen.AllScreens;
            if (formScoreBoard != null)
            {
                var area = Screen.AllScreens[1].Bounds;
                var location = area.Location;

                location.Offset((area.Width - formScoreBoard.Width), (area.Height - formScoreBoard.Height));
                formScoreBoard.Location = location;
            }
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {

        }

        private void backgrClr_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.BackgrColor = (Color)backgrClr.SelectedItem;
        }

        private void scoreLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.ScoLColor = (Color) scoreLC.SelectedItem;
        }

        private void periodPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.PeriodColor = (Color)periodPC.SelectedItem;
        }

        private void periodLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.PeriodLColor = (Color)periodLC.SelectedItem;
        }

        private void scoreSC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.ScoSColor = (Color)scoreSC.SelectedItem;
        }

        private void timeLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.TimeLColor = (Color)timeLC.SelectedItem;
        }

        private void timeCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.TimeCColor = (Color)timeCC.SelectedItem;
        }

        private void penaltyLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.PenaltyLColor = (Color)penaltyLC.SelectedItem;
        }

        private void penaltyPDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            formScoreBoard.PenaltyDColor = (Color)penaltyPDC.SelectedItem;
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.ScoLSize = (int) scoreLblSize.Value;
        }

        private void timeLblSize_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.TimeLSize = (int) timeLblSize.Value;
        }

        private void periodLblSize_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.PeriodLSize = (int) periodLblSize.Value;
        }

        private void penaltyLblSize_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.PenaltyLSize = (int) penaltyLblSize.Value;
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.ScoSSize = (int) scoreSize.Value;
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.PeriodPSize = (int) periodSize.Value;
        }

        private void clockSize_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.TimeCSize = (int) clockSize.Value;
        }

        private void penaltyDataSize_ValueChanged(object sender, EventArgs e)
        {
            formScoreBoard.PenaltyDSize = (int) penaltyDataSize.Value;
        }

        private void importSettings_Click(object sender, EventArgs e)
        {
            string[] settings;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Text files(*.txt)|*.txt";
            if (open.ShowDialog() == DialogResult.OK) 
            {
                importPath.Text = open.FileName;
                StreamReader reader = File.OpenText( importPath.Text);
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    settings = line.Split(',');
                    formScoreBoard.BackgrColor = Color.FromName(settings[0]);
                    formScoreBoard.PenaltyDColor = Color.FromName(settings[1]);
                    formScoreBoard.PenaltyLColor = Color.FromName(settings[2]);
                    formScoreBoard.PeriodColor = Color.FromName(settings[3]);
                    formScoreBoard.PeriodLColor = Color.FromName(settings[4]);
                    formScoreBoard.TimeLColor = Color.FromName(settings[5]);
                    formScoreBoard.ScoLColor = Color.FromName(settings[6]);
                    formScoreBoard.ScoSColor = Color.FromName(settings[7]);
                    formScoreBoard.TimeCColor = Color.FromName(settings[8]);
                    formScoreBoard.PenaltyDSize = Int32.Parse(settings[9]);
                    formScoreBoard.PenaltyLSize = Int32.Parse(settings[10]);
                    formScoreBoard.PeriodLSize = Int32.Parse(settings[11]);
                    formScoreBoard.PeriodPSize = Int32.Parse(settings[12]);
                    formScoreBoard.TimeLSize = Int32.Parse(settings[13]);
                    formScoreBoard.ScoLSize = Int32.Parse(settings[14]);
                    formScoreBoard.ScoSSize = Int32.Parse(settings[15]);
                    formScoreBoard.TimeCSize = Int32.Parse(settings[16]);
                    formScoreBoard.Width = Int32.Parse(settings[17]);
                    formScoreBoard.Height = Int32.Parse(settings[18]);
                    InitDropdowns();
                }
            }
        }

        private void exportSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
 
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2 ;
            saveFileDialog1.RestoreDirectory = true ;
 
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string text = formScoreBoard.ToString();
                File.WriteAllText(saveFileDialog1.FileName, text);
            }
        }

        private void scoreBoardSettingsBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
