using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerPartyCost
{
    public partial class Form1 : Form
    {

        DinnerParty dinnerParty;

        public Form1()
        {

            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value, healthyOptionCheckBox.Checked, fancyCheckBox.Checked);
            DisplayDinnerPartyCost();       
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int) numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthyOptionCheckBox.Checked);
            costDisplayLabel.Text = Cost.ToString("c");
        }

        private void fancyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyCheckBox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthyOptionCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(healthyOptionCheckBox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
