﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithClasses
{
    class Guy
    {
        public string name;
        public int cash;

        public int GiveCash(int amount){
            if (amount <= cash && amount > 0){
                cash -= amount;
                return amount;
            } else {
                System.Windows.Forms.MessageBox.Show("I don't have enough cash to give you " + amount + " " + name + " says...");
                return 0;
            }
        }

        public int ReceiveCash(int amount){
            if (amount > 0){
                cash += amount;
                return amount;
            } else {
                System.Windows.Forms.MessageBox.Show(amount + " isn't an amount I'll take " + name +  " says...");
                return 0;
            }
        }

        public Guy(int c, string n)
        {
            cash = c;
            name = n;
        }

        public Guy()
        {
        }

    }
}
