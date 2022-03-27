using System.ComponentModel;
using System.Windows.Forms;

namespace Scoreboard.Forms.Statistics
{
    partial class SetPenaltyForm
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
            this.selectPlayer = new System.Windows.Forms.ComboBox();
            this.penaltyTimesCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pMinutes = new System.Windows.Forms.NumericUpDown();
            this.pSeconds = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.playerNumber = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.savePenaltyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSeconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumber)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPlayer
            // 
            this.selectPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectPlayer.FormattingEnabled = true;
            this.selectPlayer.Location = new System.Drawing.Point(17, 58);
            this.selectPlayer.Name = "selectPlayer";
            this.selectPlayer.Size = new System.Drawing.Size(121, 21);
            this.selectPlayer.TabIndex = 0;
            this.selectPlayer.SelectedIndexChanged += new System.EventHandler(this.SelectPlayerSelectedIndexChanged);
            // 
            // penaltyTimesCombo
            // 
            this.penaltyTimesCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.penaltyTimesCombo.FormattingEnabled = true;
            this.penaltyTimesCombo.Location = new System.Drawing.Point(17, 58);
            this.penaltyTimesCombo.Name = "penaltyTimesCombo";
            this.penaltyTimesCombo.Size = new System.Drawing.Size(121, 21);
            this.penaltyTimesCombo.TabIndex = 1;
            this.penaltyTimesCombo.SelectedIndexChanged += new System.EventHandler(this.PenaltyTimesComboSelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select player:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select length:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 85;
            this.label11.Text = "Seconds:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Minutes:";
            // 
            // pMinutes
            // 
            this.pMinutes.Location = new System.Drawing.Point(27, 58);
            this.pMinutes.Name = "pMinutes";
            this.pMinutes.Size = new System.Drawing.Size(65, 20);
            this.pMinutes.TabIndex = 82;
            // 
            // pSeconds
            // 
            this.pSeconds.Location = new System.Drawing.Point(134, 58);
            this.pSeconds.Name = "pSeconds";
            this.pSeconds.Size = new System.Drawing.Size(59, 20);
            this.pSeconds.TabIndex = 83;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.pMinutes);
            this.groupBox1.Controls.Add(this.pSeconds);
            this.groupBox1.Location = new System.Drawing.Point(39, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 107);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom length";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.penaltyTimesCombo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(278, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 107);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "From preset menu";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 189);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(462, 178);
            this.groupBox3.TabIndex = 88;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Length";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(12, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 152);
            this.groupBox4.TabIndex = 89;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select penalty for player";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.playerNumber);
            this.groupBox6.Location = new System.Drawing.Point(39, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(209, 103);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Custom player";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Player number:";
            // 
            // playerNumber
            // 
            this.playerNumber.Location = new System.Drawing.Point(27, 58);
            this.playerNumber.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.playerNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.playerNumber.Name = "playerNumber";
            this.playerNumber.Size = new System.Drawing.Size(74, 20);
            this.playerNumber.TabIndex = 86;
            this.playerNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.selectPlayer);
            this.groupBox5.Location = new System.Drawing.Point(278, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(166, 103);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Select from DB";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(277, 395);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 91;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // savePenaltyBtn
            // 
            this.savePenaltyBtn.Location = new System.Drawing.Point(146, 395);
            this.savePenaltyBtn.Name = "savePenaltyBtn";
            this.savePenaltyBtn.Size = new System.Drawing.Size(75, 23);
            this.savePenaltyBtn.TabIndex = 90;
            this.savePenaltyBtn.Text = "Save";
            this.savePenaltyBtn.UseVisualStyleBackColor = true;
            this.savePenaltyBtn.Click += new System.EventHandler(this.SavePenaltyBtnClick);
            // 
            // SetPenaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 435);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.savePenaltyBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SetPenaltyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select penalty info";
            ((System.ComponentModel.ISupportInitialize)(this.pMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pSeconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerNumber)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox selectPlayer;
        private ComboBox penaltyTimesCombo;
        private Label label1;
        private Label label2;
        private Label label11;
        private Label label10;
        private NumericUpDown pMinutes;
        private NumericUpDown pSeconds;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private Label label3;
        private NumericUpDown playerNumber;
        private GroupBox groupBox5;
        private Button cancelBtn;
        private Button savePenaltyBtn;
    }
}