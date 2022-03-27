namespace Scoreboard.Forms.DBForms
{
    partial class CreateTeamForm
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
            this.TeamName = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.VideoPath = new System.Windows.Forms.TextBox();
            this.SelectPathVideo = new System.Windows.Forms.Button();
            this.SelectPathLogo = new System.Windows.Forms.Button();
            this.LogoPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TeamName
            // 
            this.TeamName.Location = new System.Drawing.Point(61, 61);
            this.TeamName.Name = "TeamName";
            this.TeamName.Size = new System.Drawing.Size(187, 20);
            this.TeamName.TabIndex = 0;
            // 
            // Create
            // 
            this.Create.Location = new System.Drawing.Point(123, 209);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(75, 23);
            this.Create.TabIndex = 1;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(213, 209);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // VideoPath
            // 
            this.VideoPath.Location = new System.Drawing.Point(61, 100);
            this.VideoPath.Name = "VideoPath";
            this.VideoPath.Size = new System.Drawing.Size(187, 20);
            this.VideoPath.TabIndex = 3;
            // 
            // SelectPathVideo
            // 
            this.SelectPathVideo.Location = new System.Drawing.Point(277, 100);
            this.SelectPathVideo.Name = "SelectPathVideo";
            this.SelectPathVideo.Size = new System.Drawing.Size(75, 23);
            this.SelectPathVideo.TabIndex = 4;
            this.SelectPathVideo.Text = "Path";
            this.SelectPathVideo.UseVisualStyleBackColor = true;
            this.SelectPathVideo.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // SelectPathLogo
            // 
            this.SelectPathLogo.Location = new System.Drawing.Point(277, 144);
            this.SelectPathLogo.Name = "SelectPathLogo";
            this.SelectPathLogo.Size = new System.Drawing.Size(75, 23);
            this.SelectPathLogo.TabIndex = 6;
            this.SelectPathLogo.Text = "Path";
            this.SelectPathLogo.UseVisualStyleBackColor = true;
            this.SelectPathLogo.Click += new System.EventHandler(this.SelectPathLogo_Click);
            // 
            // LogoPath
            // 
            this.LogoPath.Location = new System.Drawing.Point(61, 144);
            this.LogoPath.Name = "LogoPath";
            this.LogoPath.Size = new System.Drawing.Size(187, 20);
            this.LogoPath.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Team EventName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Logo Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Video Path:";
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 277);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectPathLogo);
            this.Controls.Add(this.LogoPath);
            this.Controls.Add(this.SelectPathVideo);
            this.Controls.Add(this.VideoPath);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.TeamName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CreateTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create team";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamName;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox VideoPath;
        private System.Windows.Forms.Button SelectPathVideo;
        private System.Windows.Forms.Button SelectPathLogo;
        private System.Windows.Forms.TextBox LogoPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}