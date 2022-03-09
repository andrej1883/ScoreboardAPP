using System;
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
        private bool _isActive = false;
        private Color _scoSColor = Color.Black;
        private double _scoSSize;
        private Color _scoLColor = Color.Black;
        private double _scoLSize;
        private Color _timeCColor = Color.Black;
        private double _timeCSize;

        public Color ScoSColor
        {
            get => _scoSColor;
            set {
                _scoSColor = value;
                this.scoreT1Lbl.ForeColor = (Color)value;
                this.scoreParseLblb.ForeColor = (Color)value;
                this.scoreT2Lbl.ForeColor = (Color)value;
            }
        }

        public double ScoSSize
        {
            get => _scoSSize;
            set {
                _scoSSize = value;
                scoreT1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                scoreT2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                scoreParseLblb.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public Color ScoLColor
        {
            get => _scoLColor;
            set {
                _scoLColor = value;
                this.t1Lbl.ForeColor = (Color)value;
                this.t2Lbl.ForeColor = (Color)value;
            }

        }

        public double ScoLSize
        {
            get => _scoLSize;
            set {
                _scoLSize = value;
                t1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                t2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public Color TimeCColor
        {
            get => _timeCColor;
            set {
                _timeCColor = value;
                this.timeMinutesLbl.ForeColor = (Color)value;
                this.timeSecondsLbl.ForeColor = (Color)value;
                this.timeParseLbl.ForeColor = (Color)value;
            }
        }

        public double TimeCSize
        {
            get => _timeCSize;
            set {
                _timeCSize = value;
                timeMinutesLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeParseLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeSecondsLbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public Color TimeLColor
        {
            get => _timeLColor;
            set {
                _timeLColor = value;
                this.timeLbl.ForeColor = (Color)value;
            }
        }

        public double TimeLSize
        {
            get => _timeLSize;
            set {
                _timeLSize = value;
                timeLbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public double PeriodPSize
        {
            get => _periodPSize;
            set {
                _periodPSize = value;
                actualPeriodLbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public Color PeriodColor
        {
            get => _periodColor;
            set {
                _periodColor = value;
                this.actualPeriodLbl.ForeColor = (Color)value;
            }
        }

        public double PeriodLSize
        {
            get => _periodLSize;
            set {
                _periodLSize = value;
                periodLbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        public Color PenaltyDColor
        {
            get => _penaltyDColor;
            set {
                _penaltyDColor = value;
                this.playerNumber1T1lbl.ForeColor = (Color)value;
                this.playerNumber1T2lbl.ForeColor = (Color)value;
                this.playerNumber2T1lbl.ForeColor = (Color)value;
                this.playerNumber2T2lbl.ForeColor = (Color)value;
                this.minutesT1P1Lbl.ForeColor = (Color)value;
                this.minutesT1P2Lbl.ForeColor = (Color)value;
                this.minutesT2P1Lbl.ForeColor = (Color)value;
                this.minutesT2P2Lbl.ForeColor = (Color)value;
                this.timeT1P1ParseLbl.ForeColor = (Color)value;
                this.timeT1P2ParseLbl.ForeColor = (Color)value;
                this.timeT2P1ParseLbl.ForeColor = (Color)value;
                this.timeT2P2ParseLbl.ForeColor = (Color)value;
                this.secondsT1P1Lbl.ForeColor = (Color)value;
                this.secondsT1P2Lbl.ForeColor = (Color)value;
                this.secondsT2P1Lbl.ForeColor = (Color)value;
                this.secondsT2P2Lbl.ForeColor = (Color)value;
            }
        }

        public double PenaltyDSize
        {
            get => _penaltyDSize;
            set {
                _penaltyDSize = value;
                playerNumber1T1lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                playerNumber2T1lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                minutesT1P1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeT1P1ParseLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                secondsT1P1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                minutesT1P2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeT1P2ParseLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                secondsT1P2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                playerNumber1T2lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                playerNumber2T2lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                minutesT2P1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeT2P1ParseLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                secondsT2P1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                minutesT2P2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                timeT2P2ParseLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                secondsT2P2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);

            }
        }

        public Color PenaltyLColor
        {
            get => _penaltyLColor;
            set {
                _penaltyLColor = value;
                this.penaltyT1Lbl.ForeColor = (Color)value;
                this.penaltyT2Lbl.ForeColor = (Color)value;
                this.penaltyT1PlayerLbl.ForeColor = (Color)value;
                this.penaltyT2PlayerLbl.ForeColor = (Color)value;
                this.penaltyT1TimeLbl.ForeColor = (Color)value;
                this.penaltyT2TimeLbl.ForeColor = (Color)value;
            }
        }

        public double PenaltyLSize
        {
            get => _penaltyLSize;
            set {
                _penaltyLSize = value;
                penaltyT1Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                penaltyT2Lbl.Font = new Font("Microsoft Sans Serif",(int)value);
                penaltyT1PlayerLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                penaltyT1TimeLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                penaltyT2PlayerLbl.Font = new Font("Microsoft Sans Serif",(int)value);
                penaltyT2TimeLbl.Font = new Font("Microsoft Sans Serif",(int)value);
            }
        }

        private Color _timeLColor = Color.Black;
        private double _timeLSize;
        private double _periodPSize;
        private Color _periodColor = Color.Black;
        private Color _periodLColor = Color.Black;

        public Color PeriodLColor
        {
            get => _periodLColor;
            set {
                _periodLColor = value;
                this.periodLbl.ForeColor = (Color)value;
            }
        }

        private double _periodLSize;
        private Color _penaltyDColor = Color.Black;
        private double _penaltyDSize;
        private Color _penaltyLColor = Color.Black;
        private double _penaltyLSize;
        private Color _backgrColor = DefaultBackColor;

        public Color BackgrColor
        {
            get => _backgrColor;
            set {
                _backgrColor = value;
                this.BackColor = (Color)value;
                }
        }

        private static ScoreboardForm _instance;
        internal static ScoreboardForm GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ScoreboardForm();
                Screen[] screens = Screen.AllScreens;
                Rectangle bounds = screens[1].Bounds;
                _instance.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);
                _instance.StartPosition = FormStartPosition.Manual;
            }
            return _instance;
        }

        private void ScoreboardForm_Load(object sender, EventArgs e)
        {
            _scoLSize = t1Lbl.Font.Size;
            PeriodLSize = periodLbl.Font.Size;
            TimeLSize = timeLbl.Font.Size;
            PenaltyLSize = penaltyT1Lbl.Font.Size;
            ScoSSize = scoreT1Lbl.Font.Size;
            PeriodPSize = actualPeriodLbl.Font.Size;
            _timeCSize = timeMinutesLbl.Font.Size;
            PenaltyDSize = playerNumber1T1lbl.Font.Size;
        }

        public void SetActive(bool active)
        {
            _isActive = active;
        }

        public bool GetActive()
        {
            return _isActive;
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
                 sMinutes = "0" + minutes.ToString();
            }
            else
            {
                sMinutes = minutes.ToString();
            }

            if (seconds < 10)
            {
                sSeconds = "0" + seconds.ToString();
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
                timeMinutesLbl.Text = "0" + minutes.ToString();
            }
            else
            {
                timeMinutesLbl.Text =  minutes.ToString();
            }

            if (seconds < 10)
            {
                timeSecondsLbl.Text = "0" + seconds.ToString();
            }
            else
            {
                timeSecondsLbl.Text =  seconds.ToString();
            }
        }
        public override string ToString()
        {
            return $"{_backgrColor.Name},{_penaltyDColor.Name},{_penaltyLColor.Name},{_periodColor.Name},{_periodLColor.Name},{_timeLColor.Name}," +
                   $"{_scoLColor.Name},{_scoSColor.Name},{_timeCColor.Name}," +

                   $"{_penaltyDSize},{_penaltyLSize},{_periodLSize},{_periodPSize}," +
                   $"{_timeLSize},{_scoLSize},{_scoSSize},{_timeCSize}," +
                   $"{this.Width},{this.Height}";
        }
    }
}
