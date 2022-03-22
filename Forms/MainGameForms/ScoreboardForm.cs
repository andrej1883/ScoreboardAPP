using System;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Scoreboard.Classes;

namespace Scoreboard.Forms.MainGameForms
{
    public partial class ScoreboardForm : Form
    {
        public bool IsActive { get; set; }

        public Color ScoSColor
        {
            get => scoreT1Lbl.ForeColor;
            set {
                scoreT1Lbl.ForeColor = (Color)value;
                scoreParseLblb.ForeColor = (Color)value;
                scoreT2Lbl.ForeColor = (Color)value;
            }
        }

        public Color ScoLColor
        {
            get => t1Lbl.ForeColor;
            set {
                t1Lbl.ForeColor = (Color)value;
                t2Lbl.ForeColor = (Color)value;
            }

        }

        public Color TimeCColor
        {
            get => timeMinutesLbl.ForeColor;
            set {
                timeMinutesLbl.ForeColor = (Color)value;
                timeSecondsLbl.ForeColor = (Color)value;
                timeParseLbl.ForeColor = (Color)value;
            }
        }

        public Color TimeLColor
        {
            get => timeLbl.ForeColor;
            set => timeLbl.ForeColor = (Color)value;
        }

        public Color PeriodColor
        {
            get => actualPeriodLbl.ForeColor;
            set => actualPeriodLbl.ForeColor = (Color)value;
        }

        public Color PenaltyDColor
        {
            get => playerNumber1T1lbl.ForeColor;
            set {
                playerNumber1T1lbl.ForeColor = (Color)value;
                playerNumber1T2lbl.ForeColor = (Color)value;
                playerNumber2T1lbl.ForeColor = (Color)value;
                playerNumber2T2lbl.ForeColor = (Color)value;
                minutesT1P1Lbl.ForeColor = (Color)value;
                minutesT1P2Lbl.ForeColor = (Color)value;
                minutesT2P1Lbl.ForeColor = (Color)value;
                minutesT2P2Lbl.ForeColor = (Color)value;
                timeT1P1ParseLbl.ForeColor = (Color)value;
                timeT1P2ParseLbl.ForeColor = (Color)value;
                timeT2P1ParseLbl.ForeColor = (Color)value;
                timeT2P2ParseLbl.ForeColor = (Color)value;
                secondsT1P1Lbl.ForeColor = (Color)value;
                secondsT1P2Lbl.ForeColor = (Color)value;
                secondsT2P1Lbl.ForeColor = (Color)value;
                secondsT2P2Lbl.ForeColor = (Color)value;
            }
        }

        public Color PenaltyLColor
        {
            get => penaltyT1Lbl.ForeColor;
            set {
                penaltyT1Lbl.ForeColor = (Color)value;
                penaltyT2Lbl.ForeColor = (Color)value;
                penaltyT1PlayerLbl.ForeColor = (Color)value;
                penaltyT2PlayerLbl.ForeColor = (Color)value;
                penaltyT1TimeLbl.ForeColor = (Color)value;
                penaltyT2TimeLbl.ForeColor = (Color)value;
            }
        }

        public Color PeriodLColor
        {
            get =>  periodLbl.ForeColor;
            set => periodLbl.ForeColor = (Color)value;
        }

        public Color TimeoutLColor
        {
            get =>  timeoutL1.ForeColor;
            set {
                timeoutL1.ForeColor = (Color)value;
                timeoutL2.ForeColor = (Color)value;
            }
        }

        public Color TimeoutTColor
        {
            get =>  timeout1Min.ForeColor;
            set {
                timeout1Min.ForeColor = (Color)value;
                timeout1Sec.ForeColor = (Color)value;
                timeout2Min.ForeColor = (Color)value;
                timeout2Sec.ForeColor = (Color)value;
            }
        }

        public Color FaceOffLColor
        {
            get =>  faceOffsT1Lbl.ForeColor;
            set {
                faceOffsT1Lbl.ForeColor = (Color)value;
                faceOffsT2Lbl.ForeColor = (Color)value;
            }
        }

        public Color FaceOffFaceColor
        {
            get =>  faceOffsT1.ForeColor;
            set {
                faceOffsT1.ForeColor = (Color)value;
                faceOffsT2.ForeColor = (Color)value;
            }
        }

        public Color ShotsLColor
        {
            get =>  shotsT1Lbl.ForeColor;
            set {
                shotsT1Lbl.ForeColor = (Color)value;
                shotsT2Lbl.ForeColor = (Color)value;
            }
        }

