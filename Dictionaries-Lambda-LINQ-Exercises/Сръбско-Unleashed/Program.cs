using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сръбско_Unleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> cityProfit = new Dictionary<string, Dictionary<string, long>>();
            
            string[] singerInfo = Console.ReadLine().Split('@').ToArray();

            while (!singerInfo[0].Equals("End"))
            {
                string[] singerArr = singerInfo[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] city = singerInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string singer = string.Join(" ", singerArr);

                for (int i = 0; i < city.Length; i++)
                {
                    try
                    {
                        long profit = GetProfit(city[i], city[i + 1]);

                        List<string> cityName = new List<string>();
                        for (int j = 0; j < i; j++)
                        {
                            cityName.Add(city[j]);
                        }

                        string newCity = string.Join(" ", cityName);

                        InsertCity(cityProfit, newCity);
                        InsertProfit(cityProfit, newCity, singer, profit);

                        break;
                    }
                    catch (Exception)
                    {
                    }
                }
                singerInfo = Console.ReadLine().Split('@').ToArray();
            }

            PrintProfit(cityProfit);

        }

        private static void PrintProfit(Dictionary<string, Dictionary<string, long>> cityProfit)
        {
            foreach (KeyValuePair<string, Dictionary<string, long>> cityEntry in cityProfit)
            {
                Console.WriteLine(cityEntry.Key);

                foreach (KeyValuePair<string, long> singerProfit in cityEntry.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singerProfit.Key} -> {singerProfit.Value}");
                }
            }
        }

        private static long GetProfit(string v1, string v2)
        {
            long ticketPrice = long.Parse(v1);
            long ticketsCount = long.Parse(v2);
            long profit = ticketPrice * ticketsCount;
            return profit;
        }

        private static void InsertProfit(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity, string singer, long profit)
        {
            if (!cityProfit[newCity].ContainsKey(singer))
            {
                cityProfit[newCity].Add(singer, 0);
            }
            cityProfit[newCity][singer] += profit;
        }

        private static void InsertCity(Dictionary<string, Dictionary<string, long>> cityProfit, string newCity)
        {
            if (!cityProfit.ContainsKey(newCity))
            {
                cityProfit.Add(newCity, new Dictionary<string, long>());
            }
        }
    }
}
