using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetanjeKocke
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            lblDice.Visible = false; // hide dice at start
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            // Generate number 1–6
            int roll = random.Next(1, 7);
            lblDice.Text = roll.ToString();
            lblDice.Visible = true;

            // Position dice randomly in upper part of the form (top 60%)
            int margin = 10;
            int maxX = this.ClientSize.Width - lblDice.Width;
            int maxY = (int)(this.ClientSize.Height * 0.6) - lblDice.Height;

            int x = random.Next(margin, Math.Max(margin + 1, maxX));
            int y = random.Next(margin, Math.Max(margin + 1, maxY));

            lblDice.Location = new Point(x, y);
        }
    }
}
