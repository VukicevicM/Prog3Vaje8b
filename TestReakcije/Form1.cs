using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestReakcije
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Stopwatch stopwatch = new Stopwatch();
        private Timer waitTimer = new Timer();
        private bool isGreen = false;

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Red;
            lblReactionTime.Visible = false;
            btnReset.Visible = false;

            waitTimer.Interval = random.Next(3000, 7001); // 3 to 7 seconds
            waitTimer.Tick += WaitTimer_Tick;
            waitTimer.Start();
        }

        private void WaitTimer_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
            isGreen = true;
            stopwatch.Restart();
            waitTimer.Stop();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isGreen) return;

            stopwatch.Stop();
            double reactionTime = stopwatch.Elapsed.TotalMilliseconds;
            lblReactionTime.Text = $"Čas reakcije: {reactionTime:F0} ms";
            lblReactionTime.Visible = true;
            btnReset.Visible = true;
            isGreen = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            lblReactionTime.Visible = false;
            btnReset.Visible = false;
            waitTimer.Interval = random.Next(3000, 7001);
            waitTimer.Start();
        }
    }
}
