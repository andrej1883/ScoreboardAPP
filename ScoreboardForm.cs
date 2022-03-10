﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scoreboard
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

        public Color BackgrColor
        {
            get => BackColor;
            set => BackColor = (Color)value;
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
            }
            return _instance;
        }

        private void ScoreboardForm_Load(object sender, EventArgs e)
        {
            
        }

        public ScoreboardForm()
        {
            InitializeComponent();
        }

        public void ResetInstance()
        {
            _instance = null;
        }

        public void SetSize(int width, int height)
        {
            _instance.Height = height;
            _instance.Width = width;
        }

        public Font SetFontSize(int varSize)
        {
            return new Font("Microsoft Sans Serif",varSize);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void SetGoal(string val, bool team1)
        {
            if (team1)
            {
                scoreT1Lbl.Text = val;
            }
            else
            {
                scoreT2Lbl.Text = val;
            }
        }

        public void HidePenalty(int position)
        {

            switch (position)
            {
                case 1:
                    playerNumber1T1lbl.ForeColor = BackgrColor;
                    minutesT1P1Lbl.ForeColor = BackgrColor;
                    timeT1P1ParseLbl.ForeColor = BackgrColor;
                    secondsT1P1Lbl.ForeColor = BackgrColor;
                    break;
                case 2:
                    playerNumber2T1lbl.ForeColor = BackgrColor;
                    minutesT1P2Lbl.ForeColor = BackgrColor;
                    timeT1P2ParseLbl.ForeColor = BackgrColor;
                    secondsT1P2Lbl.ForeColor = BackgrColor;
                    break;
                case 3:
                    playerNumber1T2lbl.ForeColor = BackgrColor;
                    minutesT2P1Lbl.ForeColor = BackgrColor;
                    timeT2P1ParseLbl.ForeColor = BackgrColor;
                    secondsT2P1Lbl.ForeColor = BackgrColor;
                    break;
                case 4:
                    playerNumber2T2lbl.ForeColor = BackgrColor;
                    minutesT2P2Lbl.ForeColor = BackgrColor;
                    timeT2P2ParseLbl.ForeColor = BackgrColor;
                    secondsT2P2Lbl.ForeColor = BackgrColor;
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
                    playerNumber1T1lbl.ForeColor = PenaltyDColor;
                    minutesT1P1Lbl.ForeColor = PenaltyDColor;
                    timeT1P1ParseLbl.ForeColor = PenaltyDColor;
                    secondsT1P1Lbl.ForeColor = PenaltyDColor;
                    break;
                case 2:
                    playerNumber2T1lbl.ForeColor = PenaltyDColor;;
                    minutesT1P2Lbl.ForeColor = PenaltyDColor;
                    timeT1P2ParseLbl.ForeColor = PenaltyDColor;
                    secondsT1P2Lbl.ForeColor = PenaltyDColor;
                    break;
                case 3:
                    playerNumber1T2lbl.ForeColor = PenaltyDColor;
                    minutesT2P1Lbl.ForeColor = PenaltyDColor;
                    timeT2P1ParseLbl.ForeColor = PenaltyDColor;
                    secondsT2P1Lbl.ForeColor = PenaltyDColor;
                    break;
                case 4:
                    playerNumber2T2lbl.ForeColor = PenaltyDColor;
                    minutesT2P2Lbl.ForeColor = PenaltyDColor;
                    timeT2P2ParseLbl.ForeColor = PenaltyDColor;
                    secondsT2P2Lbl.ForeColor = PenaltyDColor;
                    break;
                default:
                    throw new ArgumentException("Index is out of range");
            }
        }
        public void SetPenalty(int position, int number, int minutes, int seconds)
        {
            string sMinutes;
            string sSeconds;
            if (minutes < 10)
            {
                 sMinutes = "0" + minutes;
            }
            else
            {
                sMinutes = minutes.ToString();
            }

            if (seconds < 10)
            {
                sSeconds = "0" + seconds;
            }
            else
            {
                sSeconds = seconds.ToString();
            }

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

        public void SetPeriod(string val)
        {
            actualPeriodLbl.Text = val;
        }

        public void SetTeamName(bool team1, string val)
        {
            if (team1)
            {
                t1Lbl.Text = val;
            }
            else
            {
                t2Lbl.Text = val;
            }
        }

        public void SetLogo(bool team1, Image var)
        {
            if (team1)
            {
                team1Logo.Image = var;
            }
            else
            {
                team2Logo.Image = var;
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
            {
                team1Logo.Show();
            }
            else
            {
                team2Logo.Show();
            }
        }

        public void SetTime(int minutes, int seconds)
        {
            if (minutes < 10)
            {
                timeMinutesLbl.Text = "0" + minutes;
            }
            else
            {
                timeMinutesLbl.Text =  minutes.ToString();
            }

            if (seconds < 10)
            {
                timeSecondsLbl.Text = "0" + seconds;
            }
            else
            {
                timeSecondsLbl.Text =  seconds.ToString();
            }
        }
        public override string ToString()
        {
            return $"{BackgrColor.Name},{PenaltyDColor.Name},{PenaltyLColor.Name},{PeriodColor.Name},{PeriodLColor.Name},{TimeLColor.Name}," +
                   $"{ScoLColor.Name},{ScoSColor.Name},{TimeCColor.Name}," +

                   $"{PenaltyDFont.Size},{PenaltyLFont.Size},{PeriodLFont.Size},{PeriodPFont.Size}," +
                   $"{TimeLFont.Size},{ScoLFont.Size},{ScoSFont.Size},{TimeCFont.Size}," +
                   $"{Width},{Height}";
        }
    }
}
