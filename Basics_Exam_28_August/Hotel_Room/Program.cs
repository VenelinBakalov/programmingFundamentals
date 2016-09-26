using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int daysToStay = int.Parse(Console.ReadLine());
            double pricePerDayStudio = 0.0;
            double pricePerDayApartment = 0.0;
            double discountStudio = 0.0;
            double discountApartment = 0.0;

            if (month == "may" || month == "october")
            {
                pricePerDayStudio = 50;
                pricePerDayApartment = 65;
                if (daysToStay > 7)
                {
                    discountStudio = 0.05;
                }
                if (daysToStay > 14)
                {
                    discountStudio = 0.3;
                }
            }
            else if (month == "june" || month == "september")
            {
                pricePerDayStudio = 75.20;
                pricePerDayApartment = 68.70;
                if (daysToStay > 14)
                {
                    discountStudio = 0.20;
                }
            }
            else if (month == "july" || month == "august")
            {
                pricePerDayStudio = 76;
                pricePerDayApartment = 77;
            }

            if (daysToStay > 14)
            {
                discountApartment = 0.10;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", daysToStay * pricePerDayApartment * (1 - discountApartment));
            Console.WriteLine("Studio: {0:f2} lv.", daysToStay * pricePerDayStudio * (1 - discountStudio));
        }
    }
}
