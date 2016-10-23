using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int runnersCount = int.Parse(Console.ReadLine());
            int lapsCount = int.Parse(Console.ReadLine());
            int trackLength = int.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            int totalCapacity = trackCapacity * days;

            if (runnersCount > totalCapacity)
            {
                runnersCount = totalCapacity;
            }

            long totalLaps = (long)runnersCount * lapsCount;
            long totalLengthInM = trackLength * totalLaps;

            long totalLengthInKm = totalLengthInM / 1000;

            decimal moneyRaised = moneyPerKm * totalLengthInKm;

            Console.WriteLine($"Money raised: {moneyRaised:f2}");
        }
    }
}
