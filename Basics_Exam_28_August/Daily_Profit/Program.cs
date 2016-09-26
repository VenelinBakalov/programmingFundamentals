using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workingDays = int.Parse(Console.ReadLine());
            double dailyProfit = double.Parse(Console.ReadLine());
            double dollarsToLeva = double.Parse(Console.ReadLine());

            double monthlyProfit = workingDays * dailyProfit;
            double yearProfit = monthlyProfit * 12 + monthlyProfit * 2.5;
            double taxes = yearProfit * 0.25;
            double pureProfit = (yearProfit - taxes) * dollarsToLeva;
            double pureDailyProfit = pureProfit / 365;

            Console.WriteLine(Math.Round(pureDailyProfit, 2));

        }
    }
}
