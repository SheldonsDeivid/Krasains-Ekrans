using System;
using System.Drawing;
using System.Windows.Forms;

namespace Krasains_Ekrans
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butBalts_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void butMelns_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void butZals_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void butZils_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

        }

        private void butRoza_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
    }
}
