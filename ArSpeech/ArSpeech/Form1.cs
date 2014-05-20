using System;
using System.Drawing;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace ArSpeech
{
    public partial class Form1 : Form
    {
        SpeechRecognizer speechEngine;

        public Form1()
        {
            InitializeComponent();
        }

        void speechReco_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            ListenLabel.Text = e.Result.Text;
            if (e.Result.Text == "on")
            {
                ToggleLED(true);
            }
            else if (e.Result.Text == "off")
            {
                ToggleLED(false);
            }
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            speechEngine = new SpeechRecognizer();
            Choices onoffChoices = new Choices(new string[] { "on", "off" });
            GrammarBuilder grammarBuilder = new GrammarBuilder(onoffChoices);
            Grammar grammar = new Grammar(grammarBuilder);
            speechEngine.LoadGrammar(grammar);
            speechEngine.SpeechRecognized += speechReco_SpeechRecognized;
            speechEngine.Enabled = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            speechEngine.Enabled = false;
        }
    }
}
