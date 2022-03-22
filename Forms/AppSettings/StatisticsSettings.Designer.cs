namespace Scoreboard.Forms.AppSettings
{
    partial class StatisticsSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shotsBox = new System.Windows.Forms.CheckBox();
            this.faceOffsBox = new System.Windows.Forms.CheckBox();
            this.timeoutsBox = new System.Windows.Forms.CheckBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shotsBox);
            this.groupBox1.Controls.Add(this.faceOffsBox);
            this.groupBox1.Controls.Add(this.timeoutsBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(39, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active statistics";
            // 
            // shotsBox
            // 
            this.shotsBox.AutoSize = true;
            this.shotsBox.Checked = true;
            this.shotsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.shotsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.shotsBox.Location = new System.Drawing.Point(33, 108);
            this.shotsBox.Name = "shotsBox";
            this.shotsBox.Size = new System.Drawing.Size(119, 22);
            this.shotsBox.TabIndex = 5;
            this.shotsBox.Text = "Shots on goal";
            this.shotsBox.UseVisualStyleBackColor = true;
            this.shotsBox.CheckedChanged += new System.EventHandler(this.shotsBox_CheckedChanged);
            // 
            // faceOffsBox
            // 
            this.faceOffsBox.AutoSize = true;
            this.faceOffsBox.Checked = true;
            this.faceOffsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.faceOffsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.faceOffsBox.Location = new System.Drawing.Point(33, 74);
            this.faceOffsBox.Name = "faceOffsBox";
            this.faceOffsBox.Size = new System.Drawing.Size(90, 22);
            this.faceOffsBox.TabIndex = 4;
            this.faceOffsBox.Text = "Face-offs";
            this.faceOffsBox.UseVisualStyleBackColor = true;
            this.faceOffsBox.CheckedChanged += new System.EventHandler(this.faceOffsBox_CheckedChanged);
            // 
            // timeoutsBox
            // 
            this.timeoutsBox.AutoSize = true;
            this.timeoutsBox.Checked = true;
            this.timeoutsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.timeoutsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timeoutsBox.Location = new System.Drawing.Point(33, 41);
            this.timeoutsBox.Name = "timeoutsBox";
            this.timeoutsBox.Size = new System.Drawing.Size(89, 22);
            this.timeoutsBox.TabIndex = 3;
            this.timeoutsBox.Text = "Timeouts";
            this.timeoutsBox.UseVisualStyleBackColor = true;
            this.timeoutsBox.CheckedChanged += new System.EventHandler(this.timeoutsBox_CheckedChanged);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(166, 264);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 93;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // StatisticsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 322);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "StatisticsSettings";
            this.Text = "Statistics";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox shotsBox;
        private System.Windows.Forms.CheckBox faceOffsBox;
        private System.Windows.Forms.CheckBox timeoutsBox;
        private System.Windows.Forms.Button okBtn;
    }
}