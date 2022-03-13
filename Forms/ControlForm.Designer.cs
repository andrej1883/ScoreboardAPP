namespace Scoreboard.Forms
{
    partial class ControlForm
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
            this.scoreBWidth = new System.Windows.Forms.NumericUpDown();
            this.scoreBHeight = new System.Windows.Forms.NumericUpDown();
            this.blackBcgrBtn = new System.Windows.Forms.Button();
            this.widthLbl = new System.Windows.Forms.Label();
            this.hghtLbl = new System.Windows.Forms.Label();
            this.centerScoreBtn = new System.Windows.Forms.Button();
            this.kv1Btn = new System.Windows.Forms.Button();
            this.kv2Btn = new System.Windows.Forms.Button();
            this.kv3Btn = new System.Windows.Forms.Button();
            this.kv4Btn = new System.Windows.Forms.Button();
            this.scoreSettingBox = new System.Windows.Forms.GroupBox();
            this.scoreGBScore = new System.Windows.Forms.GroupBox();
            this.setSizeSS = new System.Windows.Forms.Button();
            this.setColorSS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.scoreGBLabels = new System.Windows.Forms.GroupBox();
            this.setSizeSL = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.setColorSL = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.periodSettingsBox = new System.Windows.Forms.GroupBox();
            this.periodGBPeriod = new System.Windows.Forms.GroupBox();
            this.setSizePP = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.setColorPP = new System.Windows.Forms.Button();
            this.periodGBLabel = new System.Windows.Forms.GroupBox();
            this.setSizePL = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.setColorPL = new System.Windows.Forms.Button();
            this.timeSettingsBox = new System.Windows.Forms.GroupBox();
            this.timeGBClock = new System.Windows.Forms.GroupBox();
            this.setSizeTC = new System.Windows.Forms.Button();
            this.setColorTC = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.timeGBLabels = new System.Windows.Forms.GroupBox();
            this.setSizeTL = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.setColorTL = new System.Windows.Forms.Button();
            this.penaltySettingsBox = new System.Windows.Forms.GroupBox();
            this.penaltyGBPenaltyData = new System.Windows.Forms.GroupBox();
            this.setSizePenData = new System.Windows.Forms.Button();
            this.setColorPenData = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.penaltyGBLabels = new System.Windows.Forms.GroupBox();
            this.setSizePenL = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.setColorPenL = new System.Windows.Forms.Button();
            this.scoreBoardSettingsBox = new System.Windows.Forms.GroupBox();
            this.backgrColor = new System.Windows.Forms.Button();
            this.importPath = new System.Windows.Forms.TextBox();
            this.importSettings = new System.Windows.Forms.Button();
            this.exportSettings = new System.Windows.Forms.Button();
            this.backgroundColorLbl = new System.Windows.Forms.Label();
            this.unlockScoreboard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBHeight)).BeginInit();
            this.scoreSettingBox.SuspendLayout();
            this.scoreGBScore.SuspendLayout();
            this.scoreGBLabels.SuspendLayout();
            this.periodSettingsBox.SuspendLayout();
            this.periodGBPeriod.SuspendLayout();
            this.periodGBLabel.SuspendLayout();
            this.timeSettingsBox.SuspendLayout();
            this.timeGBClock.SuspendLayout();
            this.timeGBLabels.SuspendLayout();
            this.penaltySettingsBox.SuspendLayout();
            this.penaltyGBPenaltyData.SuspendLayout();
            this.penaltyGBLabels.SuspendLayout();
            this.scoreBoardSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreBWidth
            // 
            this.scoreBWidth.Location = new System.Drawing.Point(58, 51);
            this.scoreBWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.scoreBWidth.Name = "scoreBWidth";
            this.scoreBWidth.Size = new System.Drawing.Size(120, 20);
            this.scoreBWidth.TabIndex = 1;
            this.scoreBWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.scoreBWidth.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // scoreBHeight
            // 
            this.scoreBHeight.Location = new System.Drawing.Point(58, 118);
            this.scoreBHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.scoreBHeight.Name = "scoreBHeight";
            this.scoreBHeight.Size = new System.Drawing.Size(120, 20);
            this.scoreBHeight.TabIndex = 2;
            this.scoreBHeight.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.scoreBHeight.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // blackBcgrBtn
            // 
            this.blackBcgrBtn.Location = new System.Drawing.Point(32, 271);
            this.blackBcgrBtn.Name = "blackBcgrBtn";
            this.blackBcgrBtn.Size = new System.Drawing.Size(125, 23);
            this.blackBcgrBtn.TabIndex = 3;
            this.blackBcgrBtn.Text = "Black bacground";
            this.blackBcgrBtn.UseVisualStyleBackColor = true;
            this.blackBcgrBtn.Click += new System.EventHandler(this.blackBcgrBtn_Click);
            // 
            // widthLbl
            // 
            this.widthLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLbl.AutoSize = true;
            this.widthLbl.Location = new System.Drawing.Point(17, 53);
            this.widthLbl.Name = "widthLbl";
            this.widthLbl.Size = new System.Drawing.Size(41, 13);
            this.widthLbl.TabIndex = 5;
            this.widthLbl.Text = "Width: ";
            // 
            // hghtLbl
            // 
            this.hghtLbl.AutoSize = true;
            this.hghtLbl.Location = new System.Drawing.Point(17, 120);
            this.hghtLbl.Name = "hghtLbl";
            this.hghtLbl.Size = new System.Drawing.Size(44, 13);
            this.hghtLbl.TabIndex = 6;
            this.hghtLbl.Text = "Height: ";
            // 
            // centerScoreBtn
            // 
            this.centerScoreBtn.Location = new System.Drawing.Point(467, 97);
            this.centerScoreBtn.Name = "centerScoreBtn";
            this.centerScoreBtn.Size = new System.Drawing.Size(137, 23);
            this.centerScoreBtn.TabIndex = 7;
            this.centerScoreBtn.Text = "Center Scoreboard";
            this.centerScoreBtn.UseVisualStyleBackColor = true;
            this.centerScoreBtn.Click += new System.EventHandler(this.centerScoreBtn_Click_1);
            // 
            // kv1Btn
            // 
            this.kv1Btn.Location = new System.Drawing.Point(539, 48);
            this.kv1Btn.Name = "kv1Btn";
            this.kv1Btn.Size = new System.Drawing.Size(137, 23);
            this.kv1Btn.TabIndex = 8;
            this.kv1Btn.Text = "1st Kvadrant";
            this.kv1Btn.UseVisualStyleBackColor = true;
            this.kv1Btn.Click += new System.EventHandler(this.kv1Btn_Click);
            // 
            // kv2Btn
            // 
            this.kv2Btn.Location = new System.Drawing.Point(361, 48);
            this.kv2Btn.Name = "kv2Btn";
            this.kv2Btn.Size = new System.Drawing.Size(137, 23);
            this.kv2Btn.TabIndex = 9;
            this.kv2Btn.Text = "2nd Kvadrant";
            this.kv2Btn.UseVisualStyleBackColor = true;
            this.kv2Btn.Click += new System.EventHandler(this.kv2Btn_Click);
            // 
            // kv3Btn
            // 
            this.kv3Btn.Location = new System.Drawing.Point(361, 152);
            this.kv3Btn.Name = "kv3Btn";
            this.kv3Btn.Size = new System.Drawing.Size(137, 23);
            this.kv3Btn.TabIndex = 10;
            this.kv3Btn.Text = "3rd Kvadrant";
            this.kv3Btn.UseVisualStyleBackColor = true;
            this.kv3Btn.Click += new System.EventHandler(this.kv3Btn_Click);
            // 
            // kv4Btn
            // 
            this.kv4Btn.Location = new System.Drawing.Point(539, 152);
            this.kv4Btn.Name = "kv4Btn";
            this.kv4Btn.Size = new System.Drawing.Size(137, 23);
            this.kv4Btn.TabIndex = 11;
            this.kv4Btn.Text = "4th Kvadrant";
            this.kv4Btn.UseVisualStyleBackColor = true;
            this.kv4Btn.Click += new System.EventHandler(this.kv4Btn_Click);
            // 
            // scoreSettingBox
            // 
            this.scoreSettingBox.Controls.Add(this.scoreGBScore);
            this.scoreSettingBox.Controls.Add(this.scoreGBLabels);
            this.scoreSettingBox.Location = new System.Drawing.Point(12, 364);
            this.scoreSettingBox.Name = "scoreSettingBox";
            this.scoreSettingBox.Size = new System.Drawing.Size(345, 176);
            this.scoreSettingBox.TabIndex = 14;
            this.scoreSettingBox.TabStop = false;
            this.scoreSettingBox.Text = "Score Settings";
            // 
            // scoreGBScore
            // 
            this.scoreGBScore.Controls.Add(this.setSizeSS);
            this.scoreGBScore.Controls.Add(this.setColorSS);
            this.scoreGBScore.Controls.Add(this.label3);
            this.scoreGBScore.Controls.Add(this.label10);
            this.scoreGBScore.Location = new System.Drawing.Point(185, 28);
            this.scoreGBScore.Name = "scoreGBScore";
            this.scoreGBScore.Size = new System.Drawing.Size(147, 130);
            this.scoreGBScore.TabIndex = 2;
            this.scoreGBScore.TabStop = false;
            this.scoreGBScore.Text = "Score";
            // 
            // setSizeSS
            // 
            this.setSizeSS.Location = new System.Drawing.Point(46, 41);
            this.setSizeSS.Name = "setSizeSS";
            this.setSizeSS.Size = new System.Drawing.Size(75, 23);
            this.setSizeSS.TabIndex = 21;
            this.setSizeSS.Text = "Set Font";
            this.setSizeSS.UseVisualStyleBackColor = true;
            this.setSizeSS.Click += new System.EventHandler(this.setSizeSS_Click);
            // 
            // setColorSS
            // 
            this.setColorSS.Location = new System.Drawing.Point(46, 86);
            this.setColorSS.Name = "setColorSS";
            this.setColorSS.Size = new System.Drawing.Size(75, 23);
            this.setColorSS.TabIndex = 19;
            this.setColorSS.Text = "Set Color";
            this.setColorSS.UseVisualStyleBackColor = true;
            this.setColorSS.Click += new System.EventHandler(this.setColorSS_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Font:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Color:";
            // 
            // scoreGBLabels
            // 
            this.scoreGBLabels.Controls.Add(this.setSizeSL);
            this.scoreGBLabels.Controls.Add(this.label2);
            this.scoreGBLabels.Controls.Add(this.setColorSL);
            this.scoreGBLabels.Controls.Add(this.label1);
            this.scoreGBLabels.Location = new System.Drawing.Point(15, 28);
            this.scoreGBLabels.Name = "scoreGBLabels";
            this.scoreGBLabels.Size = new System.Drawing.Size(151, 130);
            this.scoreGBLabels.TabIndex = 1;
            this.scoreGBLabels.TabStop = false;
            this.scoreGBLabels.Text = "Labels";
            // 
            // setSizeSL
            // 
            this.setSizeSL.Location = new System.Drawing.Point(51, 41);
            this.setSizeSL.Name = "setSizeSL";
            this.setSizeSL.Size = new System.Drawing.Size(75, 23);
            this.setSizeSL.TabIndex = 19;
            this.setSizeSL.Text = "Set Font";
            this.setSizeSL.UseVisualStyleBackColor = true;
            this.setSizeSL.Click += new System.EventHandler(this.setSizeSL_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Font:";
            // 
            // setColorSL
            // 
            this.setColorSL.Location = new System.Drawing.Point(51, 86);
            this.setColorSL.Name = "setColorSL";
            this.setColorSL.Size = new System.Drawing.Size(75, 23);
            this.setColorSL.TabIndex = 18;
            this.setColorSL.Text = "Set Color";
            this.setColorSL.UseVisualStyleBackColor = true;
            this.setColorSL.Click += new System.EventHandler(this.SetColorSL_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color:";
            // 
            // periodSettingsBox
            // 
            this.periodSettingsBox.Controls.Add(this.periodGBPeriod);
            this.periodSettingsBox.Controls.Add(this.periodGBLabel);
            this.periodSettingsBox.Location = new System.Drawing.Point(12, 563);
            this.periodSettingsBox.Name = "periodSettingsBox";
            this.periodSettingsBox.Size = new System.Drawing.Size(345, 175);
            this.periodSettingsBox.TabIndex = 15;
            this.periodSettingsBox.TabStop = false;
            this.periodSettingsBox.Text = "Period Settings";
            // 
            // periodGBPeriod
            // 
            this.periodGBPeriod.Controls.Add(this.setSizePP);
            this.periodGBPeriod.Controls.Add(this.label14);
            this.periodGBPeriod.Controls.Add(this.label7);
            this.periodGBPeriod.Controls.Add(this.setColorPP);
            this.periodGBPeriod.Location = new System.Drawing.Point(185, 28);
            this.periodGBPeriod.Name = "periodGBPeriod";
            this.periodGBPeriod.Size = new System.Drawing.Size(147, 130);
            this.periodGBPeriod.TabIndex = 2;
            this.periodGBPeriod.TabStop = false;
            this.periodGBPeriod.Text = "Period";
            // 
            // setSizePP
            // 
            this.setSizePP.Location = new System.Drawing.Point(46, 43);
            this.setSizePP.Name = "setSizePP";
            this.setSizePP.Size = new System.Drawing.Size(75, 23);
            this.setSizePP.TabIndex = 30;
            this.setSizePP.Text = "Set Font";
            this.setSizePP.UseVisualStyleBackColor = true;
            this.setSizePP.Click += new System.EventHandler(this.setSizePP_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Color:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Font:";
            // 
            // setColorPP
            // 
            this.setColorPP.Location = new System.Drawing.Point(46, 86);
            this.setColorPP.Name = "setColorPP";
            this.setColorPP.Size = new System.Drawing.Size(75, 23);
            this.setColorPP.TabIndex = 23;
            this.setColorPP.Text = "Set Color";
            this.setColorPP.UseVisualStyleBackColor = true;
            this.setColorPP.Click += new System.EventHandler(this.setColorPP_Click);
            // 
            // periodGBLabel
            // 
            this.periodGBLabel.Controls.Add(this.setSizePL);
            this.periodGBLabel.Controls.Add(this.label13);
            this.periodGBLabel.Controls.Add(this.label6);
            this.periodGBLabel.Controls.Add(this.setColorPL);
            this.periodGBLabel.Location = new System.Drawing.Point(15, 28);
            this.periodGBLabel.Name = "periodGBLabel";
            this.periodGBLabel.Size = new System.Drawing.Size(151, 130);
            this.periodGBLabel.TabIndex = 1;
            this.periodGBLabel.TabStop = false;
            this.periodGBLabel.Text = "Labels";
            // 
            // setSizePL
            // 
            this.setSizePL.Location = new System.Drawing.Point(46, 43);
            this.setSizePL.Name = "setSizePL";
            this.setSizePL.Size = new System.Drawing.Size(75, 23);
            this.setSizePL.TabIndex = 28;
            this.setSizePL.Text = "Set Font";
            this.setSizePL.UseVisualStyleBackColor = true;
            this.setSizePL.Click += new System.EventHandler(this.setSizePL_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Font:";
            // 
            // setColorPL
            // 
            this.setColorPL.Location = new System.Drawing.Point(46, 86);
            this.setColorPL.Name = "setColorPL";
            this.setColorPL.Size = new System.Drawing.Size(75, 23);
            this.setColorPL.TabIndex = 22;
            this.setColorPL.Text = "Set Color";
            this.setColorPL.UseVisualStyleBackColor = true;
            this.setColorPL.Click += new System.EventHandler(this.setColorPL_Click);
            // 
            // timeSettingsBox
            // 
            this.timeSettingsBox.Controls.Add(this.timeGBClock);
            this.timeSettingsBox.Controls.Add(this.timeGBLabels);
            this.timeSettingsBox.Location = new System.Drawing.Point(386, 364);
            this.timeSettingsBox.Name = "timeSettingsBox";
            this.timeSettingsBox.Size = new System.Drawing.Size(345, 176);
            this.timeSettingsBox.TabIndex = 16;
            this.timeSettingsBox.TabStop = false;
            this.timeSettingsBox.Text = "Time Settings";
            // 
            // timeGBClock
            // 
            this.timeGBClock.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.timeGBClock.Controls.Add(this.setSizeTC);
            this.timeGBClock.Controls.Add(this.setColorTC);
            this.timeGBClock.Controls.Add(this.label5);
            this.timeGBClock.Controls.Add(this.label12);
            this.timeGBClock.Location = new System.Drawing.Point(185, 28);
            this.timeGBClock.Name = "timeGBClock";
            this.timeGBClock.Size = new System.Drawing.Size(147, 130);
            this.timeGBClock.TabIndex = 2;
            this.timeGBClock.TabStop = false;
            this.timeGBClock.Text = "Clock";
            // 
            // setSizeTC
            // 
            this.setSizeTC.Location = new System.Drawing.Point(46, 41);
            this.setSizeTC.Name = "setSizeTC";
            this.setSizeTC.Size = new System.Drawing.Size(75, 23);
            this.setSizeTC.TabIndex = 25;
            this.setSizeTC.Text = "Set Font";
            this.setSizeTC.UseVisualStyleBackColor = true;
            this.setSizeTC.Click += new System.EventHandler(this.setSizeTC_Click);
            // 
            // setColorTC
            // 
            this.setColorTC.Location = new System.Drawing.Point(46, 86);
            this.setColorTC.Name = "setColorTC";
            this.setColorTC.Size = new System.Drawing.Size(75, 23);
            this.setColorTC.TabIndex = 21;
            this.setColorTC.Text = "Set Color";
            this.setColorTC.UseVisualStyleBackColor = true;
            this.setColorTC.Click += new System.EventHandler(this.setColorTC_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Font:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Color:";
            // 
            // timeGBLabels
            // 
            this.timeGBLabels.Controls.Add(this.setSizeTL);
            this.timeGBLabels.Controls.Add(this.label11);
            this.timeGBLabels.Controls.Add(this.label4);
            this.timeGBLabels.Controls.Add(this.setColorTL);
            this.timeGBLabels.Location = new System.Drawing.Point(15, 28);
            this.timeGBLabels.Name = "timeGBLabels";
            this.timeGBLabels.Size = new System.Drawing.Size(151, 130);
            this.timeGBLabels.TabIndex = 1;
            this.timeGBLabels.TabStop = false;
            this.timeGBLabels.Text = "Labels";
            // 
            // setSizeTL
            // 
            this.setSizeTL.Location = new System.Drawing.Point(46, 41);
            this.setSizeTL.Name = "setSizeTL";
            this.setSizeTL.Size = new System.Drawing.Size(75, 23);
            this.setSizeTL.TabIndex = 23;
            this.setSizeTL.Text = "Set Font";
            this.setSizeTL.UseVisualStyleBackColor = true;
            this.setSizeTL.Click += new System.EventHandler(this.setSizeTL_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Color:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Font:";
            // 
            // setColorTL
            // 
            this.setColorTL.Location = new System.Drawing.Point(46, 86);
            this.setColorTL.Name = "setColorTL";
            this.setColorTL.Size = new System.Drawing.Size(75, 23);
            this.setColorTL.TabIndex = 20;
            this.setColorTL.Text = "Set Color";
            this.setColorTL.UseVisualStyleBackColor = true;
            this.setColorTL.Click += new System.EventHandler(this.setColorTL_Click);
            // 
            // penaltySettingsBox
            // 
            this.penaltySettingsBox.Controls.Add(this.penaltyGBPenaltyData);
            this.penaltySettingsBox.Controls.Add(this.penaltyGBLabels);
            this.penaltySettingsBox.Location = new System.Drawing.Point(386, 563);
            this.penaltySettingsBox.Name = "penaltySettingsBox";
            this.penaltySettingsBox.Size = new System.Drawing.Size(345, 175);
            this.penaltySettingsBox.TabIndex = 17;
            this.penaltySettingsBox.TabStop = false;
            this.penaltySettingsBox.Text = "Penalty Settings";
            // 
            // penaltyGBPenaltyData
            // 
            this.penaltyGBPenaltyData.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.penaltyGBPenaltyData.Controls.Add(this.setSizePenData);
            this.penaltyGBPenaltyData.Controls.Add(this.setColorPenData);
            this.penaltyGBPenaltyData.Controls.Add(this.label9);
            this.penaltyGBPenaltyData.Controls.Add(this.label16);
            this.penaltyGBPenaltyData.Location = new System.Drawing.Point(185, 28);
            this.penaltyGBPenaltyData.Name = "penaltyGBPenaltyData";
            this.penaltyGBPenaltyData.Size = new System.Drawing.Size(147, 130);
            this.penaltyGBPenaltyData.TabIndex = 2;
            this.penaltyGBPenaltyData.TabStop = false;
            this.penaltyGBPenaltyData.Text = "Penalty Data";
            // 
            // setSizePenData
            // 
            this.setSizePenData.Location = new System.Drawing.Point(46, 48);
            this.setSizePenData.Name = "setSizePenData";
            this.setSizePenData.Size = new System.Drawing.Size(75, 23);
            this.setSizePenData.TabIndex = 34;
            this.setSizePenData.Text = "Set Font";
            this.setSizePenData.UseVisualStyleBackColor = true;
            this.setSizePenData.Click += new System.EventHandler(this.setSizePenData_Click);
            // 
            // setColorPenData
            // 
            this.setColorPenData.Location = new System.Drawing.Point(46, 86);
            this.setColorPenData.Name = "setColorPenData";
            this.setColorPenData.Size = new System.Drawing.Size(75, 23);
            this.setColorPenData.TabIndex = 25;
            this.setColorPenData.Text = "Set Color";
            this.setColorPenData.UseVisualStyleBackColor = true;
            this.setColorPenData.Click += new System.EventHandler(this.setColorPenData_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Font:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Color:";
            // 
            // penaltyGBLabels
            // 
            this.penaltyGBLabels.Controls.Add(this.setSizePenL);
            this.penaltyGBLabels.Controls.Add(this.label15);
            this.penaltyGBLabels.Controls.Add(this.label8);
            this.penaltyGBLabels.Controls.Add(this.setColorPenL);
            this.penaltyGBLabels.Location = new System.Drawing.Point(15, 28);
            this.penaltyGBLabels.Name = "penaltyGBLabels";
            this.penaltyGBLabels.Size = new System.Drawing.Size(151, 130);
            this.penaltyGBLabels.TabIndex = 1;
            this.penaltyGBLabels.TabStop = false;
            this.penaltyGBLabels.Text = "Labels";
            // 
            // setSizePenL
            // 
            this.setSizePenL.Location = new System.Drawing.Point(46, 48);
            this.setSizePenL.Name = "setSizePenL";
            this.setSizePenL.Size = new System.Drawing.Size(75, 23);
            this.setSizePenL.TabIndex = 32;
            this.setSizePenL.Text = "Set Font";
            this.setSizePenL.UseVisualStyleBackColor = true;
            this.setSizePenL.Click += new System.EventHandler(this.setSizePenL_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Color:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Font:";
            // 
            // setColorPenL
            // 
            this.setColorPenL.Location = new System.Drawing.Point(46, 86);
            this.setColorPenL.Name = "setColorPenL";
            this.setColorPenL.Size = new System.Drawing.Size(75, 23);
            this.setColorPenL.TabIndex = 24;
            this.setColorPenL.Text = "Set Color";
            this.setColorPenL.UseVisualStyleBackColor = true;
            this.setColorPenL.Click += new System.EventHandler(this.setColorPenL_Click);
            // 
            // scoreBoardSettingsBox
            // 
            this.scoreBoardSettingsBox.Controls.Add(this.unlockScoreboard);
            this.scoreBoardSettingsBox.Controls.Add(this.backgrColor);
            this.scoreBoardSettingsBox.Controls.Add(this.importPath);
            this.scoreBoardSettingsBox.Controls.Add(this.importSettings);
            this.scoreBoardSettingsBox.Controls.Add(this.exportSettings);
            this.scoreBoardSettingsBox.Controls.Add(this.backgroundColorLbl);
            this.scoreBoardSettingsBox.Controls.Add(this.blackBcgrBtn);
            this.scoreBoardSettingsBox.Controls.Add(this.widthLbl);
            this.scoreBoardSettingsBox.Controls.Add(this.scoreBWidth);
            this.scoreBoardSettingsBox.Controls.Add(this.kv4Btn);
            this.scoreBoardSettingsBox.Controls.Add(this.scoreBHeight);
            this.scoreBoardSettingsBox.Controls.Add(this.hghtLbl);
            this.scoreBoardSettingsBox.Controls.Add(this.kv3Btn);
            this.scoreBoardSettingsBox.Controls.Add(this.centerScoreBtn);
            this.scoreBoardSettingsBox.Controls.Add(this.kv1Btn);
            this.scoreBoardSettingsBox.Controls.Add(this.kv2Btn);
            this.scoreBoardSettingsBox.Location = new System.Drawing.Point(12, 12);
            this.scoreBoardSettingsBox.Name = "scoreBoardSettingsBox";
            this.scoreBoardSettingsBox.Size = new System.Drawing.Size(719, 337);
            this.scoreBoardSettingsBox.TabIndex = 18;
            this.scoreBoardSettingsBox.TabStop = false;
            this.scoreBoardSettingsBox.Text = "ScoreBoard Settings";
            // 
            // backgrColor
            // 
            this.backgrColor.Location = new System.Drawing.Point(118, 173);
            this.backgrColor.Name = "backgrColor";
            this.backgrColor.Size = new System.Drawing.Size(75, 23);
            this.backgrColor.TabIndex = 17;
            this.backgrColor.Text = "Set Color";
            this.backgrColor.UseVisualStyleBackColor = true;
            this.backgrColor.Click += new System.EventHandler(this.backgrColor_Click);
            // 
            // importPath
            // 
            this.importPath.Location = new System.Drawing.Point(437, 215);
            this.importPath.Name = "importPath";
            this.importPath.Size = new System.Drawing.Size(243, 20);
            this.importPath.TabIndex = 16;
            // 
            // importSettings
            // 
            this.importSettings.Location = new System.Drawing.Point(313, 215);
            this.importSettings.Name = "importSettings";
            this.importSettings.Size = new System.Drawing.Size(100, 23);
            this.importSettings.TabIndex = 15;
            this.importSettings.Text = "Import";
            this.importSettings.UseVisualStyleBackColor = true;
            this.importSettings.Click += new System.EventHandler(this.importSettings_Click);
            // 
            // exportSettings
            // 
            this.exportSettings.Location = new System.Drawing.Point(313, 271);
            this.exportSettings.Name = "exportSettings";
            this.exportSettings.Size = new System.Drawing.Size(100, 23);
            this.exportSettings.TabIndex = 14;
            this.exportSettings.Text = "Export";
            this.exportSettings.UseVisualStyleBackColor = true;
            this.exportSettings.Click += new System.EventHandler(this.exportSettings_Click);
            // 
            // backgroundColorLbl
            // 
            this.backgroundColorLbl.AutoSize = true;
            this.backgroundColorLbl.Location = new System.Drawing.Point(17, 178);
            this.backgroundColorLbl.Name = "backgroundColorLbl";
            this.backgroundColorLbl.Size = new System.Drawing.Size(95, 13);
            this.backgroundColorLbl.TabIndex = 13;
            this.backgroundColorLbl.Text = "Background Color:";
            // 
            // unlockScoreboard
            // 
            this.unlockScoreboard.Location = new System.Drawing.Point(32, 230);
            this.unlockScoreboard.Name = "unlockScoreboard";
            this.unlockScoreboard.Size = new System.Drawing.Size(125, 23);
            this.unlockScoreboard.TabIndex = 18;
            this.unlockScoreboard.Text = "Unlock";
            this.unlockScoreboard.UseVisualStyleBackColor = true;
            this.unlockScoreboard.Click += new System.EventHandler(this.unlockScoreboard_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 948);
            this.Controls.Add(this.scoreBoardSettingsBox);
            this.Controls.Add(this.penaltySettingsBox);
            this.Controls.Add(this.timeSettingsBox);
            this.Controls.Add(this.periodSettingsBox);
            this.Controls.Add(this.scoreSettingBox);
            this.Name = "ControlForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoreBWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBHeight)).EndInit();
            this.scoreSettingBox.ResumeLayout(false);
            this.scoreGBScore.ResumeLayout(false);
            this.scoreGBScore.PerformLayout();
            this.scoreGBLabels.ResumeLayout(false);
            this.scoreGBLabels.PerformLayout();
            this.periodSettingsBox.ResumeLayout(false);
            this.periodGBPeriod.ResumeLayout(false);
            this.periodGBPeriod.PerformLayout();
            this.periodGBLabel.ResumeLayout(false);
            this.periodGBLabel.PerformLayout();
            this.timeSettingsBox.ResumeLayout(false);
            this.timeGBClock.ResumeLayout(false);
            this.timeGBClock.PerformLayout();
            this.timeGBLabels.ResumeLayout(false);
            this.timeGBLabels.PerformLayout();
            this.penaltySettingsBox.ResumeLayout(false);
            this.penaltyGBPenaltyData.ResumeLayout(false);
            this.penaltyGBPenaltyData.PerformLayout();
            this.penaltyGBLabels.ResumeLayout(false);
            this.penaltyGBLabels.PerformLayout();
            this.scoreBoardSettingsBox.ResumeLayout(false);
            this.scoreBoardSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown scoreBWidth;
        private System.Windows.Forms.NumericUpDown scoreBHeight;
        private System.Windows.Forms.Button blackBcgrBtn;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label hghtLbl;
        private System.Windows.Forms.Button centerScoreBtn;
        private System.Windows.Forms.Button kv1Btn;
        private System.Windows.Forms.Button kv2Btn;
        private System.Windows.Forms.Button kv3Btn;
        private System.Windows.Forms.Button kv4Btn;
        private System.Windows.Forms.GroupBox scoreSettingBox;
        private System.Windows.Forms.GroupBox scoreGBScore;
        private System.Windows.Forms.GroupBox scoreGBLabels;
        private System.Windows.Forms.GroupBox periodSettingsBox;
        private System.Windows.Forms.GroupBox periodGBPeriod;
        private System.Windows.Forms.GroupBox periodGBLabel;
        private System.Windows.Forms.GroupBox timeSettingsBox;
        private System.Windows.Forms.GroupBox timeGBClock;
        private System.Windows.Forms.GroupBox timeGBLabels;
        private System.Windows.Forms.GroupBox penaltySettingsBox;
        private System.Windows.Forms.GroupBox penaltyGBPenaltyData;
        private System.Windows.Forms.GroupBox penaltyGBLabels;
        private System.Windows.Forms.GroupBox scoreBoardSettingsBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label backgroundColorLbl;
        private System.Windows.Forms.Button importSettings;
        private System.Windows.Forms.Button exportSettings;
        private System.Windows.Forms.TextBox importPath;
        private System.Windows.Forms.Button backgrColor;
        private System.Windows.Forms.Button setColorSS;
        private System.Windows.Forms.Button setColorSL;
        private System.Windows.Forms.Button setColorTC;
        private System.Windows.Forms.Button setColorTL;
        private System.Windows.Forms.Button setColorPL;
        private System.Windows.Forms.Button setColorPP;
        private System.Windows.Forms.Button setColorPenL;
        private System.Windows.Forms.Button setColorPenData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button setSizeSL;
        private System.Windows.Forms.Button setSizeSS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setSizePP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button setSizePL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button setSizeTC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button setSizeTL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button setSizePenData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button setSizePenL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button unlockScoreboard;
    }
}

