namespace Scoreboard
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
            this.createBtn = new System.Windows.Forms.Button();
            this.scoreBWidth = new System.Windows.Forms.NumericUpDown();
            this.scoreBHeight = new System.Windows.Forms.NumericUpDown();
            this.blackBcgrBtn = new System.Windows.Forms.Button();
            this.closeScoreboardBtn = new System.Windows.Forms.Button();
            this.widthLbl = new System.Windows.Forms.Label();
            this.hghtLbl = new System.Windows.Forms.Label();
            this.centerScoreBtn = new System.Windows.Forms.Button();
            this.kv1Btn = new System.Windows.Forms.Button();
            this.kv2Btn = new System.Windows.Forms.Button();
            this.kv3Btn = new System.Windows.Forms.Button();
            this.kv4Btn = new System.Windows.Forms.Button();
            this.scoreSettingBox = new System.Windows.Forms.GroupBox();
            this.scoreGBScore = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.scoreSC = new System.Windows.Forms.ComboBox();
            this.scoreSize = new System.Windows.Forms.NumericUpDown();
            this.scoreGBLabels = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.scoreLC = new System.Windows.Forms.ComboBox();
            this.scoreLblSize = new System.Windows.Forms.NumericUpDown();
            this.periodSettingsBox = new System.Windows.Forms.GroupBox();
            this.periodGBPeriod = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.periodPC = new System.Windows.Forms.ComboBox();
            this.periodSize = new System.Windows.Forms.NumericUpDown();
            this.periodGBLabel = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.periodLC = new System.Windows.Forms.ComboBox();
            this.periodLblSize = new System.Windows.Forms.NumericUpDown();
            this.timeSettingsBox = new System.Windows.Forms.GroupBox();
            this.timeGBClock = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeCC = new System.Windows.Forms.ComboBox();
            this.clockSize = new System.Windows.Forms.NumericUpDown();
            this.timeGBLabels = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLC = new System.Windows.Forms.ComboBox();
            this.timeLblSize = new System.Windows.Forms.NumericUpDown();
            this.penaltySettingsBox = new System.Windows.Forms.GroupBox();
            this.penaltyGBPenaltyData = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.penaltyPDC = new System.Windows.Forms.ComboBox();
            this.penaltyDataSize = new System.Windows.Forms.NumericUpDown();
            this.penaltyGBLabels = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.penaltyLC = new System.Windows.Forms.ComboBox();
            this.penaltyLblSize = new System.Windows.Forms.NumericUpDown();
            this.scoreBoardSettingsBox = new System.Windows.Forms.GroupBox();
            this.backgroundColorLbl = new System.Windows.Forms.Label();
            this.backgrClr = new System.Windows.Forms.ComboBox();
            this.exportSettings = new System.Windows.Forms.Button();
            this.importSettings = new System.Windows.Forms.Button();
            this.importPath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBHeight)).BeginInit();
            this.scoreSettingBox.SuspendLayout();
            this.scoreGBScore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreSize)).BeginInit();
            this.scoreGBLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreLblSize)).BeginInit();
            this.periodSettingsBox.SuspendLayout();
            this.periodGBPeriod.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodSize)).BeginInit();
            this.periodGBLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodLblSize)).BeginInit();
            this.timeSettingsBox.SuspendLayout();
            this.timeGBClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockSize)).BeginInit();
            this.timeGBLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLblSize)).BeginInit();
            this.penaltySettingsBox.SuspendLayout();
            this.penaltyGBPenaltyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyDataSize)).BeginInit();
            this.penaltyGBLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyLblSize)).BeginInit();
            this.scoreBoardSettingsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(361, 271);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(145, 23);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Create ScoreBoard";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
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
            490,
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
            // closeScoreboardBtn
            // 
            this.closeScoreboardBtn.Location = new System.Drawing.Point(536, 271);
            this.closeScoreboardBtn.Name = "closeScoreboardBtn";
            this.closeScoreboardBtn.Size = new System.Drawing.Size(137, 23);
            this.closeScoreboardBtn.TabIndex = 4;
            this.closeScoreboardBtn.Text = "Close Scoreboard";
            this.closeScoreboardBtn.UseVisualStyleBackColor = true;
            this.closeScoreboardBtn.Click += new System.EventHandler(this.closeScoreboardBtn_Click);
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
            this.centerScoreBtn.Click += new System.EventHandler(this.button1_Click_1);
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
            this.scoreSettingBox.Size = new System.Drawing.Size(345, 175);
            this.scoreSettingBox.TabIndex = 14;
            this.scoreSettingBox.TabStop = false;
            this.scoreSettingBox.Text = "Score Settings";
            // 
            // scoreGBScore
            // 
            this.scoreGBScore.Controls.Add(this.label10);
            this.scoreGBScore.Controls.Add(this.label3);
            this.scoreGBScore.Controls.Add(this.scoreSC);
            this.scoreGBScore.Controls.Add(this.scoreSize);
            this.scoreGBScore.Location = new System.Drawing.Point(176, 28);
            this.scoreGBScore.Name = "scoreGBScore";
            this.scoreGBScore.Size = new System.Drawing.Size(147, 130);
            this.scoreGBScore.TabIndex = 2;
            this.scoreGBScore.TabStop = false;
            this.scoreGBScore.Text = "Score";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Color";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Size";
            // 
            // scoreSC
            // 
            this.scoreSC.FormattingEnabled = true;
            this.scoreSC.Location = new System.Drawing.Point(6, 94);
            this.scoreSC.Name = "scoreSC";
            this.scoreSC.Size = new System.Drawing.Size(120, 21);
            this.scoreSC.TabIndex = 3;
            this.scoreSC.SelectedIndexChanged += new System.EventHandler(this.scoreSC_SelectedIndexChanged);
            // 
            // scoreSize
            // 
            this.scoreSize.Location = new System.Drawing.Point(6, 47);
            this.scoreSize.Name = "scoreSize";
            this.scoreSize.Size = new System.Drawing.Size(120, 20);
            this.scoreSize.TabIndex = 2;
            this.scoreSize.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // scoreGBLabels
            // 
            this.scoreGBLabels.Controls.Add(this.label2);
            this.scoreGBLabels.Controls.Add(this.label1);
            this.scoreGBLabels.Controls.Add(this.scoreLC);
            this.scoreGBLabels.Controls.Add(this.scoreLblSize);
            this.scoreGBLabels.Location = new System.Drawing.Point(6, 28);
            this.scoreGBLabels.Name = "scoreGBLabels";
            this.scoreGBLabels.Size = new System.Drawing.Size(151, 130);
            this.scoreGBLabels.TabIndex = 1;
            this.scoreGBLabels.TabStop = false;
            this.scoreGBLabels.Text = "Labels";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color";
            // 
            // scoreLC
            // 
            this.scoreLC.FormattingEnabled = true;
            this.scoreLC.Location = new System.Drawing.Point(6, 94);
            this.scoreLC.Name = "scoreLC";
            this.scoreLC.Size = new System.Drawing.Size(120, 21);
            this.scoreLC.TabIndex = 1;
            this.scoreLC.SelectedIndexChanged += new System.EventHandler(this.scoreLC_SelectedIndexChanged);
            // 
            // scoreLblSize
            // 
            this.scoreLblSize.Location = new System.Drawing.Point(6, 47);
            this.scoreLblSize.Name = "scoreLblSize";
            this.scoreLblSize.Size = new System.Drawing.Size(120, 20);
            this.scoreLblSize.TabIndex = 0;
            this.scoreLblSize.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // periodSettingsBox
            // 
            this.periodSettingsBox.Controls.Add(this.periodGBPeriod);
            this.periodSettingsBox.Controls.Add(this.periodGBLabel);
            this.periodSettingsBox.Location = new System.Drawing.Point(12, 551);
            this.periodSettingsBox.Name = "periodSettingsBox";
            this.periodSettingsBox.Size = new System.Drawing.Size(345, 175);
            this.periodSettingsBox.TabIndex = 15;
            this.periodSettingsBox.TabStop = false;
            this.periodSettingsBox.Text = "Period Settings";
            // 
            // periodGBPeriod
            // 
            this.periodGBPeriod.Controls.Add(this.label14);
            this.periodGBPeriod.Controls.Add(this.label8);
            this.periodGBPeriod.Controls.Add(this.periodPC);
            this.periodGBPeriod.Controls.Add(this.periodSize);
            this.periodGBPeriod.Location = new System.Drawing.Point(176, 28);
            this.periodGBPeriod.Name = "periodGBPeriod";
            this.periodGBPeriod.Size = new System.Drawing.Size(147, 130);
            this.periodGBPeriod.TabIndex = 2;
            this.periodGBPeriod.TabStop = false;
            this.periodGBPeriod.Text = "Period";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Color";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Size";
            // 
            // periodPC
            // 
            this.periodPC.FormattingEnabled = true;
            this.periodPC.Location = new System.Drawing.Point(6, 94);
            this.periodPC.Name = "periodPC";
            this.periodPC.Size = new System.Drawing.Size(120, 21);
            this.periodPC.TabIndex = 3;
            this.periodPC.SelectedIndexChanged += new System.EventHandler(this.periodPC_SelectedIndexChanged);
            // 
            // periodSize
            // 
            this.periodSize.Location = new System.Drawing.Point(6, 47);
            this.periodSize.Name = "periodSize";
            this.periodSize.Size = new System.Drawing.Size(120, 20);
            this.periodSize.TabIndex = 2;
            this.periodSize.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // periodGBLabel
            // 
            this.periodGBLabel.Controls.Add(this.label13);
            this.periodGBLabel.Controls.Add(this.label9);
            this.periodGBLabel.Controls.Add(this.periodLC);
            this.periodGBLabel.Controls.Add(this.periodLblSize);
            this.periodGBLabel.Location = new System.Drawing.Point(6, 28);
            this.periodGBLabel.Name = "periodGBLabel";
            this.periodGBLabel.Size = new System.Drawing.Size(151, 130);
            this.periodGBLabel.TabIndex = 1;
            this.periodGBLabel.TabStop = false;
            this.periodGBLabel.Text = "Labels";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Size";
            // 
            // periodLC
            // 
            this.periodLC.FormattingEnabled = true;
            this.periodLC.Location = new System.Drawing.Point(6, 94);
            this.periodLC.Name = "periodLC";
            this.periodLC.Size = new System.Drawing.Size(120, 21);
            this.periodLC.TabIndex = 1;
            this.periodLC.SelectedIndexChanged += new System.EventHandler(this.periodLC_SelectedIndexChanged);
            // 
            // periodLblSize
            // 
            this.periodLblSize.Location = new System.Drawing.Point(6, 47);
            this.periodLblSize.Name = "periodLblSize";
            this.periodLblSize.Size = new System.Drawing.Size(120, 20);
            this.periodLblSize.TabIndex = 0;
            this.periodLblSize.ValueChanged += new System.EventHandler(this.periodLblSize_ValueChanged);
            // 
            // timeSettingsBox
            // 
            this.timeSettingsBox.Controls.Add(this.timeGBClock);
            this.timeSettingsBox.Controls.Add(this.timeGBLabels);
            this.timeSettingsBox.Location = new System.Drawing.Point(386, 364);
            this.timeSettingsBox.Name = "timeSettingsBox";
            this.timeSettingsBox.Size = new System.Drawing.Size(345, 175);
            this.timeSettingsBox.TabIndex = 16;
            this.timeSettingsBox.TabStop = false;
            this.timeSettingsBox.Text = "Time Settings";
            // 
            // timeGBClock
            // 
            this.timeGBClock.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.timeGBClock.Controls.Add(this.label12);
            this.timeGBClock.Controls.Add(this.label5);
            this.timeGBClock.Controls.Add(this.timeCC);
            this.timeGBClock.Controls.Add(this.clockSize);
            this.timeGBClock.Location = new System.Drawing.Point(176, 28);
            this.timeGBClock.Name = "timeGBClock";
            this.timeGBClock.Size = new System.Drawing.Size(147, 130);
            this.timeGBClock.TabIndex = 2;
            this.timeGBClock.TabStop = false;
            this.timeGBClock.Text = "Clock";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Size";
            // 
            // timeCC
            // 
            this.timeCC.FormattingEnabled = true;
            this.timeCC.Location = new System.Drawing.Point(6, 94);
            this.timeCC.Name = "timeCC";
            this.timeCC.Size = new System.Drawing.Size(120, 21);
            this.timeCC.TabIndex = 3;
            this.timeCC.SelectedIndexChanged += new System.EventHandler(this.timeCC_SelectedIndexChanged);
            // 
            // clockSize
            // 
            this.clockSize.Location = new System.Drawing.Point(6, 47);
            this.clockSize.Name = "clockSize";
            this.clockSize.Size = new System.Drawing.Size(120, 20);
            this.clockSize.TabIndex = 2;
            this.clockSize.ValueChanged += new System.EventHandler(this.clockSize_ValueChanged);
            // 
            // timeGBLabels
            // 
            this.timeGBLabels.Controls.Add(this.label11);
            this.timeGBLabels.Controls.Add(this.label4);
            this.timeGBLabels.Controls.Add(this.timeLC);
            this.timeGBLabels.Controls.Add(this.timeLblSize);
            this.timeGBLabels.Location = new System.Drawing.Point(6, 28);
            this.timeGBLabels.Name = "timeGBLabels";
            this.timeGBLabels.Size = new System.Drawing.Size(151, 130);
            this.timeGBLabels.TabIndex = 1;
            this.timeGBLabels.TabStop = false;
            this.timeGBLabels.Text = "Labels";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size";
            // 
            // timeLC
            // 
            this.timeLC.FormattingEnabled = true;
            this.timeLC.Location = new System.Drawing.Point(6, 94);
            this.timeLC.Name = "timeLC";
            this.timeLC.Size = new System.Drawing.Size(120, 21);
            this.timeLC.TabIndex = 1;
            this.timeLC.SelectedIndexChanged += new System.EventHandler(this.timeLC_SelectedIndexChanged);
            // 
            // timeLblSize
            // 
            this.timeLblSize.Location = new System.Drawing.Point(6, 47);
            this.timeLblSize.Name = "timeLblSize";
            this.timeLblSize.Size = new System.Drawing.Size(120, 20);
            this.timeLblSize.TabIndex = 0;
            this.timeLblSize.ValueChanged += new System.EventHandler(this.timeLblSize_ValueChanged);
            // 
            // penaltySettingsBox
            // 
            this.penaltySettingsBox.Controls.Add(this.penaltyGBPenaltyData);
            this.penaltySettingsBox.Controls.Add(this.penaltyGBLabels);
            this.penaltySettingsBox.Location = new System.Drawing.Point(386, 551);
            this.penaltySettingsBox.Name = "penaltySettingsBox";
            this.penaltySettingsBox.Size = new System.Drawing.Size(345, 175);
            this.penaltySettingsBox.TabIndex = 17;
            this.penaltySettingsBox.TabStop = false;
            this.penaltySettingsBox.Text = "Penalty Settings";
            // 
            // penaltyGBPenaltyData
            // 
            this.penaltyGBPenaltyData.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace;
            this.penaltyGBPenaltyData.Controls.Add(this.label16);
            this.penaltyGBPenaltyData.Controls.Add(this.label6);
            this.penaltyGBPenaltyData.Controls.Add(this.penaltyPDC);
            this.penaltyGBPenaltyData.Controls.Add(this.penaltyDataSize);
            this.penaltyGBPenaltyData.Location = new System.Drawing.Point(176, 28);
            this.penaltyGBPenaltyData.Name = "penaltyGBPenaltyData";
            this.penaltyGBPenaltyData.Size = new System.Drawing.Size(147, 130);
            this.penaltyGBPenaltyData.TabIndex = 2;
            this.penaltyGBPenaltyData.TabStop = false;
            this.penaltyGBPenaltyData.Text = "Penalty Data";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Size";
            // 
            // penaltyPDC
            // 
            this.penaltyPDC.FormattingEnabled = true;
            this.penaltyPDC.Location = new System.Drawing.Point(6, 94);
            this.penaltyPDC.Name = "penaltyPDC";
            this.penaltyPDC.Size = new System.Drawing.Size(120, 21);
            this.penaltyPDC.TabIndex = 3;
            this.penaltyPDC.SelectedIndexChanged += new System.EventHandler(this.penaltyPDC_SelectedIndexChanged);
            // 
            // penaltyDataSize
            // 
            this.penaltyDataSize.Location = new System.Drawing.Point(6, 47);
            this.penaltyDataSize.Name = "penaltyDataSize";
            this.penaltyDataSize.Size = new System.Drawing.Size(120, 20);
            this.penaltyDataSize.TabIndex = 2;
            this.penaltyDataSize.ValueChanged += new System.EventHandler(this.penaltyDataSize_ValueChanged);
            // 
            // penaltyGBLabels
            // 
            this.penaltyGBLabels.Controls.Add(this.label15);
            this.penaltyGBLabels.Controls.Add(this.label7);
            this.penaltyGBLabels.Controls.Add(this.penaltyLC);
            this.penaltyGBLabels.Controls.Add(this.penaltyLblSize);
            this.penaltyGBLabels.Location = new System.Drawing.Point(6, 28);
            this.penaltyGBLabels.Name = "penaltyGBLabels";
            this.penaltyGBLabels.Size = new System.Drawing.Size(151, 130);
            this.penaltyGBLabels.TabIndex = 1;
            this.penaltyGBLabels.TabStop = false;
            this.penaltyGBLabels.Text = "Labels";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Size";
            // 
            // penaltyLC
            // 
            this.penaltyLC.FormattingEnabled = true;
            this.penaltyLC.Location = new System.Drawing.Point(6, 94);
            this.penaltyLC.Name = "penaltyLC";
            this.penaltyLC.Size = new System.Drawing.Size(120, 21);
            this.penaltyLC.TabIndex = 1;
            this.penaltyLC.SelectedIndexChanged += new System.EventHandler(this.penaltyLC_SelectedIndexChanged);
            // 
            // penaltyLblSize
            // 
            this.penaltyLblSize.Location = new System.Drawing.Point(6, 47);
            this.penaltyLblSize.Name = "penaltyLblSize";
            this.penaltyLblSize.Size = new System.Drawing.Size(120, 20);
            this.penaltyLblSize.TabIndex = 0;
            this.penaltyLblSize.ValueChanged += new System.EventHandler(this.penaltyLblSize_ValueChanged);
            // 
            // scoreBoardSettingsBox
            // 
            this.scoreBoardSettingsBox.Controls.Add(this.importPath);
            this.scoreBoardSettingsBox.Controls.Add(this.importSettings);
            this.scoreBoardSettingsBox.Controls.Add(this.exportSettings);
            this.scoreBoardSettingsBox.Controls.Add(this.backgroundColorLbl);
            this.scoreBoardSettingsBox.Controls.Add(this.backgrClr);
            this.scoreBoardSettingsBox.Controls.Add(this.blackBcgrBtn);
            this.scoreBoardSettingsBox.Controls.Add(this.createBtn);
            this.scoreBoardSettingsBox.Controls.Add(this.widthLbl);
            this.scoreBoardSettingsBox.Controls.Add(this.scoreBWidth);
            this.scoreBoardSettingsBox.Controls.Add(this.kv4Btn);
            this.scoreBoardSettingsBox.Controls.Add(this.scoreBHeight);
            this.scoreBoardSettingsBox.Controls.Add(this.closeScoreboardBtn);
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
            this.scoreBoardSettingsBox.Enter += new System.EventHandler(this.scoreBoardSettingsBox_Enter);
            // 
            // backgroundColorLbl
            // 
            this.backgroundColorLbl.AutoSize = true;
            this.backgroundColorLbl.Location = new System.Drawing.Point(17, 178);
            this.backgroundColorLbl.Name = "backgroundColorLbl";
            this.backgroundColorLbl.Size = new System.Drawing.Size(92, 13);
            this.backgroundColorLbl.TabIndex = 13;
            this.backgroundColorLbl.Text = "Background Color";
            // 
            // backgrClr
            // 
            this.backgrClr.FormattingEnabled = true;
            this.backgrClr.Location = new System.Drawing.Point(20, 205);
            this.backgrClr.Name = "backgrClr";
            this.backgrClr.Size = new System.Drawing.Size(121, 21);
            this.backgrClr.TabIndex = 12;
            this.backgrClr.SelectedIndexChanged += new System.EventHandler(this.backgrClr_SelectedIndexChanged);
            // 
            // exportSettings
            // 
            this.exportSettings.Location = new System.Drawing.Point(219, 270);
            this.exportSettings.Name = "exportSettings";
            this.exportSettings.Size = new System.Drawing.Size(100, 23);
            this.exportSettings.TabIndex = 14;
            this.exportSettings.Text = "Export";
            this.exportSettings.UseVisualStyleBackColor = true;
            this.exportSettings.Click += new System.EventHandler(this.exportSettings_Click);
            // 
            // importSettings
            // 
            this.importSettings.Location = new System.Drawing.Point(219, 217);
            this.importSettings.Name = "importSettings";
            this.importSettings.Size = new System.Drawing.Size(100, 23);
            this.importSettings.TabIndex = 15;
            this.importSettings.Text = "Import";
            this.importSettings.UseVisualStyleBackColor = true;
            this.importSettings.Click += new System.EventHandler(this.importSettings_Click);
            // 
            // importPath
            // 
            this.importPath.Location = new System.Drawing.Point(361, 217);
            this.importPath.Name = "importPath";
            this.importPath.Size = new System.Drawing.Size(315, 20);
            this.importPath.TabIndex = 16;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 736);
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
            ((System.ComponentModel.ISupportInitialize)(this.scoreSize)).EndInit();
            this.scoreGBLabels.ResumeLayout(false);
            this.scoreGBLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scoreLblSize)).EndInit();
            this.periodSettingsBox.ResumeLayout(false);
            this.periodGBPeriod.ResumeLayout(false);
            this.periodGBPeriod.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodSize)).EndInit();
            this.periodGBLabel.ResumeLayout(false);
            this.periodGBLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.periodLblSize)).EndInit();
            this.timeSettingsBox.ResumeLayout(false);
            this.timeGBClock.ResumeLayout(false);
            this.timeGBClock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clockSize)).EndInit();
            this.timeGBLabels.ResumeLayout(false);
            this.timeGBLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeLblSize)).EndInit();
            this.penaltySettingsBox.ResumeLayout(false);
            this.penaltyGBPenaltyData.ResumeLayout(false);
            this.penaltyGBPenaltyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyDataSize)).EndInit();
            this.penaltyGBLabels.ResumeLayout(false);
            this.penaltyGBLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penaltyLblSize)).EndInit();
            this.scoreBoardSettingsBox.ResumeLayout(false);
            this.scoreBoardSettingsBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.NumericUpDown scoreBWidth;
        private System.Windows.Forms.NumericUpDown scoreBHeight;
        private System.Windows.Forms.Button blackBcgrBtn;
        private System.Windows.Forms.Button closeScoreboardBtn;
        private System.Windows.Forms.Label widthLbl;
        private System.Windows.Forms.Label hghtLbl;
        private System.Windows.Forms.Button centerScoreBtn;
        private System.Windows.Forms.Button kv1Btn;
        private System.Windows.Forms.Button kv2Btn;
        private System.Windows.Forms.Button kv3Btn;
        private System.Windows.Forms.Button kv4Btn;
        private System.Windows.Forms.GroupBox scoreSettingBox;
        private System.Windows.Forms.GroupBox scoreGBScore;
        private System.Windows.Forms.ComboBox scoreSC;
        private System.Windows.Forms.NumericUpDown scoreSize;
        private System.Windows.Forms.GroupBox scoreGBLabels;
        private System.Windows.Forms.ComboBox scoreLC;
        private System.Windows.Forms.NumericUpDown scoreLblSize;
        private System.Windows.Forms.GroupBox periodSettingsBox;
        private System.Windows.Forms.GroupBox periodGBPeriod;
        private System.Windows.Forms.ComboBox periodPC;
        private System.Windows.Forms.NumericUpDown periodSize;
        private System.Windows.Forms.GroupBox periodGBLabel;
        private System.Windows.Forms.ComboBox periodLC;
        private System.Windows.Forms.NumericUpDown periodLblSize;
        private System.Windows.Forms.GroupBox timeSettingsBox;
        private System.Windows.Forms.GroupBox timeGBClock;
        private System.Windows.Forms.ComboBox timeCC;
        private System.Windows.Forms.NumericUpDown clockSize;
        private System.Windows.Forms.GroupBox timeGBLabels;
        private System.Windows.Forms.ComboBox timeLC;
        private System.Windows.Forms.NumericUpDown timeLblSize;
        private System.Windows.Forms.GroupBox penaltySettingsBox;
        private System.Windows.Forms.GroupBox penaltyGBPenaltyData;
        private System.Windows.Forms.ComboBox penaltyPDC;
        private System.Windows.Forms.NumericUpDown penaltyDataSize;
        private System.Windows.Forms.GroupBox penaltyGBLabels;
        private System.Windows.Forms.ComboBox penaltyLC;
        private System.Windows.Forms.NumericUpDown penaltyLblSize;
        private System.Windows.Forms.GroupBox scoreBoardSettingsBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label backgroundColorLbl;
        private System.Windows.Forms.ComboBox backgrClr;
        private System.Windows.Forms.Button importSettings;
        private System.Windows.Forms.Button exportSettings;
        private System.Windows.Forms.TextBox importPath;
    }
}

