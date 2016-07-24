using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerAlex
{
    public partial class Form1 : Form
    {
        Farmer alex;
        public Form1()
        {
            InitializeComponent();
            alex = new Farmer(15, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", alex.BagsOfFeed, alex.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            alex.NumberOfCows = (int)numericUpDown1.Value;
        }

    }
}
