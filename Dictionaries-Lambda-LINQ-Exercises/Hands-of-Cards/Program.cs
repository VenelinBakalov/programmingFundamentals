using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> playerScore = new Dictionary<string, string>();
            char[] splitters = { ':', ',', ' ' };

            string[] playerInformation = Console.ReadLine().Split(':').Distinct().ToArray();

            while (!playerInformation[0].Equals("JOKER"))
            {
                if (!playerScore.ContainsKey(playerInformation[0]))
                {
                    playerScore.Add(playerInformation[0], null);
                }
                playerScore[playerInformation[0]] += playerInformation[1];

                /*for (int i = 1; i < playerInformation.Length; i++)
                {
                    int cardValue = GetPowerValue(playerInformation[i][0]);
                    int multiplier = 1;
                    if (playerInformation[i][0].Equals('1'))
                    {
                        multiplier = GetTypeMultiplier(playerInformation[i][2]);
                    }
                    else
                    {
                        multiplier = GetTypeMultiplier(playerInformation[i][1]);
                    }
                    int totalValue = cardValue * multiplier;
                    playerScore[playerInformation[0]] += totalValue;
                }
                */
                playerInformation = Console.ReadLine().Split(':').Distinct().ToArray();
            }

            Dictionary<string, List<string>> list = new Dictionary<string, List<string>>;

            foreach (KeyValuePair<string, string> pair in playerScore)
            {
               pair.Value.Split(splitters).Where(x => !x.Equals("")).Distinct();
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    if (!list.ContainsKey(pair.Key))
                    {
                        list.Add(pair.Key, null);
                    }
       //             list[pair.Key].Add(pair.Value[i]);
                }
            }

            Dictionary<string, int> handScore = new Dictionary<string, int>();

            foreach (var pair in playerScore)
            {
                for (int i = 0; i < pair.Value.Length; i++)
                {
                    if (!handScore.ContainsKey(pair.Key))
                    {
                        handScore.Add(pair.Key, 0);
                    }

       //             int cardValue = GetPowerValue(pair.Value[i][0]);
                    int multiplier = 1;
                    if (pair.Value[0].Equals('1'))
                    {
        //                multiplier = GetTypeMultiplier(pair.Value[i][2]);
                    }
                    else
                    {
         //               multiplier = GetTypeMultiplier(pair.Value[i][1]);
                    }
       //             int totalValue = cardValue * multiplier;
      //              handScore[pair.Key] += totalValue;
                }
            }

            foreach (KeyValuePair<string, int> pair in handScore)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }

        static int GetPowerValue(char power)
        {
            int value = 0;
            switch (power)
            {
                case '2': value = 2; break;
                case '3': value = 3; break;
                case '4': value = 4; break;
                case '5': value = 5; break;
                case '6': value = 6; break;
                case '7': value = 7; break;
                case '8': value = 8; break;
                case '9': value = 9; break;
                case '1': value = 10; break;
                case 'J': value = 11; break;
                case 'Q': value = 12; break;
                case 'K': value = 13; break;
                case 'A': value = 14; break;
            }

            return value;
        }

        static int GetTypeMultiplier(char type)
        {
            int multiplier = 0;
            switch (type)
            {
                case 'S': multiplier = 4; break;
                case 'H': multiplier = 3; break;
                case 'D': multiplier = 2; break;
                case 'C': multiplier = 1; break;
            }

            return multiplier;
        }
    }
}
