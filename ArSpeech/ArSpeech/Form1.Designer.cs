namespace ArSpeech
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.StartButton = new System.Windows.Forms.Button();
            this.LedPanel = new System.Windows.Forms.Panel();
            this.StopButton = new System.Windows.Forms.Button();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.ListenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 12);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(143, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start Listening";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LedPanel
            // 
            this.LedPanel.BackColor = System.Drawing.Color.SlateGray;
            this.LedPanel.Location = new System.Drawing.Point(178, 24);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(30, 28);
            this.LedPanel.TabIndex = 7;
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(12, 41);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(143, 23);
            this.StopButton.TabIndex = 8;
            this.StopButton.Text = "Stop Listening";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // serial
            // 
            this.serial.PortName = "COM8";
            // 
            // ListenLabel
            // 
            this.ListenLabel.AutoSize = true;
            this.ListenLabel.Location = new System.Drawing.Point(12, 72);
            this.ListenLabel.Name = "ListenLabel";
            this.ListenLabel.Size = new System.Drawing.Size(107, 13);
            this.ListenLabel.TabIndex = 9;
            this.ListenLabel.Text = "Nothing to listen to to";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 104);
            this.Controls.Add(this.ListenLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.LedPanel);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel LedPanel;
        private System.Windows.Forms.Button StopButton;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Label ListenLabel;
    }
}

