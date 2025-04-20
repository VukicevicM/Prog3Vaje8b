using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeviInDesni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLevi_MouseDown(object sender, MouseEventArgs e)
        {
            labelNapis.Text = "<- pritisnjen";
        }

        private void btnLevi_MouseUp(object sender, MouseEventArgs e)
        {
            labelNapis.Text = "";
        }

        private void btnDesni_MouseDown(object sender, MouseEventArgs e)
        {
            labelNapis.Text = "pritisnjen ->";
        }

        private void btnDesni_MouseUp(object sender, MouseEventArgs e)
        {
            labelNapis.Text = "";
        }
    }
}
