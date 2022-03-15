namespace Scoreboard.Forms.DBForms
{
    partial class CreatePlayerForm
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
            this.RemovePlayer = new System.Windows.Forms.Button();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.PLayersGW = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PlayerName = new System.Windows.Forms.TextBox();
            this.PlayerNumber = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PLayersGW)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.Location = new System.Drawing.Point(597, 325);
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Size = new System.Drawing.Size(108, 23);
            this.RemovePlayer.TabIndex = 11;
            this.RemovePlayer.Text = "Remove Player";
            this.RemovePlayer.UseVisualStyleBackColor = true;
            this.RemovePlayer.Click += new System.EventHandler(this.RemovePlayer_Click);
            // 
            // AddPlayer
            // 
            this.AddPlayer.Location = new System.Drawing.Point(65, 143);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(75, 23);
            this.AddPlayer.TabIndex = 10;
            this.AddPlayer.Text = "Add Player";
            this.AddPlayer.UseVisualStyleBackColor = true;
            this.AddPlayer.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // PLayersGW
            // 
            this.PLayersGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PLayersGW.Location = new System.Drawing.Point(12, 12);
            this.PLayersGW.Name = "PLayersGW";
            this.PLayersGW.Size = new System.Drawing.Size(425, 415);
            this.PLayersGW.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PlayerNumber);
            this.groupBox1.Controls.Add(this.PlayerName);
            this.groupBox1.Controls.Add(this.AddPlayer);
            this.groupBox1.Location = new System.Drawing.Point(547, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Player";
            // 
            // PlayerName
            // 
            this.PlayerName.Location = new System.Drawing.Point(50, 50);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(100, 20);
            this.PlayerName.TabIndex = 0;
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.Location = new System.Drawing.Point(50, 96);
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.Size = new System.Drawing.Size(100, 20);
            this.PlayerNumber.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(597, 374);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(108, 23);
            this.OK.TabIndex = 13;
            this.OK.Text = "Done";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Number:";
            // 
            // CreatePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RemovePlayer);
            this.Controls.Add(this.PLayersGW);
            this.Name = "CreatePlayerForm";
            this.Text = "CreatePlayerForm";
            this.Load += new System.EventHandler(this.CreatePlayerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PLayersGW)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RemovePlayer;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.DataGridView PLayersGW;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox PlayerNumber;
        private System.Windows.Forms.TextBox PlayerName;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}