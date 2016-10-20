using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Football_League
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = new char[] { ' ', ':' };
            string decryptPatter = Console.ReadLine();
            string pattern = Regex.Escape(decryptPatter);
            string input = Console.ReadLine();

            Dictionary<string, int> teamScores = new Dictionary<string, int>();
            Dictionary<string, int> teamGoals = new Dictionary<string, int>();

            while (!input.Equals("final"))
            {
                string[] teamInfo = Regex.Split(input, pattern);
                string[] scores = teamInfo[teamInfo.Length - 1].Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                string firstTeam = new string(teamInfo[1].ToUpper().Reverse().ToArray());
                string secondTeam = new string(teamInfo[teamInfo.Length - 2].ToUpper().Reverse().ToArray());

                InsertTeam(teamScores, firstTeam);
                InsertTeam(teamGoals, firstTeam);
                InsertTeam(teamScores, secondTeam);
                InsertTeam(teamGoals, secondTeam);

                int firstTeamScore = int.Parse(scores[scores.Length - 2]);
                int secondTeamScore = int.Parse(scores[scores.Length - 1]);

                InsertGoals(teamGoals, firstTeamScore, firstTeam);
                InsertGoals(teamGoals, secondTeamScore, secondTeam);

                InsertScores(teamScores, firstTeam, secondTeam, firstTeamScore, secondTeamScore);

                input = Console.ReadLine();
            }

            teamScores = teamScores.OrderByDescending(sc => sc.Value).ThenBy(name => name.Key).ToDictionary(x => x.Key, x => x.Value);

            int standing = 1;

            Console.WriteLine("League standings:");

            foreach (KeyValuePair<string, int> teamScore in teamScores)
            {
                Console.WriteLine($"{standing}. {teamScore.Key.ToUpper()} {teamScore.Value}");
                standing++;
            }

            teamGoals = teamGoals.OrderByDescending(goals => goals.Value).ThenBy(name => name.Key).Take(3).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Top 3 scored goals:");
            foreach (var pair in teamGoals)
            {
                Console.WriteLine($"- {pair.Key.ToUpper()} -> {pair.Value}");
            }
        }

        private static void InsertGoals(Dictionary<string, int> teamGoals, int firstTeamScore, string firstTeam)
        {
            teamGoals[firstTeam] += firstTeamScore;
        }

        private static void InsertScores(Dictionary<string, int> teamScores, string firstTeam, string secondTeam, int firstTeamScore, int secondTeamScore)
        {
            if (firstTeamScore > secondTeamScore)
            {
                teamScores[firstTeam] += 3;
            }
            else if (secondTeamScore > firstTeamScore)
            {
                teamScores[secondTeam] += 3;
            }
            else if (firstTeamScore == secondTeamScore)
            {
                teamScores[firstTeam]++;
                teamScores[secondTeam]++;
            }
        }

        private static void InsertTeam(Dictionary<string, int> teamScores, string firstTeam)
        {
            if (!teamScores.ContainsKey(firstTeam))
            {
                teamScores.Add(firstTeam, 0);
            }
        }
    }
}
