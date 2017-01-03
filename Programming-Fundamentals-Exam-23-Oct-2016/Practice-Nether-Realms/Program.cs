using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice_Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ',' };

            List<Demon> demons = new List<Demon>();

            string[] demonNames = Console.ReadLine().Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (String demonName in demonNames)
            {
                string name = demonName;
                string healthPattern = @"[^0-9\*\-\+\/\.]";

                Regex healthRegex = new Regex(healthPattern);
                MatchCollection healthMatches = healthRegex.Matches(name);

                int health = 0;

                foreach (Match match in healthMatches)
                {
                    health += char.Parse(match.Groups[0].ToString());
                }

                string damagePattern = @"[\-|\+]?[0-9]+\.?[0-9]*";
                Regex damageRegex = new Regex(damagePattern);
                MatchCollection damagesMatches = damageRegex.Matches(name);

                double damage = 0;

                foreach (Match match in damagesMatches)
                {
                    damage += double.Parse(match.Groups[0].ToString());
                }

                string operatorPattern = @"[\*|\/]";
                Regex operatorRegex = new Regex(operatorPattern);
                MatchCollection operatorMatches = operatorRegex.Matches(name);

                foreach (Match match in operatorMatches)
                {
                    if (match.Groups[0].ToString().Equals("*"))
                    {
                        damage *= 2;
                    }
                    else if (match.Groups[0].ToString().Equals("/"))
                    {
                        damage /= 2;
                    }
                }

                Demon demon = new Demon(name, health, damage);

                demons.Add(demon);
            }

            demons = demons.OrderBy(d => d.Name).ToList();

            foreach (Demon demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
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
}
