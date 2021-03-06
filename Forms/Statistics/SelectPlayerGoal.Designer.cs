using System.ComponentModel;
using System.Windows.Forms;

namespace Scoreboard.Forms.Statistics
{
    partial class SelectPlayerGoal
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
            this.playerGoal = new System.Windows.Forms.ComboBox();
            this.playerA1 = new System.Windows.Forms.ComboBox();
            this.playerA2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.saveGoalBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerGoal
            // 
            this.playerGoal.FormattingEnabled = true;
            this.playerGoal.Location = new System.Drawing.Point(31, 58);
            this.playerGoal.Name = "playerGoal";
            this.playerGoal.Size = new System.Drawing.Size(121, 21);
            this.playerGoal.TabIndex = 0;
            // 
            // playerA1
            // 
            this.playerA1.FormattingEnabled = true;
            this.playerA1.Location = new System.Drawing.Point(158, 58);
            this.playerA1.Name = "playerA1";
            this.playerA1.Size = new System.Drawing.Size(121, 21);
            this.playerA1.TabIndex = 1;
            // 
            // playerA2
            // 
            this.playerA2.FormattingEnabled = true;
            this.playerA2.Location = new System.Drawing.Point(285, 58);
            this.playerA2.Name = "playerA2";
            this.playerA2.Size = new System.Drawing.Size(121, 21);
            this.playerA2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Goal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Assistance 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Assistance 2:";
            // 
            // saveGoalBtn
            // 
            this.saveGoalBtn.Location = new System.Drawing.Point(116, 122);
            this.saveGoalBtn.Name = "saveGoalBtn";
            this.saveGoalBtn.Size = new System.Drawing.Size(75, 23);
            this.saveGoalBtn.TabIndex = 6;
            this.saveGoalBtn.Text = "Save";
            this.saveGoalBtn.UseVisualStyleBackColor = true;
            this.saveGoalBtn.Click += new System.EventHandler(this.SaveGoalBtnClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(247, 122);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CancelBtnClick);
            // 
            // SelectPlayerGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 187);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveGoalBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerA2);
            this.Controls.Add(this.playerA1);
            this.Controls.Add(this.playerGoal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SelectPlayerGoal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select goal info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox playerGoal;
        private ComboBox playerA1;
        private ComboBox playerA2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button saveGoalBtn;
        private Button cancelBtn;
    }
}