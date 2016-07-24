using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerPartyCost
{
    class DinnerParty
    {
        private int numberOfPeople;
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfBeveragesPerPerson, CostOfDecorations;

        public void CalculateCostOfDecorations(bool fancy)
        {
            if (fancy)
            {
                CostOfDecorations = (numberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (numberOfPeople * 7.50M) + 30M;
            }
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }


        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = CostOfDecorations + ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * numberOfPeople);

            if (healthyOption)
            {
                return totalCost * 0.95M;
            }
            else
            {
                return totalCost;
            }
        }
        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }
    }
}
