﻿namespace Scoreboard.Forms.MainGameForms
{
    partial class ScoreboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label3 = new System.Windows.Forms.Label();
            this.timeout2Sec = new System.Windows.Forms.Label();
            this.timeout2Min = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeout1Sec = new System.Windows.Forms.Label();
            this.timeout1Min = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.team1Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // t1Lbl
            // 
            this.t1Lbl.ForeColor = System.Drawing.Color.Black;
            this.t1Lbl.Location = new System.Drawing.Point(438, 83);
            this.t1Lbl.Name = "t1Lbl";
            this.t1Lbl.Size = new System.Drawing.Size(123, 13);
            this.t1Lbl.TabIndex = 2;
            this.t1Lbl.Text = "Team1";
            this.t1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.t1Lbl_MouseDown);
            this.t1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.t1Lbl_MouseMove);
            // 
            // t2Lbl
            // 
            this.t2Lbl.ForeColor = System.Drawing.Color.Black;
            this.t2Lbl.Location = new System.Drawing.Point(687, 83);
            this.t2Lbl.Name = "t2Lbl";
            this.t2Lbl.Size = new System.Drawing.Size(128, 13);
            this.t2Lbl.TabIndex = 3;
            this.t2Lbl.Text = "Team2";
            this.t2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.t2Lbl_MouseDown);
            this.t2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.t2Lbl_MouseMove);
            // 
            // scoreT1Lbl
            // 
            this.scoreT1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT1Lbl.Location = new System.Drawing.Point(450, 126);
            this.scoreT1Lbl.Name = "scoreT1Lbl";
            this.scoreT1Lbl.Size = new System.Drawing.Size(111, 76);
            this.scoreT1Lbl.TabIndex = 4;
            this.scoreT1Lbl.Text = "00";
            this.scoreT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scoreT1Lbl_MouseDown);
            this.scoreT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scoreT1Lbl_MouseMove);
            // 
            // scoreT2Lbl
            // 
            this.scoreT2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT2Lbl.Location = new System.Drawing.Point(706, 124);
            this.scoreT2Lbl.Name = "scoreT2Lbl";
            this.scoreT2Lbl.Size = new System.Drawing.Size(107, 72);
            this.scoreT2Lbl.TabIndex = 5;
            this.scoreT2Lbl.Text = "00";
            this.scoreT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scoreT2Lbl_MouseDown);
            this.scoreT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scoreT2Lbl_MouseMove);
            // 
            // scoreParseLblb
            // 
            this.scoreParseLblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreParseLblb.ForeColor = System.Drawing.Color.Black;
            this.scoreParseLblb.Location = new System.Drawing.Point(617, 126);
            this.scoreParseLblb.Name = "scoreParseLblb";
            this.scoreParseLblb.Size = new System.Drawing.Size(40, 72);
            this.scoreParseLblb.TabIndex = 6;
            this.scoreParseLblb.Text = "-";
            this.scoreParseLblb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scoreParseLblb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scoreParseLblb_MouseDown);
            this.scoreParseLblb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scoreParseLblb_MouseMove);
            // 
            // periodLbl
            // 
            this.periodLbl.ForeColor = System.Drawing.Color.Black;
            this.periodLbl.Location = new System.Drawing.Point(616, 230);
            this.periodLbl.Name = "periodLbl";
            this.periodLbl.Size = new System.Drawing.Size(37, 13);
            this.periodLbl.TabIndex = 7;
            this.periodLbl.Text = "Period";
            this.periodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.periodLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.periodLbl_MouseDown);
            this.periodLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.periodLbl_MouseMove);
            // 
            // timeMinutesLbl
            // 
            this.timeMinutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeMinutesLbl.ForeColor = System.Drawing.Color.Black;
            this.timeMinutesLbl.Location = new System.Drawing.Point(480, 376);
            this.timeMinutesLbl.Name = "timeMinutesLbl";
            this.timeMinutesLbl.Size = new System.Drawing.Size(108, 76);
            this.timeMinutesLbl.TabIndex = 8;
            this.timeMinutesLbl.Text = "00";
            this.timeMinutesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeMinutesLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeMinutesLbl_MouseDown);
            this.timeMinutesLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeMinutesLbl_MouseMove);
            // 
            // timeParseLbl
            // 
            this.timeParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeParseLbl.Location = new System.Drawing.Point(617, 376);
            this.timeParseLbl.Name = "timeParseLbl";
            this.timeParseLbl.Size = new System.Drawing.Size(36, 76);
            this.timeParseLbl.TabIndex = 9;
            this.timeParseLbl.Text = ":";
            this.timeParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeParseLbl_MouseDown);
            this.timeParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeParseLbl_MouseMove);
            // 
            // timeSecondsLbl
            // 
            this.timeSecondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeSecondsLbl.ForeColor = System.Drawing.Color.Black;
            this.timeSecondsLbl.Location = new System.Drawing.Point(677, 376);
            this.timeSecondsLbl.Name = "timeSecondsLbl";
            this.timeSecondsLbl.Size = new System.Drawing.Size(110, 76);
            this.timeSecondsLbl.TabIndex = 10;
            this.timeSecondsLbl.Text = "00";
            this.timeSecondsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeSecondsLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeSecondsLbl_MouseDown);
            this.timeSecondsLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeSecondsLbl_MouseMove);
            // 
            // actualPeriodLbl
            // 
            this.actualPeriodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualPeriodLbl.ForeColor = System.Drawing.Color.Black;
            this.actualPeriodLbl.Location = new System.Drawing.Point(602, 257);
            this.actualPeriodLbl.Name = "actualPeriodLbl";
            this.actualPeriodLbl.Size = new System.Drawing.Size(64, 46);
            this.actualPeriodLbl.TabIndex = 11;
            this.actualPeriodLbl.Text = "00";
            this.actualPeriodLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.actualPeriodLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.actualPeriodLbl_MouseMove);
            // 
            // timeLbl
            // 
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(616, 343);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 13);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            this.timeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseDown);
            this.timeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeLbl_MouseMove);
            // 
            // penaltyT1Lbl
            // 
            this.penaltyT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1Lbl.Location = new System.Drawing.Point(196, 729);
            this.penaltyT1Lbl.Name = "penaltyT1Lbl";
            this.penaltyT1Lbl.Size = new System.Drawing.Size(42, 13);
            this.penaltyT1Lbl.TabIndex = 14;
            this.penaltyT1Lbl.Text = "Penalty";
            this.penaltyT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT1Lbl_MouseDown);
            this.penaltyT1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT1Lbl_MouseMove);
            // 
            // penaltyT1PlayerLbl
            // 
            this.penaltyT1PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1PlayerLbl.Location = new System.Drawing.Point(130, 748);
            this.penaltyT1PlayerLbl.Name = "penaltyT1PlayerLbl";
            this.penaltyT1PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT1PlayerLbl.TabIndex = 15;
            this.penaltyT1PlayerLbl.Text = "Player";
            this.penaltyT1PlayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1PlayerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT1PlayerLbl_MouseDown);
            this.penaltyT1PlayerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT1PlayerLbl_MouseMove);
            // 
            // penaltyT1TimeLbl
            // 
            this.penaltyT1TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1TimeLbl.Location = new System.Drawing.Point(252, 748);
            this.penaltyT1TimeLbl.Name = "penaltyT1TimeLbl";
            this.penaltyT1TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT1TimeLbl.TabIndex = 16;
            this.penaltyT1TimeLbl.Text = "Time";
            this.penaltyT1TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT1TimeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT1TimeLbl_MouseDown);
            this.penaltyT1TimeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT1TimeLbl_MouseMove);
            // 
            // penaltyT2TimeLbl
            // 
            this.penaltyT2TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2TimeLbl.Location = new System.Drawing.Point(1056, 748);
            this.penaltyT2TimeLbl.Name = "penaltyT2TimeLbl";
            this.penaltyT2TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT2TimeLbl.TabIndex = 19;
            this.penaltyT2TimeLbl.Text = "Time";
            this.penaltyT2TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2TimeLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT2TimeLbl_MouseDown);
            this.penaltyT2TimeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT2TimeLbl_MouseMove);
            // 
            // penaltyT2PlayerLbl
            // 
            this.penaltyT2PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2PlayerLbl.Location = new System.Drawing.Point(934, 748);
            this.penaltyT2PlayerLbl.Name = "penaltyT2PlayerLbl";
            this.penaltyT2PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT2PlayerLbl.TabIndex = 18;
            this.penaltyT2PlayerLbl.Text = "Player";
            this.penaltyT2PlayerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2PlayerLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT2PlayerLbl_MouseDown);
            this.penaltyT2PlayerLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT2PlayerLbl_MouseMove);
            // 
            // penaltyT2Lbl
            // 
            this.penaltyT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2Lbl.Location = new System.Drawing.Point(1000, 729);
            this.penaltyT2Lbl.Name = "penaltyT2Lbl";
            this.penaltyT2Lbl.Size = new System.Drawing.Size(42, 13);
            this.penaltyT2Lbl.TabIndex = 17;
            this.penaltyT2Lbl.Text = "Penalty";
            this.penaltyT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.penaltyT2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.penaltyT2Lbl_MouseDown);
            this.penaltyT2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.penaltyT2Lbl_MouseMove);
            // 
            // playerNumber1T1lbl
            // 
            this.playerNumber1T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T1lbl.Location = new System.Drawing.Point(105, 770);
            this.playerNumber1T1lbl.Name = "playerNumber1T1lbl";
            this.playerNumber1T1lbl.Size = new System.Drawing.Size(49, 31);
            this.playerNumber1T1lbl.TabIndex = 20;
            this.playerNumber1T1lbl.Text = "00";
            this.playerNumber1T1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNumber1T1lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerNumber1T1lbl_MouseDown);
            this.playerNumber1T1lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerNumber1T1lbl_MouseMove);
            // 
            // playerNumber1T2lbl
            // 
            this.playerNumber1T2lbl.AutoSize = true;
            this.playerNumber1T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T2lbl.Location = new System.Drawing.Point(915, 770);
            this.playerNumber1T2lbl.Name = "playerNumber1T2lbl";
            this.playerNumber1T2lbl.Size = new System.Drawing.Size(44, 31);
            this.playerNumber1T2lbl.TabIndex = 21;
            this.playerNumber1T2lbl.Text = "00";
            this.playerNumber1T2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNumber1T2lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerNumber1T2lbl_MouseDown);
            this.playerNumber1T2lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerNumber1T2lbl_MouseMove);
            // 
            // playerNumber2T1lbl
            // 
            this.playerNumber2T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T1lbl.Location = new System.Drawing.Point(105, 810);
            this.playerNumber2T1lbl.Name = "playerNumber2T1lbl";
            this.playerNumber2T1lbl.Size = new System.Drawing.Size(49, 31);
            this.playerNumber2T1lbl.TabIndex = 22;
            this.playerNumber2T1lbl.Text = "00";
            this.playerNumber2T1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNumber2T1lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerNumber2T1lbl_MouseDown);
            this.playerNumber2T1lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerNumber2T1lbl_MouseMove);
            // 
            // playerNumber2T2lbl
            // 
            this.playerNumber2T2lbl.AutoSize = true;
            this.playerNumber2T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T2lbl.Location = new System.Drawing.Point(915, 810);
            this.playerNumber2T2lbl.Name = "playerNumber2T2lbl";
            this.playerNumber2T2lbl.Size = new System.Drawing.Size(44, 31);
            this.playerNumber2T2lbl.TabIndex = 23;
            this.playerNumber2T2lbl.Text = "00";
            this.playerNumber2T2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playerNumber2T2lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playerNumber2T2lbl_MouseDown);
            this.playerNumber2T2lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.playerNumber2T2lbl_MouseMove);
            // 
            // minutesT1P1Lbl
            // 
            this.minutesT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P1Lbl.Location = new System.Drawing.Point(199, 770);
            this.minutesT1P1Lbl.Name = "minutesT1P1Lbl";
            this.minutesT1P1Lbl.Size = new System.Drawing.Size(53, 31);
            this.minutesT1P1Lbl.TabIndex = 24;
            this.minutesT1P1Lbl.Text = "00";
            this.minutesT1P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minutesT1P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minutesT1P1Lbl_MouseDown);
            this.minutesT1P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minutesT1P1Lbl_MouseMove);
            // 
            // secondsT1P1Lbl
            // 
            this.secondsT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P1Lbl.Location = new System.Drawing.Point(286, 770);
            this.secondsT1P1Lbl.Name = "secondsT1P1Lbl";
            this.secondsT1P1Lbl.Size = new System.Drawing.Size(47, 31);
            this.secondsT1P1Lbl.TabIndex = 28;
            this.secondsT1P1Lbl.Text = "00";
            this.secondsT1P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondsT1P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondsT1P1Lbl_MouseDown);
            this.secondsT1P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secondsT1P1Lbl_MouseMove);
            // 
            // timeT1P1ParseLbl
            // 
            this.timeT1P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P1ParseLbl.Location = new System.Drawing.Point(258, 770);
            this.timeT1P1ParseLbl.Name = "timeT1P1ParseLbl";
            this.timeT1P1ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT1P1ParseLbl.TabIndex = 36;
            this.timeT1P1ParseLbl.Text = ":";
            this.timeT1P1ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeT1P1ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeT1P1ParseLbl_MouseDown);
            this.timeT1P1ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeT1P1ParseLbl_MouseMove);
            // 
            // timeT1P2ParseLbl
            // 
            this.timeT1P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P2ParseLbl.Location = new System.Drawing.Point(258, 810);
            this.timeT1P2ParseLbl.Name = "timeT1P2ParseLbl";
            this.timeT1P2ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT1P2ParseLbl.TabIndex = 40;
            this.timeT1P2ParseLbl.Text = ":";
            this.timeT1P2ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeT1P2ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeT1P2ParseLbl_MouseDown);
            this.timeT1P2ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeT1P2ParseLbl_MouseMove);
            // 
            // secondsT1P2Lbl
            // 
            this.secondsT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P2Lbl.Location = new System.Drawing.Point(286, 810);
            this.secondsT1P2Lbl.Name = "secondsT1P2Lbl";
            this.secondsT1P2Lbl.Size = new System.Drawing.Size(47, 31);
            this.secondsT1P2Lbl.TabIndex = 38;
            this.secondsT1P2Lbl.Text = "00";
            this.secondsT1P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondsT1P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondsT1P2Lbl_MouseDown);
            this.secondsT1P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secondsT1P2Lbl_MouseMove);
            // 
            // minutesT1P2Lbl
            // 
            this.minutesT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P2Lbl.Location = new System.Drawing.Point(199, 810);
            this.minutesT1P2Lbl.Name = "minutesT1P2Lbl";
            this.minutesT1P2Lbl.Size = new System.Drawing.Size(53, 31);
            this.minutesT1P2Lbl.TabIndex = 37;
            this.minutesT1P2Lbl.Text = "00";
            this.minutesT1P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minutesT1P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minutesT1P2Lbl_MouseDown);
            this.minutesT1P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minutesT1P2Lbl_MouseMove);
            // 
            // timeT2P1ParseLbl
            // 
            this.timeT2P1ParseLbl.AutoSize = true;
            this.timeT2P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P1ParseLbl.Location = new System.Drawing.Point(1074, 770);
            this.timeT2P1ParseLbl.Name = "timeT2P1ParseLbl";
            this.timeT2P1ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT2P1ParseLbl.TabIndex = 44;
            this.timeT2P1ParseLbl.Text = ":";
            this.timeT2P1ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeT2P1ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeT2P1ParseLbl_MouseDown);
            this.timeT2P1ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeT2P1ParseLbl_MouseMove);
            // 
            // secondsT2P1Lbl
            // 
            this.secondsT2P1Lbl.AutoSize = true;
            this.secondsT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P1Lbl.Location = new System.Drawing.Point(1102, 770);
            this.secondsT2P1Lbl.Name = "secondsT2P1Lbl";
            this.secondsT2P1Lbl.Size = new System.Drawing.Size(44, 31);
            this.secondsT2P1Lbl.TabIndex = 42;
            this.secondsT2P1Lbl.Text = "00";
            this.secondsT2P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondsT2P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondsT2P1Lbl_MouseDown);
            this.secondsT2P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secondsT2P1Lbl_MouseMove);
            // 
            // minutesT2P1Lbl
            // 
            this.minutesT2P1Lbl.AutoSize = true;
            this.minutesT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P1Lbl.Location = new System.Drawing.Point(1019, 770);
            this.minutesT2P1Lbl.Name = "minutesT2P1Lbl";
            this.minutesT2P1Lbl.Size = new System.Drawing.Size(44, 31);
            this.minutesT2P1Lbl.TabIndex = 41;
            this.minutesT2P1Lbl.Text = "00";
            this.minutesT2P1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minutesT2P1Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minutesT2P1Lbl_MouseDown);
            this.minutesT2P1Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minutesT2P1Lbl_MouseMove);
            // 
            // timeT2P2ParseLbl
            // 
            this.timeT2P2ParseLbl.AutoSize = true;
            this.timeT2P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P2ParseLbl.Location = new System.Drawing.Point(1074, 810);
            this.timeT2P2ParseLbl.Name = "timeT2P2ParseLbl";
            this.timeT2P2ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT2P2ParseLbl.TabIndex = 48;
            this.timeT2P2ParseLbl.Text = ":";
            this.timeT2P2ParseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeT2P2ParseLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeT2P2ParseLbl_MouseDown);
            this.timeT2P2ParseLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeT2P2ParseLbl_MouseMove);
            // 
            // secondsT2P2Lbl
            // 
            this.secondsT2P2Lbl.AutoSize = true;
            this.secondsT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P2Lbl.Location = new System.Drawing.Point(1102, 810);
            this.secondsT2P2Lbl.Name = "secondsT2P2Lbl";
            this.secondsT2P2Lbl.Size = new System.Drawing.Size(44, 31);
            this.secondsT2P2Lbl.TabIndex = 46;
            this.secondsT2P2Lbl.Text = "00";
            this.secondsT2P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.secondsT2P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondsT2P2Lbl_MouseDown);
            this.secondsT2P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secondsT2P2Lbl_MouseMove);
            // 
            // minutesT2P2Lbl
            // 
            this.minutesT2P2Lbl.AutoSize = true;
            this.minutesT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P2Lbl.Location = new System.Drawing.Point(1019, 810);
            this.minutesT2P2Lbl.Name = "minutesT2P2Lbl";
            this.minutesT2P2Lbl.Size = new System.Drawing.Size(44, 31);
            this.minutesT2P2Lbl.TabIndex = 45;
            this.minutesT2P2Lbl.Text = "00";
            this.minutesT2P2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minutesT2P2Lbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.minutesT2P2Lbl_MouseDown);
            this.minutesT2P2Lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minutesT2P2Lbl_MouseMove);
            // 
            // team1Logo
            // 
            this.team1Logo.Location = new System.Drawing.Point(50, 80);
            this.team1Logo.Name = "team1Logo";
            this.team1Logo.Size = new System.Drawing.Size(280, 250);
            this.team1Logo.TabIndex = 49;
            this.team1Logo.TabStop = false;
            this.team1Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.team1Logo_MouseDown);
            this.team1Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.team1Logo_MouseMove);
            // 
            // team2Logo
            // 
            this.team2Logo.Location = new System.Drawing.Point(937, 80);
            this.team2Logo.Name = "team2Logo";
            this.team2Logo.Size = new System.Drawing.Size(280, 250);
            this.team2Logo.TabIndex = 50;
            this.team2Logo.TabStop = false;
            this.team2Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.team2Logo_MouseDown);
            this.team2Logo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.team2Logo_MouseMove);
            // 
            // timeoutL2
            // 
            this.timeoutL2.AutoSize = true;
            this.timeoutL2.Location = new System.Drawing.Point(1098, 424);
            this.timeoutL2.Name = "timeoutL2";
            this.timeoutL2.Size = new System.Drawing.Size(48, 13);
            this.timeoutL2.TabIndex = 51;
            this.timeoutL2.Text = "Timeout:";
            this.timeoutL2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeoutL2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeoutL2_MouseDown);
            this.timeoutL2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeoutL2_MouseMove);
            // 
            // timeoutL1
            // 
            this.timeoutL1.AutoSize = true;
            this.timeoutL1.Location = new System.Drawing.Point(130, 424);
            this.timeoutL1.Name = "timeoutL1";
            this.timeoutL1.Size = new System.Drawing.Size(48, 13);
            this.timeoutL1.TabIndex = 52;
            this.timeoutL1.Text = "Timeout:";
            this.timeoutL1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeoutL1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeoutL1_MouseDown);
            this.timeoutL1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeoutL1_MouseMove);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1111, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = ":";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // timeout2Sec
            // 
            this.timeout2Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout2Sec.ForeColor = System.Drawing.Color.Black;
            this.timeout2Sec.Location = new System.Drawing.Point(1139, 460);
            this.timeout2Sec.Name = "timeout2Sec";
            this.timeout2Sec.Size = new System.Drawing.Size(48, 31);
            this.timeout2Sec.TabIndex = 54;
            this.timeout2Sec.Text = "00";
            this.timeout2Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeout2Sec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeout2Sec_MouseDown);
            this.timeout2Sec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeout2Sec_MouseMove);
            // 
            // timeout2Min
            // 
            this.timeout2Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout2Min.ForeColor = System.Drawing.Color.Black;
            this.timeout2Min.Location = new System.Drawing.Point(1056, 460);
            this.timeout2Min.Name = "timeout2Min";
            this.timeout2Min.Size = new System.Drawing.Size(49, 31);
            this.timeout2Min.TabIndex = 53;
            this.timeout2Min.Text = "00";
            this.timeout2Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeout2Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeout2Min_MouseDown);
            this.timeout2Min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeout2Min_MouseMove);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(139, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 31);
            this.label6.TabIndex = 58;
            this.label6.Text = ":";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label6_MouseMove);
            // 
            // timeout1Sec
            // 
            this.timeout1Sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout1Sec.ForeColor = System.Drawing.Color.Black;
            this.timeout1Sec.Location = new System.Drawing.Point(167, 460);
            this.timeout1Sec.Name = "timeout1Sec";
            this.timeout1Sec.Size = new System.Drawing.Size(48, 31);
            this.timeout1Sec.TabIndex = 57;
            this.timeout1Sec.Text = "00";
            this.timeout1Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeout1Sec.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeout1Sec_MouseDown);
            this.timeout1Sec.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeout1Sec_MouseMove);
            // 
            // timeout1Min
            // 
            this.timeout1Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeout1Min.ForeColor = System.Drawing.Color.Black;
            this.timeout1Min.Location = new System.Drawing.Point(84, 460);
            this.timeout1Min.Name = "timeout1Min";
            this.timeout1Min.Size = new System.Drawing.Size(49, 31);
            this.timeout1Min.TabIndex = 56;
            this.timeout1Min.Text = "00";
            this.timeout1Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeout1Min.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timeout1Min_MouseDown);
            this.timeout1Min.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timeout1Min_MouseMove);
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timeout1Sec);
            this.Controls.Add(this.timeout1Min);
            this.Controls.Add(this.label3);
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
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ScoreboardForm";
            this.Text = "ScoreboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.team1Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label t1Lbl;
        private System.Windows.Forms.Label t2Lbl;
        private System.Windows.Forms.Label scoreT1Lbl;
        private System.Windows.Forms.Label scoreT2Lbl;
        private System.Windows.Forms.Label scoreParseLblb;
        private System.Windows.Forms.Label periodLbl;
        private System.Windows.Forms.Label timeMinutesLbl;
        private System.Windows.Forms.Label timeParseLbl;
        private System.Windows.Forms.Label timeSecondsLbl;
        private System.Windows.Forms.Label actualPeriodLbl;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.Label penaltyT1Lbl;
        private System.Windows.Forms.Label penaltyT1PlayerLbl;
        private System.Windows.Forms.Label penaltyT1TimeLbl;
        private System.Windows.Forms.Label penaltyT2TimeLbl;
        private System.Windows.Forms.Label penaltyT2PlayerLbl;
        private System.Windows.Forms.Label penaltyT2Lbl;
        private System.Windows.Forms.Label playerNumber1T1lbl;
        private System.Windows.Forms.Label playerNumber1T2lbl;
        private System.Windows.Forms.Label playerNumber2T1lbl;
        private System.Windows.Forms.Label playerNumber2T2lbl;
        private System.Windows.Forms.Label minutesT1P1Lbl;
        private System.Windows.Forms.Label secondsT1P1Lbl;
        private System.Windows.Forms.Label timeT1P1ParseLbl;
        private System.Windows.Forms.Label timeT1P2ParseLbl;
        private System.Windows.Forms.Label secondsT1P2Lbl;
        private System.Windows.Forms.Label minutesT1P2Lbl;
        private System.Windows.Forms.Label timeT2P1ParseLbl;
        private System.Windows.Forms.Label secondsT2P1Lbl;
        private System.Windows.Forms.Label minutesT2P1Lbl;
        private System.Windows.Forms.Label timeT2P2ParseLbl;
        private System.Windows.Forms.Label secondsT2P2Lbl;
        private System.Windows.Forms.Label minutesT2P2Lbl;
        private System.Windows.Forms.PictureBox team1Logo;
        private System.Windows.Forms.PictureBox team2Logo;
        private System.Windows.Forms.Label timeoutL2;
        private System.Windows.Forms.Label timeoutL1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeout2Sec;
        private System.Windows.Forms.Label timeout2Min;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label timeout1Sec;
        private System.Windows.Forms.Label timeout1Min;
    }
}