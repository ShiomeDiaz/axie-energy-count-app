using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intro.net
{
    public partial class Form1 : Form
    { int initCountEnergy = 3;
      int initCountRound = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void btMinusOne_Click(object sender, EventArgs e)
        {
            if (initCountEnergy > 0)
                initCountEnergy = initCountEnergy - 1;
            label1.Text = Convert.ToString(initCountEnergy);


        }

        private void btPlusOne_Click(object sender, EventArgs e)
        {
            if (initCountEnergy < 10)
                initCountEnergy = initCountEnergy + 1;
            label1.Text = Convert.ToString(initCountEnergy);

        }
        private void btNextRound_Click(object sender, EventArgs e)
        {
            if (initCountEnergy < 10) {
                initCountEnergy = initCountEnergy + 2;
            }
            if (initCountEnergy > 10)
            {
                initCountEnergy = 10;
            }

            label1.Text = Convert.ToString(initCountEnergy);
            initCountRound = initCountRound + 1;
            labelCountRound.Text = Convert.ToString(initCountRound);
        }

        private void btNewGame_Click(object sender, EventArgs e)
        {
            initCountEnergy = 3;
            label1.Text = Convert.ToString(initCountEnergy);
            initCountRound = 1;
            labelCountRound.Text = Convert.ToString(initCountRound);
        }

        private void labelCountRound_Click(object sender, EventArgs e)
        {

        }

        private void labelRound_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    } 
}
