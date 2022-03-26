namespace Scoreboard.Forms
{
    partial class SerialPortSettings
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
            this.activePorts = new System.Windows.Forms.ComboBox();
            this.connectToPort = new System.Windows.Forms.Button();
            this.disconnectPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // activePorts
            // 
            this.activePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activePorts.FormattingEnabled = true;
            this.activePorts.Location = new System.Drawing.Point(137, 41);
            this.activePorts.Name = "activePorts";
            this.activePorts.Size = new System.Drawing.Size(121, 21);
            this.activePorts.TabIndex = 0;
            // 
            // connectToPort
            // 
            this.connectToPort.Location = new System.Drawing.Point(286, 40);
            this.connectToPort.Name = "connectToPort";
            this.connectToPort.Size = new System.Drawing.Size(75, 23);
            this.connectToPort.TabIndex = 1;
            this.connectToPort.Text = "Connect";
            this.connectToPort.UseVisualStyleBackColor = true;
            this.connectToPort.Click += new System.EventHandler(this.connectToPort_Click);
            // 
            // disconnectPort
            // 
            this.disconnectPort.Location = new System.Drawing.Point(286, 80);
            this.disconnectPort.Name = "disconnectPort";
            this.disconnectPort.Size = new System.Drawing.Size(75, 23);
            this.disconnectPort.TabIndex = 2;
            this.disconnectPort.Text = "Disconnect";
            this.disconnectPort.UseVisualStyleBackColor = true;
            this.disconnectPort.Click += new System.EventHandler(this.disconnectPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ports:";
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(137, 85);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(78, 13);
            this.connectStatus.TabIndex = 5;
            this.connectStatus.Text = "Not connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ports status:";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(126, 141);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 7;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(227, 141);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // SerialPortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 186);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.disconnectPort);
            this.Controls.Add(this.connectToPort);
            this.Controls.Add(this.activePorts);
            this.Name = "SerialPortSettings";
            this.Text = "SerialPortSettings";
            this.Load += new System.EventHandler(this.SerialPortSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox activePorts;
        private System.Windows.Forms.Button connectToPort;
        private System.Windows.Forms.Button disconnectPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}