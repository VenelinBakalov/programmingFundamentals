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
                string hpPattern = @"[^0-9\+\-\*/\.]";

                Regex hpRegex = new Regex(hpPattern);
                MatchCollection hpCollection = hpRegex.Matches(name);

                int health = 0;

                foreach (Match match in hpCollection)
                {
                    health += char.Parse(match.Groups[0].ToString());
                }

                string dmgPattern = @"[\-|\+]?[0-9]+\.?[0-9]*";
                Regex dmgRegex = new Regex(dmgPattern);
                MatchCollection dmgCollection = dmgRegex.Matches(name);

                double damage = 0;

                foreach (Match match in dmgCollection)
                {
                    damage += double.Parse(match.Groups[0].ToString());
                }

                string multiplyPattern = @"[/|\*]";
                Regex multiplyRegex = new Regex(multiplyPattern);
                MatchCollection multiplyCollection = multiplyRegex.Matches(name);

                foreach (Match match in multiplyCollection)
                {
                    if (match.Groups[0].ToString().Equals("/"))
                    {
                        damage /= 2;
                    }
                    else if (match.Groups[0].ToString().Equals("*"))
                    {
                        damage *= 2;
                    }
                }

                Demon demon = new Demon(name, health, damage);

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
