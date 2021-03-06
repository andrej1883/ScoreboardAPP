using System.ComponentModel;
using System.Windows.Forms;

namespace Scoreboard.Forms.DBForms
{
    partial class LoadAds
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
            this.done = new System.Windows.Forms.Button();
            this.removeVideo = new System.Windows.Forms.Button();
            this.addVideo = new System.Windows.Forms.Button();
            this.teamListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.advListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advListBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advListBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(673, 395);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(108, 23);
            this.done.TabIndex = 19;
            this.done.Text = "Done";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.DoneClick);
            // 
            // removeVideo
            // 
            this.removeVideo.Location = new System.Drawing.Point(677, 113);
            this.removeVideo.Name = "removeVideo";
            this.removeVideo.Size = new System.Drawing.Size(104, 23);
            this.removeVideo.TabIndex = 17;
            this.removeVideo.Text = "Remove Video";
            this.removeVideo.UseVisualStyleBackColor = true;
            this.removeVideo.Click += new System.EventHandler(this.RemoveVideoClick);
            // 
            // addVideo
            // 
            this.addVideo.Location = new System.Drawing.Point(677, 68);
            this.addVideo.Name = "addVideo";
            this.addVideo.Size = new System.Drawing.Size(104, 23);
            this.addVideo.TabIndex = 16;
            this.addVideo.Text = "Add Video";
            this.addVideo.UseVisualStyleBackColor = true;
            this.addVideo.Click += new System.EventHandler(this.AddVideoClick);
            // 
            // teamListBindingSource
            // 
            this.teamListBindingSource.DataMember = "TeamList";
            this.teamListBindingSource.DataSource = this.databaseBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pathDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.advListBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 426);
            this.dataGridView1.TabIndex = 20;
            // 
            // advListBindingSource
            // 
            this.advListBindingSource.DataMember = "AdvList";
            this.advListBindingSource.DataSource = this.databaseBindingSource;
            // 
            // advListBindingSource1
            // 
            this.advListBindingSource1.DataMember = "AdvList";
            this.advListBindingSource1.DataSource = this.databaseBindingSource;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = typeof(Scoreboard.Classes.Database.Database);
            // 
            // databaseBindingSource1
            // 
            this.databaseBindingSource1.DataSource = typeof(Scoreboard.Classes.Database.Database);
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.Width = 400;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // LoadAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.done);
            this.Controls.Add(this.removeVideo);
            this.Controls.Add(this.addVideo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoadAds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load advertisements";
            ((System.ComponentModel.ISupportInitialize)(this.teamListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advListBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button done;
        private Button removeVideo;
        private Button addVideo;
        private BindingSource databaseBindingSource;
        private BindingSource teamListBindingSource;
        private BindingSource databaseBindingSource1;
        private DataGridView dataGridView1;
        private BindingSource advListBindingSource;
        private BindingSource advListBindingSource1;
        private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Column1;
    }
}