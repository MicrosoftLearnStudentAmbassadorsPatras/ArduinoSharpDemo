namespace ArMailAlert
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
            this.OnButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.serial = new System.IO.Ports.SerialPort(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.RushButton = new System.Windows.Forms.Button();
            this.LedPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OnButton
            // 
            this.OnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OnButton.ForeColor = System.Drawing.Color.Green;
            this.OnButton.Location = new System.Drawing.Point(13, 7);
            this.OnButton.Name = "OnButton";
            this.OnButton.Size = new System.Drawing.Size(75, 31);
            this.OnButton.TabIndex = 0;
            this.OnButton.Text = "ΟΝ";
            this.OnButton.UseVisualStyleBackColor = true;
            this.OnButton.Click += new System.EventHandler(this.OnButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OffButton.ForeColor = System.Drawing.Color.DarkRed;
            this.OffButton.Location = new System.Drawing.Point(94, 7);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(75, 31);
            this.OffButton.TabIndex = 1;
            this.OffButton.Text = "OFF";
            this.OffButton.UseVisualStyleBackColor = true;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // serial
            // 
            this.serial.PortName = "COM8";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(13, 44);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(156, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start checking";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Location = new System.Drawing.Point(12, 70);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(0, 13);
            this.CheckLabel.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // RushButton
            // 
            this.RushButton.Location = new System.Drawing.Point(176, 44);
            this.RushButton.Name = "RushButton";
            this.RushButton.Size = new System.Drawing.Size(30, 23);
            this.RushButton.TabIndex = 5;
            this.RushButton.Text = "30";
            this.RushButton.UseVisualStyleBackColor = true;
            this.RushButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // LedPanel
            // 
            this.LedPanel.BackColor = System.Drawing.Color.SlateGray;
            this.LedPanel.Location = new System.Drawing.Point(176, 10);
            this.LedPanel.Name = "LedPanel";
            this.LedPanel.Size = new System.Drawing.Size(30, 28);
            this.LedPanel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 103);
            this.Controls.Add(this.LedPanel);
            this.Controls.Add(this.RushButton);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.OnButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnButton;
        private System.Windows.Forms.Button OffButton;
        private System.IO.Ports.SerialPort serial;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button RushButton;
        private System.Windows.Forms.Panel LedPanel;
    }
}

