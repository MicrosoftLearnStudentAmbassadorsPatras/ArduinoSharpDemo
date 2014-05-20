using Pop3;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ArMailAlert
{
    public partial class Form1 : Form
    {
        private int messageCount = 0;
        private int secondCount = 120;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnButton_Click(object sender, EventArgs e)
        {
            ToggleLED(true);
        }

        private void OffButton_Click(object sender, EventArgs e)
        {
            ToggleLED(false);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;
            CheckLabel.Text = string.Format("Checking again in: {0} sec", secondCount);
        }

        private void timer_Tick(object sender, EventArgs e)
        {            
            secondCount--;
            if (secondCount == 0)
            {
                int newMessageCount = CheckForEmails();

                ToggleLED(newMessageCount > messageCount);

                messageCount = newMessageCount;
                secondCount = 120;
            }
            CheckLabel.Text = string.Format("Checking again in: {0} sec", secondCount);
        }

        private void ToggleLED(bool on)
        {
            serial.Open();
            if (on)
            {
                serial.Write("1");
                LedPanel.BackColor = Color.DarkRed;
            }
            else
            {
                serial.Write("0");
                LedPanel.BackColor = Color.SlateGray;
            }
            serial.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            secondCount = 30;
        }

        int CheckForEmails()
        {
            Pop3Client pop3Client = new Pop3Client();
            pop3Client.Connect("pop-mail.outlook.com", "kgoutsos@outlook.com", "<ENTER PASSWORD HERE>", true);

            var messages = pop3Client.List();
            if (messages == null)
            {
                return 0;
            }

            return messages.Count();
        }
    }
}
