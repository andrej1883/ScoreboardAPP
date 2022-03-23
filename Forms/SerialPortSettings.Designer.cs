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
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connectStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // activePorts
            // 
            this.activePorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activePorts.FormattingEnabled = true;
            this.activePorts.Location = new System.Drawing.Point(118, 89);
            this.activePorts.Name = "activePorts";
            this.activePorts.Size = new System.Drawing.Size(121, 21);
            this.activePorts.TabIndex = 0;
            // 
            // connectToPort
            // 
            this.connectToPort.Location = new System.Drawing.Point(105, 263);
            this.connectToPort.Name = "connectToPort";
            this.connectToPort.Size = new System.Drawing.Size(75, 23);
            this.connectToPort.TabIndex = 1;
            this.connectToPort.Text = "Connect";
            this.connectToPort.UseVisualStyleBackColor = true;
            this.connectToPort.Click += new System.EventHandler(this.connectToPort_Click);
            // 
            // disconnectPort
            // 
            this.disconnectPort.Location = new System.Drawing.Point(206, 262);
            this.disconnectPort.Name = "disconnectPort";
            this.disconnectPort.Size = new System.Drawing.Size(75, 23);
            this.disconnectPort.TabIndex = 2;
            this.disconnectPort.Text = "Disconnect";
            this.disconnectPort.UseVisualStyleBackColor = true;
            this.disconnectPort.Click += new System.EventHandler(this.disconnectPort_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.Location = new System.Drawing.Point(319, 261);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(75, 23);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send message";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ports:";
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Location = new System.Drawing.Point(105, 220);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(78, 13);
            this.connectStatus.TabIndex = 5;
            this.connectStatus.Text = "Not connected";
            // 
            // SerialPortSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 322);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
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
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label connectStatus;
    }
}