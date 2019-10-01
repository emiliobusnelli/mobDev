using System;
namespace DateNite.model
{
    public class DateCalculator
    {
        public DateCalculator()
        {
        }

        public string CoffeeCost
        {
            get;
            set;
        }

        public string DinnerCost
        {
            get;
            set;
        }

        public string MovieCost
        {
            get;
            set;
        }

        public string GetTotalCost()
        {
            decimal decCoffee, decDinner, decMovie;

            if(!decimal.TryParse(CoffeeCost, out decCoffee)){
                if(string.IsNullOrEmpty(CoffeeCost)){
                    throw new Exception("Invalid Coffee Cost");
                }

            }

            if (!decimal.TryParse(DinnerCost, out decDinner))
            {
                if (string.IsNullOrEmpty(DinnerCost))
                {
                    throw new Exception("Invalid Dinner Cost");
                }

            }

            if (!decimal.TryParse(MovieCost, out decMovie))
            {
                if (string.IsNullOrEmpty(MovieCost))
                {
                    throw new Exception("Invalid Movie Cost");
                }

            }



            return (decCoffee+decDinner+decMovie).ToString("C");
        }

    }
}