        public Color ShotsSColor
        {
            get =>  shotsT1.ForeColor;
            set {
                shotsT1.ForeColor = (Color)value;
                shotsT2.ForeColor = (Color)value;
            }
        }

        public Color BackgrColor
        {
            get => BackColor;
            set
            {
                if (value != Color.Transparent) BackColor = value;
                foreach (Label lbl in _instance.Controls.OfType<Label>())
                {
                    lbl.BackColor = value;
                }
            }
    }

        public Font ScoSFont
        {
            get =>  scoreT1Lbl.Font;
            set
            {
                scoreT1Lbl.Font = value;
                scoreT2Lbl.Font = value;
                scoreParseLblb.Font = value;
            }
        }

        public Font ScoLFont
        {
            get => t1Lbl.Font;
            set {
                t1Lbl.Font = value;
                t2Lbl.Font = value;
            }
        }

        public Font TimeCFont
        {
            get => timeMinutesLbl.Font;
            set {
                timeMinutesLbl.Font = value;
                timeParseLbl.Font = value;
                timeSecondsLbl.Font = value;
            }
        }

        public Font TimeLFont
        {
            get => timeLbl.Font;
            set => timeLbl.Font = value;
        }

        public Font PeriodPFont
        {
            get => actualPeriodLbl.Font;
            set => actualPeriodLbl.Font = value;
        }

        public Font PeriodLFont
        {
            get => periodLbl.Font;
            set => periodLbl.Font = value;
        }

        public Font PenaltyDFont
        {
            get => playerNumber1T1lbl.Font;
            set {
                playerNumber1T1lbl.Font = value;
                playerNumber2T1lbl.Font = value;
                minutesT1P1Lbl.Font = value;
                timeT1P1ParseLbl.Font = value;
                secondsT1P1Lbl.Font = value;
                minutesT1P2Lbl.Font = value;
                timeT1P2ParseLbl.Font = value;
                secondsT1P2Lbl.Font = value;
                playerNumber1T2lbl.Font = value;
                playerNumber2T2lbl.Font = value;
                minutesT2P1Lbl.Font = value;
                timeT2P1ParseLbl.Font = value;
                secondsT2P1Lbl.Font = value;
                minutesT2P2Lbl.Font = value;
                timeT2P2ParseLbl.Font = value;
                secondsT2P2Lbl.Font = value;

            }
        }

        public Font PenaltyLFont
        {
            get =>  penaltyT1Lbl.Font;
            set {
                penaltyT1Lbl.Font = value;
                penaltyT2Lbl.Font = value;
                penaltyT1PlayerLbl.Font = value;
                penaltyT1TimeLbl.Font = value;
                penaltyT2PlayerLbl.Font = value;
                penaltyT2TimeLbl.Font = value;
            }
        }

        public Font TimeoutLFont
        {
            get =>  timeoutL1.Font;
            set {
                timeoutL1.Font = value;
                timeoutL2.Font = value;
            }
        }

        public Font TimeoutTFont
        {
            get =>  timeout1Min.Font;
            set {
                timeout1Min.Font = value;
                timeout2Min.Font = value;
                timeout1Sec.Font = value;
                timeout2Sec.Font = value;
                timeout1Parse.Font = value;
                timeout2Parse.Font = value;

            }
        }

        public Font FaceOffLFont
        {
            get =>  faceOffsT1Lbl.Font;
            set {
                faceOffsT1Lbl.Font = value;
                faceOffsT2Lbl.Font = value;
            }
        }

        public Font FaceOffFaceFont
        {
            get =>  faceOffsT1.Font;
            set {
                faceOffsT1.Font = value;
                faceOffsT2.Font = value;
            }
        }

        public Font ShotsLFont
        {
            get =>  shotsT1Lbl.Font;
            set {
                shotsT1Lbl.Font = value;
                shotsT2Lbl.Font = value;
            }
        }

        public Font ShotsSFont
        {
            get =>  shotsT1.Font;
            set {
                shotsT1.Font = value;
                shotsT2.Font = value;
            }
        }


        public Size LogoSize
        {
            get => team1Logo.Size;
            set
            {
                team1Logo.Size = value;
                team2Logo.Size = value;
            }
        }

        private bool _isLocked = true;

        public bool IsLocked
        {
            get => _isLocked;
            set
            {
                foreach (Control ctr in Controls)
                {
                    if (value == true)
                    {
                        ctr.BackColor = BackgrColor;
                    }
                    else
                    {
                        ctr.BackColor = Color.Red;
                    }
                }
                _isLocked = value;
            }
        }

