using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadaniSodo
{
    public partial class Form1 : Form
    {
        private int currentNumber = 0;
        private int score = 0;
        private int clicks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start(); // Začni števec ob zagonu
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentNumber++;
            numberButton.Text = currentNumber.ToString();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            clicks++;

            if (currentNumber % 2 == 0)
            {
                score++;
            }

            // Posodobi napisa
            scoreLabel.Text = $"Točke: {score}";
            clicksLabel.Text = $"Kliki: {clicks}";
        }
    }
}
