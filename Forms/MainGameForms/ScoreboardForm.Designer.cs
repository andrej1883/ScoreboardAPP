using System.ComponentModel;
using System.Windows.Forms;

namespace Scoreboard.Forms.MainGameForms
{
    partial class ScoreboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.t1Lbl = new System.Windows.Forms.Label();
            this.t2Lbl = new System.Windows.Forms.Label();
            this.scoreT1Lbl = new System.Windows.Forms.Label();
            this.scoreT2Lbl = new System.Windows.Forms.Label();
            this.scoreParseLblb = new System.Windows.Forms.Label();
            this.periodLbl = new System.Windows.Forms.Label();
            this.timeMinutesLbl = new System.Windows.Forms.Label();
            this.timeParseLbl = new System.Windows.Forms.Label();
            this.timeSecondsLbl = new System.Windows.Forms.Label();
            this.actualPeriodLbl = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.penaltyT1Lbl = new System.Windows.Forms.Label();
            this.penaltyT1PlayerLbl = new System.Windows.Forms.Label();
            this.penaltyT1TimeLbl = new System.Windows.Forms.Label();
            this.penaltyT2TimeLbl = new System.Windows.Forms.Label();
            this.penaltyT2PlayerLbl = new System.Windows.Forms.Label();
            this.penaltyT2Lbl = new System.Windows.Forms.Label();
            this.playerNumber1T1lbl = new System.Windows.Forms.Label();
            this.playerNumber1T2lbl = new System.Windows.Forms.Label();
            this.playerNumber2T1lbl = new System.Windows.Forms.Label();
            this.playerNumber2T2lbl = new System.Windows.Forms.Label();
            this.minutesT1P1Lbl = new System.Windows.Forms.Label();
            this.secondsT1P1Lbl = new System.Windows.Forms.Label();
            this.timeT1P1ParseLbl = new System.Windows.Forms.Label();
            this.timeT1P2ParseLbl = new System.Windows.Forms.Label();
            this.secondsT1P2Lbl = new System.Windows.Forms.Label();
            this.minutesT1P2Lbl = new System.Windows.Forms.Label();
            this.timeT2P1ParseLbl = new System.Windows.Forms.Label();
            this.secondsT2P1Lbl = new System.Windows.Forms.Label();
            this.minutesT2P1Lbl = new System.Windows.Forms.Label();
            this.timeT2P2ParseLbl = new System.Windows.Forms.Label();
            this.secondsT2P2Lbl = new System.Windows.Forms.Label();
            this.minutesT2P2Lbl = new System.Windows.Forms.Label();
            this.team1Logo = new System.Windows.Forms.PictureBox();
            this.team2Logo = new System.Windows.Forms.PictureBox();
            this.timeoutL2 = new System.Windows.Forms.Label();
            this.timeoutL1 = new System.Windows.Forms.Label();
            this.timeout2Parse = new System.Windows.Forms.Label();
            this.timeout2Sec = new System.Windows.Forms.Label();
            this.timeout2Min = new System.Windows.Forms.Label();
            this.timeout1Parse = new System.Windows.Forms.Label();
            this.timeout1Sec = new System.Windows.Forms.Label();
            this.timeout1Min = new System.Windows.Forms.Label();
            this.faceOffsT1Lbl = new System.Windows.Forms.Label();
            this.faceOffsT2Lbl = new System.Windows.Forms.Label();
            this.faceOffsT1 = new System.Windows.Forms.Label();
            this.faceOffsT2 = new System.Windows.Forms.Label();
            this.shotsT1 = new System.Windows.Forms.Label();
            this.shotsT1Lbl = new System.Windows.Forms.Label();
            this.shotsT2 = new System.Windows.Forms.Label();
            this.shotsT2Lbl = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.team1Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // t1Lbl
            // 
            this.t1Lbl.AutoSize = true;
            this.t1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.t1Lbl.ForeColor = System.Drawing.Color.Black;
            this.t1Lbl.Location = new System.Drawing.Point(411, 84);
            this.t1Lbl.Name = "t1Lbl";
            this.t1Lbl.Size = new System.Drawing.Size(58, 20);
            this.t1Lbl.TabIndex = 2;
            this.t1Lbl.Text = "Team1";
            this.t1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.t1Lbl, "Team 1 EventName");
            this.t1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.T1LblMouseDown);
            this.t1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.T1LblMouseMove);
            // 
            // t2Lbl
            // 
            this.t2Lbl.AutoSize = true;
            this.t2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.t2Lbl.ForeColor = System.Drawing.Color.Black;
            this.t2Lbl.Location = new System.Drawing.Point(804, 84);
            this.t2Lbl.Name = "t2Lbl";
            this.t2Lbl.Size = new System.Drawing.Size(58, 20);
            this.t2Lbl.TabIndex = 3;
            this.t2Lbl.Text = "Team2";
            this.t2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.t2Lbl, "Team 2 EventName");
            this.t2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.T2LblMouseDown);
            this.t2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.T2LblMouseMove);
            // 
            // scoreT1Lbl
            // 
            this.scoreT1Lbl.AutoSize = true;
            this.scoreT1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT1Lbl.Location = new System.Drawing.Point(493, 169);
            this.scoreT1Lbl.Name = "scoreT1Lbl";
            this.scoreT1Lbl.Size = new System.Drawing.Size(106, 76);
            this.scoreT1Lbl.TabIndex = 4;
            this.scoreT1Lbl.Text = "00";
            this.scoreT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.scoreT1Lbl, "Score Team1");
            this.scoreT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScoreT1LblMouseDown);
            this.scoreT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScoreT1LblMouseMove);
            // 
            // scoreT2Lbl
            // 
            this.scoreT2Lbl.AutoSize = true;
            this.scoreT2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT2Lbl.Location = new System.Drawing.Point(665, 169);
            this.scoreT2Lbl.Name = "scoreT2Lbl";
            this.scoreT2Lbl.Size = new System.Drawing.Size(106, 76);
            this.scoreT2Lbl.TabIndex = 5;
            this.scoreT2Lbl.Text = "00";
            this.scoreT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.scoreT2Lbl, "Score Team2");
            this.scoreT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScoreT2LblMouseDown);
            this.scoreT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScoreT2LblMouseMove);
            // 
            // scoreParseLblb
            // 
            this.scoreParseLblb.AutoSize = true;
            this.scoreParseLblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreParseLblb.ForeColor = System.Drawing.Color.Black;
            this.scoreParseLblb.Location = new System.Drawing.Point(605, 169);
            this.scoreParseLblb.Name = "scoreParseLblb";
            this.scoreParseLblb.Size = new System.Drawing.Size(54, 76);
            this.scoreParseLblb.TabIndex = 6;
            this.scoreParseLblb.Text = "-";
            this.scoreParseLblb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.scoreParseLblb, "Score separator");
            this.scoreParseLblb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScoreParseLblbMouseDown);
            this.scoreParseLblb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScoreParseLblbMouseMove);
            // 
            // periodLbl
            // 
            this.periodLbl.AutoSize = true;
            this.periodLbl.ForeColor = System.Drawing.Color.Black;
            this.periodLbl.Location = new System.Drawing.Point(614, 39);
            this.periodLbl.Name = "periodLbl";
            this.periodLbl.Size = new System.Drawing.Size(37, 13);
            this.periodLbl.TabIndex = 7;
            this.periodLbl.Text = "Period";
            this.periodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.periodLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PeriodLblMouseDown);
            this.periodLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PeriodLblMouseMove);
            // 
            // timeMinutesLbl
            // 
            this.timeMinutesLbl.AutoSize = true;
            this.timeMinutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeMinutesLbl.ForeColor = System.Drawing.Color.Black;
            this.timeMinutesLbl.Location = new System.Drawing.Point(360, 416);
            this.timeMinutesLbl.Name = "timeMinutesLbl";
            this.timeMinutesLbl.Size = new System.Drawing.Size(215, 153);
            this.timeMinutesLbl.TabIndex = 8;
            this.timeMinutesLbl.Text = "00";
            this.timeMinutesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeMinutesLbl, "Time minutes");
            this.timeMinutesLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeMinutesLblMouseDown);
            this.timeMinutesLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeMinutesLblMouseMove);
            // 
            // timeParseLbl
            // 
            this.timeParseLbl.AutoSize = true;
            this.timeParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeParseLbl.Location = new System.Drawing.Point(581, 416);
            this.timeParseLbl.Name = "timeParseLbl";
            this.timeParseLbl.Size = new System.Drawing.Size(102, 153);
            this.timeParseLbl.TabIndex = 9;
            this.timeParseLbl.Text = ":";
            this.timeParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeParseLbl, "Time separator");
            this.timeParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeParseLblMouseDown);
            this.timeParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeParseLblMouseMove);
            // 
            // timeSecondsLbl
            // 
            this.timeSecondsLbl.AutoSize = true;
            this.timeSecondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeSecondsLbl.ForeColor = System.Drawing.Color.Black;
            this.timeSecondsLbl.Location = new System.Drawing.Point(689, 416);
            this.timeSecondsLbl.Name = "timeSecondsLbl";
            this.timeSecondsLbl.Size = new System.Drawing.Size(215, 153);
            this.timeSecondsLbl.TabIndex = 10;
            this.timeSecondsLbl.Text = "00";
            this.timeSecondsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeSecondsLbl, "Time seconds");
            this.timeSecondsLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeSecondsLblMouseDown);
            this.timeSecondsLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeSecondsLblMouseMove);
            // 
            // actualPeriodLbl
            // 
            this.actualPeriodLbl.AutoSize = true;
            this.actualPeriodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualPeriodLbl.ForeColor = System.Drawing.Color.Black;
            this.actualPeriodLbl.Location = new System.Drawing.Point(600, 63);
            this.actualPeriodLbl.Name = "actualPeriodLbl";
            this.actualPeriodLbl.Size = new System.Drawing.Size(64, 46);
            this.actualPeriodLbl.TabIndex = 11;
            this.actualPeriodLbl.Text = "00";
            this.actualPeriodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.actualPeriodLbl, "Period Number");
            this.actualPeriodLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ActualPeriodLblMouseMove);
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(595, 348);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(74, 31);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeLblMouseDown);
            this.timeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeLblMouseMove);
            // 
            // penaltyT1Lbl
            // 
            this.penaltyT1Lbl.AutoSize = true;
            this.penaltyT1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.penaltyT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1Lbl.Location = new System.Drawing.Point(272, 746);
            this.penaltyT1Lbl.Name = "penaltyT1Lbl";
            this.penaltyT1Lbl.Size = new System.Drawing.Size(77, 25);
            this.penaltyT1Lbl.TabIndex = 14;
            this.penaltyT1Lbl.Text = "Penalty";
            this.penaltyT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1LblMouseDown);
            this.penaltyT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1LblMouseMove);
            // 
            // penaltyT1PlayerLbl
            // 
            this.penaltyT1PlayerLbl.AutoSize = true;
            this.penaltyT1PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1PlayerLbl.Location = new System.Drawing.Point(193, 786);
            this.penaltyT1PlayerLbl.Name = "penaltyT1PlayerLbl";
            this.penaltyT1PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT1PlayerLbl.TabIndex = 15;
            this.penaltyT1PlayerLbl.Text = "Player";
            this.penaltyT1PlayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1PlayerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1PlayerLblMouseDown);
            this.penaltyT1PlayerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1PlayerLblMouseMove);
            // 
            // penaltyT1TimeLbl
            // 
            this.penaltyT1TimeLbl.AutoSize = true;
            this.penaltyT1TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1TimeLbl.Location = new System.Drawing.Point(353, 786);
            this.penaltyT1TimeLbl.Name = "penaltyT1TimeLbl";
            this.penaltyT1TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT1TimeLbl.TabIndex = 16;
            this.penaltyT1TimeLbl.Text = "Time";
            this.penaltyT1TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1TimeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1TimeLblMouseDown);
            this.penaltyT1TimeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT1TimeLblMouseMove);
            // 
            // penaltyT2TimeLbl
            // 
            this.penaltyT2TimeLbl.AutoSize = true;
            this.penaltyT2TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2TimeLbl.Location = new System.Drawing.Point(997, 786);
            this.penaltyT2TimeLbl.Name = "penaltyT2TimeLbl";
            this.penaltyT2TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT2TimeLbl.TabIndex = 19;
            this.penaltyT2TimeLbl.Text = "Time";
            this.penaltyT2TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2TimeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2TimeLblMouseDown);
            this.penaltyT2TimeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2TimeLblMouseMove);
            // 
            // penaltyT2PlayerLbl
            // 
            this.penaltyT2PlayerLbl.AutoSize = true;
            this.penaltyT2PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2PlayerLbl.Location = new System.Drawing.Point(853, 786);
            this.penaltyT2PlayerLbl.Name = "penaltyT2PlayerLbl";
            this.penaltyT2PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT2PlayerLbl.TabIndex = 18;
            this.penaltyT2PlayerLbl.Text = "Player";
            this.penaltyT2PlayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2PlayerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2PlayerLblMouseDown);
            this.penaltyT2PlayerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2PlayerLblMouseMove);
            // 
            // penaltyT2Lbl
            // 
            this.penaltyT2Lbl.AutoSize = true;
            this.penaltyT2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.penaltyT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2Lbl.Location = new System.Drawing.Point(923, 746);
            this.penaltyT2Lbl.Name = "penaltyT2Lbl";
            this.penaltyT2Lbl.Size = new System.Drawing.Size(77, 25);
            this.penaltyT2Lbl.TabIndex = 17;
            this.penaltyT2Lbl.Text = "Penalty";
            this.penaltyT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2LblMouseDown);
            this.penaltyT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PenaltyT2LblMouseMove);
            // 
            // playerNumber1T1lbl
            // 
            this.playerNumber1T1lbl.AutoSize = true;
            this.playerNumber1T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T1lbl.Location = new System.Drawing.Point(179, 808);
            this.playerNumber1T1lbl.Name = "playerNumber1T1lbl";
            this.playerNumber1T1lbl.Size = new System.Drawing.Size(64, 46);
            this.playerNumber1T1lbl.TabIndex = 20;
            this.playerNumber1T1lbl.Text = "00";
            this.playerNumber1T1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.playerNumber1T1lbl, "Team 1 Player 1 number");
            this.playerNumber1T1lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber1T1LblMouseDown);
            this.playerNumber1T1lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber1T1LblMouseMove);
            // 
            // playerNumber1T2lbl
            // 
            this.playerNumber1T2lbl.AutoSize = true;
            this.playerNumber1T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T2lbl.Location = new System.Drawing.Point(839, 808);
            this.playerNumber1T2lbl.Name = "playerNumber1T2lbl";
            this.playerNumber1T2lbl.Size = new System.Drawing.Size(64, 46);
            this.playerNumber1T2lbl.TabIndex = 21;
            this.playerNumber1T2lbl.Text = "00";
            this.playerNumber1T2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.playerNumber1T2lbl, "Team 2 Player 1 number");
            this.playerNumber1T2lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber1T2LblMouseDown);
            this.playerNumber1T2lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber1T2LblMouseMove);
            // 
            // playerNumber2T1lbl
            // 
            this.playerNumber2T1lbl.AutoSize = true;
            this.playerNumber2T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T1lbl.Location = new System.Drawing.Point(179, 848);
            this.playerNumber2T1lbl.Name = "playerNumber2T1lbl";
            this.playerNumber2T1lbl.Size = new System.Drawing.Size(64, 46);
            this.playerNumber2T1lbl.TabIndex = 22;
            this.playerNumber2T1lbl.Text = "00";
            this.playerNumber2T1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.playerNumber2T1lbl, "Team 1 Player 2 number");
            this.playerNumber2T1lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber2T1LblMouseDown);
            this.playerNumber2T1lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber2T1LblMouseMove);
            // 
            // playerNumber2T2lbl
            // 
            this.playerNumber2T2lbl.AutoSize = true;
            this.playerNumber2T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T2lbl.Location = new System.Drawing.Point(839, 848);
            this.playerNumber2T2lbl.Name = "playerNumber2T2lbl";
            this.playerNumber2T2lbl.Size = new System.Drawing.Size(64, 46);
            this.playerNumber2T2lbl.TabIndex = 23;
            this.playerNumber2T2lbl.Text = "00";
            this.playerNumber2T2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.playerNumber2T2lbl, "Team 2 Player 2 number");
            this.playerNumber2T2lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber2T2LblMouseDown);
            this.playerNumber2T2lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PlayerNumber2T2LblMouseMove);
            // 
            // minutesT1P1Lbl
            // 
            this.minutesT1P1Lbl.AutoSize = true;
            this.minutesT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P1Lbl.Location = new System.Drawing.Point(283, 808);
            this.minutesT1P1Lbl.Name = "minutesT1P1Lbl";
            this.minutesT1P1Lbl.Size = new System.Drawing.Size(64, 46);
            this.minutesT1P1Lbl.TabIndex = 24;
            this.minutesT1P1Lbl.Text = "00";
            this.minutesT1P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.minutesT1P1Lbl, "Team 1 Player 1 minutes");
            this.minutesT1P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinutesT1P1LblMouseDown);
            this.minutesT1P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinutesT1P1LblMouseMove);
            // 
            // secondsT1P1Lbl
            // 
            this.secondsT1P1Lbl.AutoSize = true;
            this.secondsT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P1Lbl.Location = new System.Drawing.Point(390, 808);
            this.secondsT1P1Lbl.Name = "secondsT1P1Lbl";
            this.secondsT1P1Lbl.Size = new System.Drawing.Size(64, 46);
            this.secondsT1P1Lbl.TabIndex = 28;
            this.secondsT1P1Lbl.Text = "00";
            this.secondsT1P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.secondsT1P1Lbl, "Team 1 Player 1 seconds");
            this.secondsT1P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondsT1P1LblMouseDown);
            this.secondsT1P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondsT1P1LblMouseMove);
            // 
            // timeT1P1ParseLbl
            // 
            this.timeT1P1ParseLbl.AutoSize = true;
            this.timeT1P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P1ParseLbl.Location = new System.Drawing.Point(353, 808);
            this.timeT1P1ParseLbl.Name = "timeT1P1ParseLbl";
            this.timeT1P1ParseLbl.Size = new System.Drawing.Size(31, 46);
            this.timeT1P1ParseLbl.TabIndex = 36;
            this.timeT1P1ParseLbl.Text = ":";
            this.timeT1P1ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeT1P1ParseLbl, "Team 1 Player 1 separator");
            this.timeT1P1ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeT1P1ParseLblMouseDown);
            this.timeT1P1ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeT1P1ParseLblMouseMove);
            // 
            // timeT1P2ParseLbl
            // 
            this.timeT1P2ParseLbl.AutoSize = true;
            this.timeT1P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P2ParseLbl.Location = new System.Drawing.Point(353, 848);
            this.timeT1P2ParseLbl.Name = "timeT1P2ParseLbl";
            this.timeT1P2ParseLbl.Size = new System.Drawing.Size(31, 46);
            this.timeT1P2ParseLbl.TabIndex = 40;
            this.timeT1P2ParseLbl.Text = ":";
            this.timeT1P2ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeT1P2ParseLbl, "Team 1 Player 2 separator");
            this.timeT1P2ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeT1P2ParseLblMouseDown);
            this.timeT1P2ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeT1P2ParseLblMouseMove);
            // 
            // secondsT1P2Lbl
            // 
            this.secondsT1P2Lbl.AutoSize = true;
            this.secondsT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P2Lbl.Location = new System.Drawing.Point(390, 848);
            this.secondsT1P2Lbl.Name = "secondsT1P2Lbl";
            this.secondsT1P2Lbl.Size = new System.Drawing.Size(64, 46);
            this.secondsT1P2Lbl.TabIndex = 38;
            this.secondsT1P2Lbl.Text = "00";
            this.secondsT1P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.secondsT1P2Lbl, "Team 1 Player 2 seconds");
            this.secondsT1P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondsT1P2LblMouseDown);
            this.secondsT1P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondsT1P2LblMouseMove);
            // 
            // minutesT1P2Lbl
            // 
            this.minutesT1P2Lbl.AutoSize = true;
            this.minutesT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P2Lbl.Location = new System.Drawing.Point(283, 848);
            this.minutesT1P2Lbl.Name = "minutesT1P2Lbl";
            this.minutesT1P2Lbl.Size = new System.Drawing.Size(64, 46);
            this.minutesT1P2Lbl.TabIndex = 37;
            this.minutesT1P2Lbl.Text = "00";
            this.minutesT1P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.minutesT1P2Lbl, "Team 1 Player 2 minutes");
            this.minutesT1P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinutesT1P2LblMouseDown);
            this.minutesT1P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinutesT1P2LblMouseMove);
            // 
            // timeT2P1ParseLbl
            // 
            this.timeT2P1ParseLbl.AutoSize = true;
            this.timeT2P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P1ParseLbl.Location = new System.Drawing.Point(997, 808);
            this.timeT2P1ParseLbl.Name = "timeT2P1ParseLbl";
            this.timeT2P1ParseLbl.Size = new System.Drawing.Size(31, 46);
            this.timeT2P1ParseLbl.TabIndex = 44;
            this.timeT2P1ParseLbl.Text = ":";
            this.timeT2P1ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeT2P1ParseLbl, "Team 2 Player 1 separator");
            this.timeT2P1ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeT2P1ParseLblMouseDown);
            this.timeT2P1ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeT2P1ParseLblMouseMove);
            // 
            // secondsT2P1Lbl
            // 
            this.secondsT2P1Lbl.AutoSize = true;
            this.secondsT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P1Lbl.Location = new System.Drawing.Point(1024, 808);
            this.secondsT2P1Lbl.Name = "secondsT2P1Lbl";
            this.secondsT2P1Lbl.Size = new System.Drawing.Size(64, 46);
            this.secondsT2P1Lbl.TabIndex = 42;
            this.secondsT2P1Lbl.Text = "00";
            this.secondsT2P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.secondsT2P1Lbl, "Team 2 Player 1 seconds");
            this.secondsT2P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondsT2P1LblMouseDown);
            this.secondsT2P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondsT2P1LblMouseMove);
            // 
            // minutesT2P1Lbl
            // 
            this.minutesT2P1Lbl.AutoSize = true;
            this.minutesT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P1Lbl.Location = new System.Drawing.Point(941, 808);
            this.minutesT2P1Lbl.Name = "minutesT2P1Lbl";
            this.minutesT2P1Lbl.Size = new System.Drawing.Size(64, 46);
            this.minutesT2P1Lbl.TabIndex = 41;
            this.minutesT2P1Lbl.Text = "00";
            this.minutesT2P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.minutesT2P1Lbl, "Team 2 Player 1 minutes");
            this.minutesT2P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinutesT2P1LblMouseDown);
            this.minutesT2P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinutesT2P1LblMouseMove);
            // 
            // timeT2P2ParseLbl
            // 
            this.timeT2P2ParseLbl.AutoSize = true;
            this.timeT2P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P2ParseLbl.Location = new System.Drawing.Point(997, 848);
            this.timeT2P2ParseLbl.Name = "timeT2P2ParseLbl";
            this.timeT2P2ParseLbl.Size = new System.Drawing.Size(31, 46);
            this.timeT2P2ParseLbl.TabIndex = 48;
            this.timeT2P2ParseLbl.Text = ":";
            this.timeT2P2ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeT2P2ParseLbl, "Team 2 Player 2 separator");
            this.timeT2P2ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeT2P2ParseLblMouseDown);
            this.timeT2P2ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeT2P2ParseLblMouseMove);
            // 
            // secondsT2P2Lbl
            // 
            this.secondsT2P2Lbl.AutoSize = true;
            this.secondsT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P2Lbl.Location = new System.Drawing.Point(1024, 848);
            this.secondsT2P2Lbl.Name = "secondsT2P2Lbl";
            this.secondsT2P2Lbl.Size = new System.Drawing.Size(64, 46);
            this.secondsT2P2Lbl.TabIndex = 46;
            this.secondsT2P2Lbl.Text = "00";
            this.secondsT2P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.secondsT2P2Lbl, "Team 2 Player 2 seconds");
            this.secondsT2P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondsT2P2LblMouseDown);
            this.secondsT2P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SecondsT2P2LblMouseMove);
            // 
            // minutesT2P2Lbl
            // 
            this.minutesT2P2Lbl.AutoSize = true;
            this.minutesT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P2Lbl.Location = new System.Drawing.Point(941, 848);
            this.minutesT2P2Lbl.Name = "minutesT2P2Lbl";
            this.minutesT2P2Lbl.Size = new System.Drawing.Size(64, 46);
            this.minutesT2P2Lbl.TabIndex = 45;
            this.minutesT2P2Lbl.Text = "00";
            this.minutesT2P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.minutesT2P2Lbl, "Team 2 Player 2 minutes");
            this.minutesT2P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinutesT2P2LblMouseDown);
            this.minutesT2P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MinutesT2P2LblMouseMove);
            // 
            // team1Logo
            // 
            this.team1Logo.Location = new System.Drawing.Point(50, 80);
            this.team1Logo.Name = "team1Logo";
            this.team1Logo.Size = new System.Drawing.Size(280, 250);
            this.team1Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.team1Logo.TabIndex = 49;
            this.team1Logo.TabStop = false;
            this.toolTip1.SetToolTip(this.team1Logo, "Team 1 logo");
            this.team1Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Team1LogoMouseDown);
            this.team1Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Team1LogoMouseMove);
            // 
            // team2Logo
            // 
            this.team2Logo.Location = new System.Drawing.Point(937, 80);
            this.team2Logo.Name = "team2Logo";
            this.team2Logo.Size = new System.Drawing.Size(280, 250);
            this.team2Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.team2Logo.TabIndex = 50;
            this.team2Logo.TabStop = false;
            this.toolTip1.SetToolTip(this.team2Logo, "Team 2 logo");
            this.team2Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Team2LogoMouseDown);
            this.team2Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Team2LogoMouseMove);
            // 
            // timeoutL2
            // 
            this.timeoutL2.AutoSize = true;
            this.timeoutL2.Location = new System.Drawing.Point(1088, 366);
            this.timeoutL2.Name = "timeoutL2";
            this.timeoutL2.Size = new System.Drawing.Size(48, 13);
            this.timeoutL2.TabIndex = 51;
            this.timeoutL2.Text = "Timeout:";
            this.timeoutL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeoutL2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeoutL2MouseDown);
            this.timeoutL2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeoutL2MouseMove);
            // 
            // timeoutL1
            // 
            this.timeoutL1.AutoSize = true;
            this.timeoutL1.Location = new System.Drawing.Point(118, 366);
            this.timeoutL1.Name = "timeoutL1";
            this.timeoutL1.Size = new System.Drawing.Size(48, 13);
            this.timeoutL1.TabIndex = 52;
            this.timeoutL1.Text = "Timeout:";
            this.timeoutL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeoutL1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TimeoutL1MouseDown);
            this.timeoutL1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TimeoutL1MouseMove);
            // 
            // timeout2Parse
            // 
            this.timeout2Parse.AutoSize = true;
            this.timeout2Parse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout2Parse.ForeColor = System.Drawing.Color.Black;
            this.timeout2Parse.Location = new System.Drawing.Point(1106, 402);
            this.timeout2Parse.Name = "timeout2Parse";
            this.timeout2Parse.Size = new System.Drawing.Size(22, 31);
            this.timeout2Parse.TabIndex = 55;
            this.timeout2Parse.Text = ":";
            this.timeout2Parse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout2Parse, "Team 2 Timeout Separator");
            this.timeout2Parse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label3MouseDown);
            this.timeout2Parse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label3MouseMove);
            // 
            // timeout2Sec
            // 
            this.timeout2Sec.AutoSize = true;
            this.timeout2Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout2Sec.ForeColor = System.Drawing.Color.Black;
            this.timeout2Sec.Location = new System.Drawing.Point(1134, 402);
            this.timeout2Sec.Name = "timeout2Sec";
            this.timeout2Sec.Size = new System.Drawing.Size(44, 31);
            this.timeout2Sec.TabIndex = 54;
            this.timeout2Sec.Text = "00";
            this.timeout2Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout2Sec, "Team 2 Timeout Seconds");
            this.timeout2Sec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timeout2SecMouseDown);
            this.timeout2Sec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timeout2SecMouseMove);
            // 
            // timeout2Min
            // 
            this.timeout2Min.AutoSize = true;
            this.timeout2Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout2Min.ForeColor = System.Drawing.Color.Black;
            this.timeout2Min.Location = new System.Drawing.Point(1056, 402);
            this.timeout2Min.Name = "timeout2Min";
            this.timeout2Min.Size = new System.Drawing.Size(44, 31);
            this.timeout2Min.TabIndex = 53;
            this.timeout2Min.Text = "00";
            this.timeout2Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout2Min, "Team 2 Timeout Minutes");
            this.timeout2Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timeout2MinMouseDown);
            this.timeout2Min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timeout2MinMouseMove);
            // 
            // timeout1Parse
            // 
            this.timeout1Parse.AutoSize = true;
            this.timeout1Parse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout1Parse.ForeColor = System.Drawing.Color.Black;
            this.timeout1Parse.Location = new System.Drawing.Point(136, 402);
            this.timeout1Parse.Name = "timeout1Parse";
            this.timeout1Parse.Size = new System.Drawing.Size(22, 31);
            this.timeout1Parse.TabIndex = 58;
            this.timeout1Parse.Text = ":";
            this.timeout1Parse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout1Parse, "Team 1 Timeout Separator");
            this.timeout1Parse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label6MouseDown);
            this.timeout1Parse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Label6MouseMove);
            // 
            // timeout1Sec
            // 
            this.timeout1Sec.AutoSize = true;
            this.timeout1Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout1Sec.ForeColor = System.Drawing.Color.Black;
            this.timeout1Sec.Location = new System.Drawing.Point(164, 402);
            this.timeout1Sec.Name = "timeout1Sec";
            this.timeout1Sec.Size = new System.Drawing.Size(44, 31);
            this.timeout1Sec.TabIndex = 57;
            this.timeout1Sec.Text = "00";
            this.timeout1Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout1Sec, "Team 1 Timeout Seconds");
            this.timeout1Sec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timeout1SecMouseDown);
            this.timeout1Sec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timeout1SecMouseMove);
            // 
            // timeout1Min
            // 
            this.timeout1Min.AutoSize = true;
            this.timeout1Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout1Min.ForeColor = System.Drawing.Color.Black;
            this.timeout1Min.Location = new System.Drawing.Point(86, 401);
            this.timeout1Min.Name = "timeout1Min";
            this.timeout1Min.Size = new System.Drawing.Size(44, 31);
            this.timeout1Min.TabIndex = 56;
            this.timeout1Min.Text = "00";
            this.timeout1Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.timeout1Min, "Team 1 Timeout Minutes");
            this.timeout1Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Timeout1MinMouseDown);
            this.timeout1Min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Timeout1MinMouseMove);
            // 
            // faceOffsT1Lbl
            // 
            this.faceOffsT1Lbl.AutoSize = true;
            this.faceOffsT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.faceOffsT1Lbl.Location = new System.Drawing.Point(119, 551);
            this.faceOffsT1Lbl.Name = "faceOffsT1Lbl";
            this.faceOffsT1Lbl.Size = new System.Drawing.Size(51, 13);
            this.faceOffsT1Lbl.TabIndex = 59;
            this.faceOffsT1Lbl.Text = "Face-offs";
            this.faceOffsT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.faceOffsT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT1LblMouseDown);
            this.faceOffsT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT1LblMouseMove);
            // 
            // faceOffsT2Lbl
            // 
            this.faceOffsT2Lbl.AutoSize = true;
            this.faceOffsT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.faceOffsT2Lbl.Location = new System.Drawing.Point(1095, 551);
            this.faceOffsT2Lbl.Name = "faceOffsT2Lbl";
            this.faceOffsT2Lbl.Size = new System.Drawing.Size(51, 13);
            this.faceOffsT2Lbl.TabIndex = 60;
            this.faceOffsT2Lbl.Text = "Face-offs";
            this.faceOffsT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.faceOffsT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT2LblMouseDown);
            this.faceOffsT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT2LblMouseMove);
            // 
            // faceOffsT1
            // 
            this.faceOffsT1.AutoSize = true;
            this.faceOffsT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.faceOffsT1.ForeColor = System.Drawing.Color.Black;
            this.faceOffsT1.Location = new System.Drawing.Point(122, 575);
            this.faceOffsT1.Name = "faceOffsT1";
            this.faceOffsT1.Size = new System.Drawing.Size(44, 31);
            this.faceOffsT1.TabIndex = 61;
            this.faceOffsT1.Text = "00";
            this.faceOffsT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.faceOffsT1, "Team 1 FaceOffs");
            this.faceOffsT1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT1MouseDown);
            this.faceOffsT1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT1MouseMove);
            // 
            // faceOffsT2
            // 
            this.faceOffsT2.AutoSize = true;
            this.faceOffsT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.faceOffsT2.ForeColor = System.Drawing.Color.Black;
            this.faceOffsT2.Location = new System.Drawing.Point(1098, 575);
            this.faceOffsT2.Name = "faceOffsT2";
            this.faceOffsT2.Size = new System.Drawing.Size(44, 31);
            this.faceOffsT2.TabIndex = 62;
            this.faceOffsT2.Text = "00";
            this.faceOffsT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.faceOffsT2, "Team 2 FaceOffs");
            this.faceOffsT2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT2MouseDown);
            this.faceOffsT2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FaceOffsT2MouseMove);
            // 
            // shotsT1
            // 
            this.shotsT1.AutoSize = true;
            this.shotsT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shotsT1.ForeColor = System.Drawing.Color.Black;
            this.shotsT1.Location = new System.Drawing.Point(270, 661);
            this.shotsT1.Name = "shotsT1";
            this.shotsT1.Size = new System.Drawing.Size(44, 31);
            this.shotsT1.TabIndex = 64;
            this.shotsT1.Text = "00";
            this.shotsT1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.shotsT1, "Team 1 Shots");
            this.shotsT1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShotsT1MouseDown);
            this.shotsT1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShotsT1MouseMove);
            // 
            // shotsT1Lbl
            // 
            this.shotsT1Lbl.AutoSize = true;
            this.shotsT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.shotsT1Lbl.Location = new System.Drawing.Point(256, 638);
            this.shotsT1Lbl.Name = "shotsT1Lbl";
            this.shotsT1Lbl.Size = new System.Drawing.Size(72, 13);
            this.shotsT1Lbl.TabIndex = 63;
            this.shotsT1Lbl.Text = "Shots on goal";
            this.shotsT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shotsT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShotsT1LblMouseDown);
            this.shotsT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShotsT1LblMouseMove);
            // 
            // shotsT2
            // 
            this.shotsT2.AutoSize = true;
            this.shotsT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shotsT2.ForeColor = System.Drawing.Color.Black;
            this.shotsT2.Location = new System.Drawing.Point(950, 661);
            this.shotsT2.Name = "shotsT2";
            this.shotsT2.Size = new System.Drawing.Size(44, 31);
            this.shotsT2.TabIndex = 66;
            this.shotsT2.Text = "00";
            this.shotsT2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.shotsT2, "Team 2 Shots");
            this.shotsT2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShotsT2MouseDown);
            this.shotsT2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShotsT2MouseMove);
            // 
            // shotsT2Lbl
            // 
            this.shotsT2Lbl.AutoSize = true;
            this.shotsT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.shotsT2Lbl.Location = new System.Drawing.Point(936, 638);
            this.shotsT2Lbl.Name = "shotsT2Lbl";
            this.shotsT2Lbl.Size = new System.Drawing.Size(72, 13);
            this.shotsT2Lbl.TabIndex = 65;
            this.shotsT2Lbl.Text = "Shots on goal";
            this.shotsT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.shotsT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ShotsT2LblMouseDown);
            this.shotsT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShotsT2LblMouseMove);
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.shotsT2);
            this.Controls.Add(this.shotsT2Lbl);
            this.Controls.Add(this.shotsT1);
            this.Controls.Add(this.shotsT1Lbl);
            this.Controls.Add(this.faceOffsT2);
            this.Controls.Add(this.faceOffsT1);
            this.Controls.Add(this.faceOffsT2Lbl);
            this.Controls.Add(this.faceOffsT1Lbl);
            this.Controls.Add(this.timeout1Parse);
            this.Controls.Add(this.timeout1Sec);
            this.Controls.Add(this.timeout1Min);
            this.Controls.Add(this.timeout2Parse);
            this.Controls.Add(this.timeout2Sec);
            this.Controls.Add(this.timeout2Min);
            this.Controls.Add(this.timeoutL1);
            this.Controls.Add(this.timeoutL2);
            this.Controls.Add(this.team2Logo);
            this.Controls.Add(this.team1Logo);
            this.Controls.Add(this.timeT2P2ParseLbl);
            this.Controls.Add(this.secondsT2P2Lbl);
            this.Controls.Add(this.minutesT2P2Lbl);
            this.Controls.Add(this.timeT2P1ParseLbl);
            this.Controls.Add(this.secondsT2P1Lbl);
            this.Controls.Add(this.minutesT2P1Lbl);
            this.Controls.Add(this.timeT1P2ParseLbl);
            this.Controls.Add(this.secondsT1P2Lbl);
            this.Controls.Add(this.minutesT1P2Lbl);
            this.Controls.Add(this.timeT1P1ParseLbl);
            this.Controls.Add(this.secondsT1P1Lbl);
            this.Controls.Add(this.minutesT1P1Lbl);
            this.Controls.Add(this.playerNumber2T2lbl);
            this.Controls.Add(this.playerNumber2T1lbl);
            this.Controls.Add(this.playerNumber1T2lbl);
            this.Controls.Add(this.playerNumber1T1lbl);
            this.Controls.Add(this.penaltyT2TimeLbl);
            this.Controls.Add(this.penaltyT2PlayerLbl);
            this.Controls.Add(this.penaltyT2Lbl);
            this.Controls.Add(this.penaltyT1TimeLbl);
            this.Controls.Add(this.penaltyT1PlayerLbl);
            this.Controls.Add(this.penaltyT1Lbl);
            this.Controls.Add(this.timeLbl);
            this.Controls.Add(this.actualPeriodLbl);
            this.Controls.Add(this.timeSecondsLbl);
            this.Controls.Add(this.timeParseLbl);
            this.Controls.Add(this.timeMinutesLbl);
            this.Controls.Add(this.periodLbl);
            this.Controls.Add(this.scoreParseLblb);
            this.Controls.Add(this.scoreT2Lbl);
            this.Controls.Add(this.scoreT1Lbl);
            this.Controls.Add(this.t2Lbl);
            this.Controls.Add(this.t1Lbl);
            this.Name = "ScoreboardForm";
            this.Text = "ScoreboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.team1Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label t1Lbl;
        private Label t2Lbl;
        private Label scoreT1Lbl;
        private Label scoreT2Lbl;
        private Label scoreParseLblb;
        private Label periodLbl;
        private Label timeMinutesLbl;
        private Label timeParseLbl;
        private Label timeSecondsLbl;
        private Label actualPeriodLbl;
        private Label timeLbl;
        private Label penaltyT1Lbl;
        private Label penaltyT1PlayerLbl;
        private Label penaltyT1TimeLbl;
        private Label penaltyT2TimeLbl;
        private Label penaltyT2PlayerLbl;
        private Label penaltyT2Lbl;
        private Label playerNumber1T1lbl;
        private Label playerNumber1T2lbl;
        private Label playerNumber2T1lbl;
        private Label playerNumber2T2lbl;
        private Label minutesT1P1Lbl;
        private Label secondsT1P1Lbl;
        private Label timeT1P1ParseLbl;
        private Label timeT1P2ParseLbl;
        private Label secondsT1P2Lbl;
        private Label minutesT1P2Lbl;
        private Label timeT2P1ParseLbl;
        private Label secondsT2P1Lbl;
        private Label minutesT2P1Lbl;
        private Label timeT2P2ParseLbl;
        private Label secondsT2P2Lbl;
        private Label minutesT2P2Lbl;
        private PictureBox team1Logo;
        private PictureBox team2Logo;
        private Label timeoutL2;
        private Label timeoutL1;
        private Label timeout2Parse;
        private Label timeout2Sec;
        private Label timeout2Min;
        private Label timeout1Parse;
        private Label timeout1Sec;
        private Label timeout1Min;
        private Label faceOffsT1Lbl;
        private Label faceOffsT2Lbl;
        private Label faceOffsT1;
        private Label faceOffsT2;
        private Label shotsT1;
        private Label shotsT1Lbl;
        private Label shotsT2;
        private Label shotsT2Lbl;
        private ToolTip toolTip1;
    }
}