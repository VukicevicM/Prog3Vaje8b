using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VozecaPloscad
{
    public partial class Form1 : Form
    {
        private int rectX = 10;
        private int rectY = 10;
        private int rectWidth = 25;
        private int rectHeight = 20;
        private int dx = 5; // Hitrost in smer

        public Form1()
        {
            InitializeComponent();
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                toggleButton.Text = "Gibanje";
            }
            else
            {
                timer.Start();
                toggleButton.Text = "Ustavi";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Premik ploščadi
            rectX += dx;

            // Preveri meje
            if (rectX + rectWidth >= 300)
            {
                rectX = 300 - rectWidth;
                dx = -dx;
            }
            else if (rectX <= 10)
            {
                rectX = 10;
                dx = -dx;
            }

            canvasPanel.Invalidate(); // Povzroči ponovno risanje
        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Blue, rectX, rectY, rectWidth, rectHeight);
        }

    }
}