        private int _gridSize = 50;

        public int GridSize
        {
            get => _gridSize;
            set => _gridSize = value;
        }

        private Point mouseClick;

        private static ScoreboardForm _instance;

        internal static ScoreboardForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ScoreboardForm();
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.MinimizeBox = false;
                _instance.MaximizeBox = false;
                _instance.ControlBox = false; 
                var bounds = Screen.AllScreens[1].Bounds;
                _instance.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                _instance.StartPosition = FormStartPosition.Manual;
                _instance.TopMost = true;
            }
            return _instance;
        }

        public ScoreboardForm()
        {
            InitializeComponent();
        }

        public void ResetInstance()
        {
            _instance = null;
        }

        public void SetTimeout(int team1, Time parTime)
        {
            if (team1 == 1)
            {
                timeout1Min.Text = CheckZero(parTime.Minutes);
                timeout1Sec.Text = CheckZero(parTime.Seconds);
            }
            else if (team1 == 2)
            {
                timeout2Min.Text = CheckZero(parTime.Minutes);
                timeout2Sec.Text = CheckZero(parTime.Seconds);
            }
        }

        public void SetFaceOff(bool team1, int parValue)
        {
            if (team1)
            {
                faceOffsT1.Text = parValue.ToString();
            }
            else
            {
                faceOffsT2.Text = parValue.ToString();
            }
        }

        public void SetShots(bool team1, int parValue)
        {
            if (team1)
            {
                shotsT1.Text = parValue.ToString();
            }
            else
            {
                shotsT2.Text = parValue.ToString();
            }
        }

        public void SetSize(int width, int height)
        {
            _instance.Height = height;
            _instance.Width = width;
        }

        public Font SetFontSize(float varSize, string parFont)
        {
            return new Font(parFont,varSize);
        }

        public void SetGoal(bool team1, int parGoals)
        {
            if (team1)
            {
                scoreT1Lbl.Text = parGoals.ToString();
            }
            else
            {
                scoreT2Lbl.Text = parGoals.ToString();
            }
            
        }

        public void HidePenalty(int position)
        {

            switch (position)
            {
                case 1:
                    playerNumber1T1lbl.Visible = false;
                    minutesT1P1Lbl.Visible = false;
                    timeT1P1ParseLbl.Visible = false;
                    secondsT1P1Lbl.Visible = false;
                    break;
                case 2:
                    playerNumber2T1lbl.Visible = false;
                    minutesT1P2Lbl.Visible = false;
                    timeT1P2ParseLbl.Visible = false;
                    secondsT1P2Lbl.Visible = false;
                    break;
                case 3:
                    playerNumber1T2lbl.Visible = false;
                    minutesT2P1Lbl.Visible = false;
                    timeT2P1ParseLbl.Visible = false;
                    secondsT2P1Lbl.Visible = false;
                    break;
                case 4:
                    playerNumber2T2lbl.Visible = false;
                    minutesT2P2Lbl.Visible = false;
                    timeT2P2ParseLbl.Visible = false;
                    secondsT2P2Lbl.Visible = false;
                    break;
                default:
                    throw new ArgumentException("Index is out of range");
            }
        }

        public void ShowPenalty(int position)
        {
            switch (position)
            {
                case 1:
                    playerNumber1T1lbl.Visible = true;
                    minutesT1P1Lbl.Visible = true;
                    timeT1P1ParseLbl.Visible = true;
                    secondsT1P1Lbl.Visible = true;
                    break;
                case 2:
                    playerNumber2T1lbl.Visible = true;
                    minutesT1P2Lbl.Visible = true;
                    timeT1P2ParseLbl.Visible = true;
                    secondsT1P2Lbl.Visible = true;
                    break;
                case 3:
                    playerNumber1T2lbl.Visible = true;
                    minutesT2P1Lbl.Visible = true;
                    timeT2P1ParseLbl.Visible = true;
                    secondsT2P1Lbl.Visible = true;
                    break;
                case 4:
                    playerNumber2T2lbl.Visible = true;
                    minutesT2P2Lbl.Visible = true;
                    timeT2P2ParseLbl.Visible = true;
                    secondsT2P2Lbl.Visible = true;
                    break;
                default:
                    throw new ArgumentException("Index is out of range");
            }
        }

        public void SetPenalty(int position, int number, int minutes, int seconds)
        {
            string sMinutes = CheckZero(minutes);
            string sSeconds = CheckZero(seconds);
            
            switch (position)
            {
                case 1:
                    playerNumber1T1lbl.Text = number.ToString();
                    minutesT1P1Lbl.Text = sMinutes;
                    secondsT1P1Lbl.Text = sSeconds;
                    break;
                case 2:
                    playerNumber2T1lbl.Text = number.ToString();
                    minutesT1P2Lbl.Text = sMinutes;
                    secondsT1P2Lbl.Text = sSeconds;
                    break;
                case 3:
                    playerNumber1T2lbl.Text = number.ToString();
                    minutesT2P1Lbl.Text = sMinutes;
                    secondsT2P1Lbl.Text = sSeconds;
                    break;
                case 4:
                    playerNumber2T2lbl.Text = number.ToString();
                    minutesT2P2Lbl.Text = sMinutes;
                    secondsT2P2Lbl.Text = sSeconds;
                    break;
                default:
                    throw new ArgumentException("Index is out of range");
            }
        }

        public void SetPeriod(string parPeriod)
        {
            actualPeriodLbl.Text = parPeriod;
        }

        public void SetTeamName(bool team1, string parName)
        {
            if (team1)
            {
                t1Lbl.Text = parName;
            }
            else
            {
                t2Lbl.Text = parName;
            }
            
        }

        public void SetLogo(bool team1, Image parLogo)
        {
            if (team1)
            {
                team1Logo.Image = parLogo;
            }
            else
            {
                team2Logo.Image = parLogo;
            }
            
        }

        public void HideLogo(bool team1)
        {
            if (team1)
            {
                team1Logo.Hide();
            }
            else
            {
                team2Logo.Hide();
            }
            
        }

        public void ShowLogo(bool team1)
        {
            if (team1)
                team1Logo.Show();
            else
                team2Logo.Show();
        }

        public void SetTime(Time parTime)
        {
            timeMinutesLbl.Text = CheckZero(parTime.Minutes);
            timeSecondsLbl.Text = CheckZero(parTime.Seconds);
        }

        public override string ToString()
        {
            return $"{BackgrColor}|{PenaltyDColor.ToArgb()}|{PenaltyLColor.ToArgb()}|{PeriodColor.ToArgb()}|{PeriodLColor.ToArgb()}|{TimeLColor.ToArgb()}|" +
                   $"{ScoLColor.ToArgb()}|{ScoSColor.ToArgb()}|{TimeCColor.ToArgb()}|" +

                   $"{PenaltyDFont.Size}|{PenaltyLFont.Size}|{PeriodLFont.Size}|{PeriodPFont.Size}|" +
                   $"{TimeLFont.Size}|{ScoLFont.Size}|{ScoSFont.Size}|{TimeCFont.Size}|" +
                   $"{Width}|{Height}";
        }

        private string CheckZero(int number)
        {
            if (number < 10)
            {
                return "0" + number;
            }
            return number.ToString();
        }

        private void SaveMouseLocation(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !_isLocked)
            {
                mouseClick = e.Location;
            }
        }

        private void ReplaceObject(MouseEventArgs e, Control toBeMoved)
        {
            if (e.Button == MouseButtons.Left && !_isLocked)
            {
                var y = e.Y - mouseClick.X;
                y -= y % _gridSize;
                toBeMoved.Top += y;
                var x = e.X - mouseClick.X;
                x -= x % _gridSize;
                toBeMoved.Left += x;
            }
        }

        public void SelectStats(bool[] parOptions)
        {
            if (!parOptions[0])
            {
                timeoutL1.Hide();
                timeoutL2.Hide();
                timeout1Min.Hide();
                timeout1Parse.Hide();
                timeout2Parse.Hide();
                timeout1Sec.Hide();
                timeout2Min.Hide();
                timeout2Sec.Hide();
            }
            else
            {
                timeoutL1.Show();
                timeoutL2.Show();
                timeout1Min.Show();
                timeout1Parse.Show();
                timeout2Parse.Show();
                timeout1Sec.Show();
                timeout2Min.Show();
                timeout2Sec.Show();
            }

            if (!parOptions[1])
            {
                faceOffsT1Lbl.Hide();
                faceOffsT1.Hide();
                faceOffsT2Lbl.Hide();
                faceOffsT2.Hide();
            }
            else
            {
                faceOffsT1Lbl.Show();
                faceOffsT1.Show();
                faceOffsT2Lbl.Show();
                faceOffsT2.Show();
            }

            if (!parOptions[2])
            {
                shotsT1Lbl.Hide();
                shotsT1.Hide();
                shotsT2Lbl.Hide();
                shotsT2.Hide();
            }
            else
            {
                shotsT1Lbl.Show();
                shotsT1.Show();
                shotsT2Lbl.Show();
                shotsT2.Show();
            }
        }











        private void team1Logo_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void team1Logo_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,team1Logo);
        }

        private void scoreT1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void scoreT1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,scoreT1Lbl);
        }

        private void t1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void t1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,t1Lbl);
        }

        private void scoreParseLblb_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void scoreParseLblb_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,scoreParseLblb);
        }

        private void scoreT2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void t2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void t2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,t2Lbl);
        }

        private void team2Logo_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void team2Logo_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,team2Logo);
        }

        private void periodLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void actualPeriodLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,actualPeriodLbl);
        }

        private void timeLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeLbl);
        }

        private void timeMinutesLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeMinutesLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeMinutesLbl);
        }

        private void timeParseLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeParseLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeParseLbl);
        }

        private void timeSecondsLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeSecondsLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeSecondsLbl);
        }

        private void timeoutL1_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeoutL1_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeoutL1);
        }

        private void timeout1Min_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeout1Min_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout1Min);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void label6_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout1Parse);
        }

        private void timeout1Sec_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeout1Sec_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout1Sec);
        }

        private void timeoutL2_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeoutL2_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeoutL2);
        }

        private void timeout2Min_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeout2Min_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout2Min);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout2Parse);
        }

        private void timeout2Sec_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeout2Sec_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeout2Sec);
        }

        private void penaltyT1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT1Lbl);
        }

        private void penaltyT1PlayerLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT1PlayerLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT1PlayerLbl);
        }

        private void penaltyT1TimeLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT1TimeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT1TimeLbl);
        }

        private void playerNumber1T1lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void playerNumber1T1lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,playerNumber1T1lbl);
        }

        private void playerNumber2T1lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void playerNumber2T1lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,playerNumber2T1lbl);
        }

        private void minutesT1P1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void minutesT1P1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,minutesT1P1Lbl);
        }

        private void timeT1P1ParseLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeT1P1ParseLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeT1P1ParseLbl);
        }

        private void secondsT1P1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void secondsT1P1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,secondsT1P1Lbl);
        }

        private void minutesT1P2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void minutesT1P2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,minutesT1P2Lbl);
        }

        private void timeT1P2ParseLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeT1P2ParseLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeT1P2ParseLbl);
        }

        private void secondsT1P2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void secondsT1P2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,secondsT1P2Lbl);
        }

        private void playerNumber1T2lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void playerNumber1T2lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,playerNumber1T2lbl);
        }

        private void playerNumber2T2lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void playerNumber2T2lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,playerNumber2T2lbl);
        }

        private void minutesT2P1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void minutesT2P1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,minutesT2P1Lbl);
        }

        private void timeT2P1ParseLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeT2P1ParseLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeT2P1ParseLbl);
        }

        private void secondsT2P1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void secondsT2P1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,secondsT2P1Lbl);
        }

        private void minutesT2P2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void minutesT2P2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,minutesT2P2Lbl);
        }

        private void timeT2P2ParseLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void timeT2P2ParseLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,timeT2P2ParseLbl);
        }

        private void secondsT2P2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void secondsT2P2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,secondsT2P2Lbl);
        }

        private void penaltyT2PlayerLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT2PlayerLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT2PlayerLbl);
        }

        private void penaltyT2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT2Lbl);
        }

        private void penaltyT2TimeLbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void penaltyT2TimeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,penaltyT2TimeLbl);
        }

        private void periodLbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,periodLbl);
        }

        private void scoreT2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,scoreT2Lbl);
        }

        private void faceOffsT1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void faceOffsT1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,faceOffsT1Lbl);
        }

        private void faceOffsT1_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void faceOffsT1_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,faceOffsT1);
        }

        private void faceOffsT2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void faceOffsT2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,faceOffsT2Lbl);
        }

        private void faceOffsT2_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void faceOffsT2_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,faceOffsT2);
        }

        private void shotsT1Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void shotsT1Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,shotsT1Lbl);
        }

        private void shotsT1_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void shotsT1_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,shotsT1);
        }

        private void shotsT2Lbl_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void shotsT2Lbl_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,shotsT2Lbl);
        }

        private void shotsT2_MouseDown(object sender, MouseEventArgs e)
        {
            SaveMouseLocation(e);
        }

        private void shotsT2_MouseMove(object sender, MouseEventArgs e)
        {
            ReplaceObject(e,shotsT2);
        }
    }
}
