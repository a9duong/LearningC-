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
    public partial class MainForm : Form
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

        public MainForm()
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
            bob.ReceiveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(10));
            UpdateForm();
        }
    }
}
