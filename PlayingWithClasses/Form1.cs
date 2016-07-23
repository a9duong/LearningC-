using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingWithClasses
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.name + " has $" + joe.cash;
            bobsCashLabel.Text = bob.name + " has $" + bob.cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            joe = new Guy(50, "Joe");
            bob = new Guy();
            bob.name = "Bob";
            bob.cash = 100;
            UpdateForm();
        }

        private void giveButton_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(-5);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
        }

        private void receiveButton_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            if (joe.cash < 10)
            {
                MessageBox.Show("Joe is poor man, cut him some slack");
            }
            else
            {
                joe.cash -= 10;
                bob.cash += 10;
                UpdateForm();
            }
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            if (bob.cash < 10)
            {
                MessageBox.Show("Bob is poor bro, cut it out");
            }
            else
            {
                bob.cash -= 10;
                joe.cash += 10;
                UpdateForm();
            }
        }
    }
}
