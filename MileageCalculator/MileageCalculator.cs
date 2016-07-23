using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class MileageCalculator : Form
    {
        int startingMileage, endingMileage;
        double milesTraveled, amountOwed;
        double reimburseRate = .39;

        public MileageCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            startingMileage = (int)startMileageVal.Value;
            endingMileage = (int)endMileageVal.Value;

            if (startingMileage <= endingMileage)
            {
                milesTraveled = endingMileage - startingMileage;
                amountOwed = milesTraveled * reimburseRate;
                actualOwedLabel.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("The starting mielage must be less than the ending mileage", "Cannot Calculate Mileage");

            }

        }

        private void milesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled + " miles", "Miles Traveled");
        }

    }
}