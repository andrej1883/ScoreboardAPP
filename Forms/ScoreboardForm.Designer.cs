namespace Scoreboard.Forms
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
            ((System.ComponentModel.ISupportInitialize)(this.team1Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.team2Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // t1Lbl
            // 
            this.t1Lbl.AutoSize = true;
            this.t1Lbl.ForeColor = System.Drawing.Color.Black;
            this.t1Lbl.Location = new System.Drawing.Point(309, 23);
            this.t1Lbl.Name = "t1Lbl";
            this.t1Lbl.Size = new System.Drawing.Size(40, 13);
            this.t1Lbl.TabIndex = 2;
            this.t1Lbl.Text = "Team1";
            // 
            // t2Lbl
            // 
            this.t2Lbl.AutoSize = true;
            this.t2Lbl.ForeColor = System.Drawing.Color.Black;
            this.t2Lbl.Location = new System.Drawing.Point(444, 23);
            this.t2Lbl.Name = "t2Lbl";
            this.t2Lbl.Size = new System.Drawing.Size(40, 13);
            this.t2Lbl.TabIndex = 3;
            this.t2Lbl.Text = "Team2";
            // 
            // scoreT1Lbl
            // 
            this.scoreT1Lbl.AutoSize = true;
            this.scoreT1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT1Lbl.Location = new System.Drawing.Point(262, 51);
            this.scoreT1Lbl.Name = "scoreT1Lbl";
            this.scoreT1Lbl.Size = new System.Drawing.Size(106, 76);
            this.scoreT1Lbl.TabIndex = 4;
            this.scoreT1Lbl.Text = "00";
            this.scoreT1Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreT2Lbl
            // 
            this.scoreT2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.scoreT2Lbl.Location = new System.Drawing.Point(431, 43);
            this.scoreT2Lbl.Name = "scoreT2Lbl";
            this.scoreT2Lbl.Size = new System.Drawing.Size(119, 92);
            this.scoreT2Lbl.TabIndex = 5;
            this.scoreT2Lbl.Text = "00";
            this.scoreT2Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreParseLblb
            // 
            this.scoreParseLblb.AutoSize = true;
            this.scoreParseLblb.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreParseLblb.ForeColor = System.Drawing.Color.Black;
            this.scoreParseLblb.Location = new System.Drawing.Point(374, 51);
            this.scoreParseLblb.Name = "scoreParseLblb";
            this.scoreParseLblb.Size = new System.Drawing.Size(54, 76);
            this.scoreParseLblb.TabIndex = 6;
            this.scoreParseLblb.Text = "-";
            // 
            // periodLbl
            // 
            this.periodLbl.AutoSize = true;
            this.periodLbl.ForeColor = System.Drawing.Color.Black;
            this.periodLbl.Location = new System.Drawing.Point(384, 130);
            this.periodLbl.Name = "periodLbl";
            this.periodLbl.Size = new System.Drawing.Size(37, 13);
            this.periodLbl.TabIndex = 7;
            this.periodLbl.Text = "Period";
            // 
            // timeMinutesLbl
            // 
            this.timeMinutesLbl.AutoSize = true;
            this.timeMinutesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeMinutesLbl.ForeColor = System.Drawing.Color.Black;
            this.timeMinutesLbl.Location = new System.Drawing.Point(262, 228);
            this.timeMinutesLbl.Name = "timeMinutesLbl";
            this.timeMinutesLbl.Size = new System.Drawing.Size(106, 76);
            this.timeMinutesLbl.TabIndex = 8;
            this.timeMinutesLbl.Text = "00";
            // 
            // timeParseLbl
            // 
            this.timeParseLbl.AutoSize = true;
            this.timeParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeParseLbl.Location = new System.Drawing.Point(374, 228);
            this.timeParseLbl.Name = "timeParseLbl";
            this.timeParseLbl.Size = new System.Drawing.Size(51, 76);
            this.timeParseLbl.TabIndex = 9;
            this.timeParseLbl.Text = ":";
            // 
            // timeSecondsLbl
            // 
            this.timeSecondsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeSecondsLbl.AutoSize = true;
            this.timeSecondsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeSecondsLbl.ForeColor = System.Drawing.Color.Black;
            this.timeSecondsLbl.Location = new System.Drawing.Point(431, 228);
            this.timeSecondsLbl.Name = "timeSecondsLbl";
            this.timeSecondsLbl.Size = new System.Drawing.Size(106, 76);
            this.timeSecondsLbl.TabIndex = 10;
            this.timeSecondsLbl.Text = "00";
            // 
            // actualPeriodLbl
            // 
            this.actualPeriodLbl.AutoSize = true;
            this.actualPeriodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.actualPeriodLbl.ForeColor = System.Drawing.Color.Black;
            this.actualPeriodLbl.Location = new System.Drawing.Point(379, 154);
            this.actualPeriodLbl.Name = "actualPeriodLbl";
            this.actualPeriodLbl.Size = new System.Drawing.Size(42, 46);
            this.actualPeriodLbl.TabIndex = 11;
            this.actualPeriodLbl.Text = "1";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.ForeColor = System.Drawing.Color.Black;
            this.timeLbl.Location = new System.Drawing.Point(384, 215);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(30, 13);
            this.timeLbl.TabIndex = 12;
            this.timeLbl.Text = "Time";
            // 
            // penaltyT1Lbl
            // 
            this.penaltyT1Lbl.AutoSize = true;
            this.penaltyT1Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1Lbl.Location = new System.Drawing.Point(100, 306);
            this.penaltyT1Lbl.Name = "penaltyT1Lbl";
            this.penaltyT1Lbl.Size = new System.Drawing.Size(42, 13);
            this.penaltyT1Lbl.TabIndex = 14;
            this.penaltyT1Lbl.Text = "Penalty";
            // 
            // penaltyT1PlayerLbl
            // 
            this.penaltyT1PlayerLbl.AutoSize = true;
            this.penaltyT1PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1PlayerLbl.Location = new System.Drawing.Point(34, 325);
            this.penaltyT1PlayerLbl.Name = "penaltyT1PlayerLbl";
            this.penaltyT1PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT1PlayerLbl.TabIndex = 15;
            this.penaltyT1PlayerLbl.Text = "Player";
            // 
            // penaltyT1TimeLbl
            // 
            this.penaltyT1TimeLbl.AutoSize = true;
            this.penaltyT1TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT1TimeLbl.Location = new System.Drawing.Point(156, 325);
            this.penaltyT1TimeLbl.Name = "penaltyT1TimeLbl";
            this.penaltyT1TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT1TimeLbl.TabIndex = 16;
            this.penaltyT1TimeLbl.Text = "Time";
            // 
            // penaltyT2TimeLbl
            // 
            this.penaltyT2TimeLbl.AutoSize = true;
            this.penaltyT2TimeLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2TimeLbl.Location = new System.Drawing.Point(698, 325);
            this.penaltyT2TimeLbl.Name = "penaltyT2TimeLbl";
            this.penaltyT2TimeLbl.Size = new System.Drawing.Size(30, 13);
            this.penaltyT2TimeLbl.TabIndex = 19;
            this.penaltyT2TimeLbl.Text = "Time";
            // 
            // penaltyT2PlayerLbl
            // 
            this.penaltyT2PlayerLbl.AutoSize = true;
            this.penaltyT2PlayerLbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2PlayerLbl.Location = new System.Drawing.Point(576, 325);
            this.penaltyT2PlayerLbl.Name = "penaltyT2PlayerLbl";
            this.penaltyT2PlayerLbl.Size = new System.Drawing.Size(36, 13);
            this.penaltyT2PlayerLbl.TabIndex = 18;
            this.penaltyT2PlayerLbl.Text = "Player";
            // 
            // penaltyT2Lbl
            // 
            this.penaltyT2Lbl.AutoSize = true;
            this.penaltyT2Lbl.ForeColor = System.Drawing.Color.Black;
            this.penaltyT2Lbl.Location = new System.Drawing.Point(642, 306);
            this.penaltyT2Lbl.Name = "penaltyT2Lbl";
            this.penaltyT2Lbl.Size = new System.Drawing.Size(42, 13);
            this.penaltyT2Lbl.TabIndex = 17;
            this.penaltyT2Lbl.Text = "Penalty";
            // 
            // playerNumber1T1lbl
            // 
            this.playerNumber1T1lbl.AutoSize = true;
            this.playerNumber1T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T1lbl.Location = new System.Drawing.Point(29, 347);
            this.playerNumber1T1lbl.Name = "playerNumber1T1lbl";
            this.playerNumber1T1lbl.Size = new System.Drawing.Size(29, 31);
            this.playerNumber1T1lbl.TabIndex = 20;
            this.playerNumber1T1lbl.Text = "1";
            // 
            // playerNumber1T2lbl
            // 
            this.playerNumber1T2lbl.AutoSize = true;
            this.playerNumber1T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber1T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber1T2lbl.Location = new System.Drawing.Point(573, 347);
            this.playerNumber1T2lbl.Name = "playerNumber1T2lbl";
            this.playerNumber1T2lbl.Size = new System.Drawing.Size(29, 31);
            this.playerNumber1T2lbl.TabIndex = 21;
            this.playerNumber1T2lbl.Text = "1";
            // 
            // playerNumber2T1lbl
            // 
            this.playerNumber2T1lbl.AutoSize = true;
            this.playerNumber2T1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T1lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T1lbl.Location = new System.Drawing.Point(29, 387);
            this.playerNumber2T1lbl.Name = "playerNumber2T1lbl";
            this.playerNumber2T1lbl.Size = new System.Drawing.Size(29, 31);
            this.playerNumber2T1lbl.TabIndex = 22;
            this.playerNumber2T1lbl.Text = "1";
            // 
            // playerNumber2T2lbl
            // 
            this.playerNumber2T2lbl.AutoSize = true;
            this.playerNumber2T2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.playerNumber2T2lbl.ForeColor = System.Drawing.Color.Black;
            this.playerNumber2T2lbl.Location = new System.Drawing.Point(573, 387);
            this.playerNumber2T2lbl.Name = "playerNumber2T2lbl";
            this.playerNumber2T2lbl.Size = new System.Drawing.Size(29, 31);
            this.playerNumber2T2lbl.TabIndex = 23;
            this.playerNumber2T2lbl.Text = "1";
            // 
            // minutesT1P1Lbl
            // 
            this.minutesT1P1Lbl.AutoSize = true;
            this.minutesT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P1Lbl.Location = new System.Drawing.Point(127, 347);
            this.minutesT1P1Lbl.Name = "minutesT1P1Lbl";
            this.minutesT1P1Lbl.Size = new System.Drawing.Size(29, 31);
            this.minutesT1P1Lbl.TabIndex = 24;
            this.minutesT1P1Lbl.Text = "1";
            // 
            // secondsT1P1Lbl
            // 
            this.secondsT1P1Lbl.AutoSize = true;
            this.secondsT1P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P1Lbl.Location = new System.Drawing.Point(190, 347);
            this.secondsT1P1Lbl.Name = "secondsT1P1Lbl";
            this.secondsT1P1Lbl.Size = new System.Drawing.Size(29, 31);
            this.secondsT1P1Lbl.TabIndex = 28;
            this.secondsT1P1Lbl.Text = "1";
            // 
            // timeT1P1ParseLbl
            // 
            this.timeT1P1ParseLbl.AutoSize = true;
            this.timeT1P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P1ParseLbl.Location = new System.Drawing.Point(162, 347);
            this.timeT1P1ParseLbl.Name = "timeT1P1ParseLbl";
            this.timeT1P1ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT1P1ParseLbl.TabIndex = 36;
            this.timeT1P1ParseLbl.Text = ":";
            // 
            // timeT1P2ParseLbl
            // 
            this.timeT1P2ParseLbl.AutoSize = true;
            this.timeT1P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT1P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT1P2ParseLbl.Location = new System.Drawing.Point(162, 387);
            this.timeT1P2ParseLbl.Name = "timeT1P2ParseLbl";
            this.timeT1P2ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT1P2ParseLbl.TabIndex = 40;
            this.timeT1P2ParseLbl.Text = ":";
            // 
            // secondsT1P2Lbl
            // 
            this.secondsT1P2Lbl.AutoSize = true;
            this.secondsT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT1P2Lbl.Location = new System.Drawing.Point(190, 387);
            this.secondsT1P2Lbl.Name = "secondsT1P2Lbl";
            this.secondsT1P2Lbl.Size = new System.Drawing.Size(29, 31);
            this.secondsT1P2Lbl.TabIndex = 38;
            this.secondsT1P2Lbl.Text = "1";
            // 
            // minutesT1P2Lbl
            // 
            this.minutesT1P2Lbl.AutoSize = true;
            this.minutesT1P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT1P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT1P2Lbl.Location = new System.Drawing.Point(127, 387);
            this.minutesT1P2Lbl.Name = "minutesT1P2Lbl";
            this.minutesT1P2Lbl.Size = new System.Drawing.Size(29, 31);
            this.minutesT1P2Lbl.TabIndex = 37;
            this.minutesT1P2Lbl.Text = "1";
            // 
            // timeT2P1ParseLbl
            // 
            this.timeT2P1ParseLbl.AutoSize = true;
            this.timeT2P1ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P1ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P1ParseLbl.Location = new System.Drawing.Point(716, 347);
            this.timeT2P1ParseLbl.Name = "timeT2P1ParseLbl";
            this.timeT2P1ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT2P1ParseLbl.TabIndex = 44;
            this.timeT2P1ParseLbl.Text = ":";
            // 
            // secondsT2P1Lbl
            // 
            this.secondsT2P1Lbl.AutoSize = true;
            this.secondsT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P1Lbl.Location = new System.Drawing.Point(744, 347);
            this.secondsT2P1Lbl.Name = "secondsT2P1Lbl";
            this.secondsT2P1Lbl.Size = new System.Drawing.Size(29, 31);
            this.secondsT2P1Lbl.TabIndex = 42;
            this.secondsT2P1Lbl.Text = "1";
            // 
            // minutesT2P1Lbl
            // 
            this.minutesT2P1Lbl.AutoSize = true;
            this.minutesT2P1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P1Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P1Lbl.Location = new System.Drawing.Point(681, 347);
            this.minutesT2P1Lbl.Name = "minutesT2P1Lbl";
            this.minutesT2P1Lbl.Size = new System.Drawing.Size(29, 31);
            this.minutesT2P1Lbl.TabIndex = 41;
            this.minutesT2P1Lbl.Text = "1";
            // 
            // timeT2P2ParseLbl
            // 
            this.timeT2P2ParseLbl.AutoSize = true;
            this.timeT2P2ParseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeT2P2ParseLbl.ForeColor = System.Drawing.Color.Black;
            this.timeT2P2ParseLbl.Location = new System.Drawing.Point(716, 387);
            this.timeT2P2ParseLbl.Name = "timeT2P2ParseLbl";
            this.timeT2P2ParseLbl.Size = new System.Drawing.Size(22, 31);
            this.timeT2P2ParseLbl.TabIndex = 48;
            this.timeT2P2ParseLbl.Text = ":";
            // 
            // secondsT2P2Lbl
            // 
            this.secondsT2P2Lbl.AutoSize = true;
            this.secondsT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secondsT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.secondsT2P2Lbl.Location = new System.Drawing.Point(744, 387);
            this.secondsT2P2Lbl.Name = "secondsT2P2Lbl";
            this.secondsT2P2Lbl.Size = new System.Drawing.Size(29, 31);
            this.secondsT2P2Lbl.TabIndex = 46;
            this.secondsT2P2Lbl.Text = "1";
            // 
            // minutesT2P2Lbl
            // 
            this.minutesT2P2Lbl.AutoSize = true;
            this.minutesT2P2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minutesT2P2Lbl.ForeColor = System.Drawing.Color.Black;
            this.minutesT2P2Lbl.Location = new System.Drawing.Point(681, 387);
            this.minutesT2P2Lbl.Name = "minutesT2P2Lbl";
            this.minutesT2P2Lbl.Size = new System.Drawing.Size(29, 31);
            this.minutesT2P2Lbl.TabIndex = 45;
            this.minutesT2P2Lbl.Text = "1";
            // 
            // team1Logo
            // 
            this.team1Logo.Location = new System.Drawing.Point(74, 51);
            this.team1Logo.Name = "team1Logo";
            this.team1Logo.Size = new System.Drawing.Size(110, 64);
            this.team1Logo.TabIndex = 49;
            this.team1Logo.TabStop = false;
            // 
            // team2Logo
            // 
            this.team2Logo.Location = new System.Drawing.Point(574, 51);
            this.team2Logo.Name = "team2Logo";
            this.team2Logo.Size = new System.Drawing.Size(110, 64);
            this.team2Logo.TabIndex = 50;
            this.team2Logo.TabStop = false;
            // 
            // ScoreboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}