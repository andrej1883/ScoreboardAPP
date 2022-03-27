using System.ComponentModel;
using System.Windows.Forms;

namespace Scoreboard.Forms.DBForms
{
    partial class LoadTeamDataForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AddTeam = new System.Windows.Forms.Button();
            this.RemoveTeam = new System.Windows.Forms.Button();
            this.EditTeamPlayers = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.videoPathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogoPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamName,
            this.videoPathDataGridViewTextBoxColumn,
            this.LogoPath});
            this.dataGridView1.DataSource = this.teamListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 404);
            this.dataGridView1.TabIndex = 0;
            // 
            // teamListBindingSource
            // 
            this.teamListBindingSource.DataMember = "TeamList";
            this.teamListBindingSource.DataSource = this.databaseBindingSource;
            // 
            // AddTeam
            // 
            this.AddTeam.Location = new System.Drawing.Point(656, 68);
            this.AddTeam.Name = "AddTeam";
            this.AddTeam.Size = new System.Drawing.Size(104, 23);
            this.AddTeam.TabIndex = 4;
            this.AddTeam.Text = "Add Team";
            this.AddTeam.UseVisualStyleBackColor = true;
            this.AddTeam.Click += new System.EventHandler(this.AddTeamClick);
            // 
            // RemoveTeam
            // 
            this.RemoveTeam.Location = new System.Drawing.Point(656, 113);
            this.RemoveTeam.Name = "RemoveTeam";
            this.RemoveTeam.Size = new System.Drawing.Size(104, 23);
            this.RemoveTeam.TabIndex = 5;
            this.RemoveTeam.Text = "Remove Team";
            this.RemoveTeam.UseVisualStyleBackColor = true;
            this.RemoveTeam.Click += new System.EventHandler(this.RemoveTeamClick);
            // 
            // EditTeamPlayers
            // 
            this.EditTeamPlayers.Location = new System.Drawing.Point(656, 231);
            this.EditTeamPlayers.Name = "EditTeamPlayers";
            this.EditTeamPlayers.Size = new System.Drawing.Size(104, 23);
            this.EditTeamPlayers.TabIndex = 6;
            this.EditTeamPlayers.Text = "Edit Players";
            this.EditTeamPlayers.UseVisualStyleBackColor = true;
            this.EditTeamPlayers.Click += new System.EventHandler(this.EditTeamPlayersClick);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(656, 390);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(108, 23);
            this.OK.TabIndex = 14;
            this.OK.Text = "Done";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OkClick);
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(Scoreboard.Classes.Database.Database);
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "Name";
            this.TeamName.HeaderText = "Name";
            this.TeamName.Name = "TeamName";
            // 
            // videoPathDataGridViewTextBoxColumn
            // 
            this.videoPathDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.videoPathDataGridViewTextBoxColumn.DataPropertyName = "VideoPath";
            this.videoPathDataGridViewTextBoxColumn.HeaderText = "VideoPath";
            this.videoPathDataGridViewTextBoxColumn.Name = "videoPathDataGridViewTextBoxColumn";
            this.videoPathDataGridViewTextBoxColumn.Width = 200;
            // 
            // LogoPath
            // 
            this.LogoPath.DataPropertyName = "LogoPath";
            this.LogoPath.HeaderText = "LogoPath";
            this.LogoPath.Name = "LogoPath";
            this.LogoPath.Width = 200;
            // 
            // LoadTeamDataForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.EditTeamPlayers);
            this.Controls.Add(this.RemoveTeam);
            this.Controls.Add(this.AddTeam);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "LoadTeamDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit teams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddTeam;
        private Button RemoveTeam;
        private BindingSource teamListBindingSource;
        private BindingSource databaseBindingSource;
        private Button EditTeamPlayers;
        private Button OK;
        private DataGridViewTextBoxColumn TeamName;
        private DataGridViewTextBoxColumn videoPathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn LogoPath;
    }
}