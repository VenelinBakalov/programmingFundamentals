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
            char[] splitters = { ' ', '@' };
            string[] singerInfo = Console.ReadLine().Split('@').ToArray();

            List<string> cityName = new List<string>();
            int moneyMade = 0;

            while (!singerInfo[0].Equals("End"))
            {
                string[] singer = singerInfo[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] city = singerInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                bool isCity = true;

                while (isCity)
                {
                    for (int i = 0; i < city.Length; i++)
                    {
                        try
                        {
                            int ticketPrice = int.Parse(city[i]);
                            int ticketsCount = int.Parse(city[i + 1]);
                            for (int j = 0; j < i; j++)
                            {
                                cityName.Add(city[j]);
                            }
                            moneyMade = ticketPrice * ticketsCount;
                            isCity = false;
                            break;
                        }
                        catch (Exception)
                        {
                            isCity = true;
                        }
                    }
                }
                singerInfo = Console.ReadLine().Split('@').ToArray();
            }
            Console.WriteLine(string.Join(" ", cityName));
            Console.WriteLine(moneyMade);
        }
    }
}
