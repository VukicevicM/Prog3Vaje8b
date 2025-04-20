using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StevecKlikov
{
    public partial class Form1 : Form
    {
        private int klikStevec = 0;

        public Form1()
        {
            InitializeComponent();

            // Nastavi začetno vrednost
            labelCounter.Text = "Število klikov: 0";

            // Doda obravnavo klika za formo
            this.MouseClick += Form_MouseClick;

            // Doda obravnavo klika za vse obstoječe kontrole
            foreach (Control c in this.Controls)
            {
                c.MouseClick += Form_MouseClick;
            }

            // Doda obravnavo klika tudi za nove kontrole, če jih dodamo med runtime
            this.ControlAdded += (s, e) => e.Control.MouseClick += Form_MouseClick;
        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            klikStevec++;
            labelCounter.Text = $"Število klikov: {klikStevec}";
        }
    }
}
