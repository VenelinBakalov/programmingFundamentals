using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ',' };

            List<Demon> demons = new List<Demon>();

            string[] demonNames = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (string demonInput in demonNames)
            {
                string name = demonInput;

                string patternForHp = @"[0-9\+\-\*/\.]";
                string[] hpInfoaaa = Regex.Split(name, patternForHp).Where(s => !string.IsNullOrEmpty(s)).ToArray();
                string hpInfo = string.Join("", hpInfoaaa);

                int health = 0;

                for (int i = 0; i < hpInfo.Length; i++)
                {
                                      
                        health += (int)hpInfo[i];
                    
                }

                string patternForDmg = @"[^0-9\+\-\*/\.]";

                string[] damageInfoaaa = Regex.Split(demonInput, patternForDmg).Where(s => !string.IsNullOrEmpty(s)).ToArray();


                string damageInfo = string.Join("", damageInfoaaa);
                string[] damageNumbersInfo = Regex.Split(damageInfo, @"[^0-9\.\-\+]+").Where(s => !string.IsNullOrEmpty(s)).ToArray();
            //    double[] damageNumbers = damageNumbersInfo.Select(double.Parse).ToArray();
                string divideAndMultiply = Regex.Split(damageInfo, @"[0-9\.\-]+").Where(s => !string.IsNullOrEmpty(s)).ToString();

                char[] damageFinal = string.Join("", damageNumbersInfo).ToCharArray();
                double damageSum = 0;

                foreach (char damage in damageFinal)
                {
                    damageSum += double.Parse(damage.ToString());
                }

                char[] signs = divideAndMultiply.ToCharArray();

                foreach (char c in signs)
                {
                    if (c.Equals('*'))
                    {
                        damageSum *= 2;
                    }
                    else if (c.Equals('/'))
                    {
                        damageSum /= 2;
                    }
                }

                Demon demon = new Demon(name, health, damageSum);

                demons.Add(demon);

            }

            demons = demons.OrderBy(d => d.Name).ToList();

            foreach (Demon currentDemon in demons)
            {
                Console.WriteLine($"{currentDemon.Name} - {currentDemon.Health} health, {currentDemon.Damage:f2} damage ");
            }

        }
    }

    class Demon
    {
        public string Name;
        public int Health;
        public double Damage;

        public Demon(string name, int health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }
    }
}
