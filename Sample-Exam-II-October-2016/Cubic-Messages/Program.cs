using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^\d+)([a-zA-Z]+)([^a-zA-Z]+?)$";
            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            while (!input.Equals("Over!"))
            {
                int charLength = int.Parse(Console.ReadLine());
                Match match = regex.Match(input);
                StringBuilder sb = new StringBuilder();
                string firstGroup = match.Groups[1].ToString();
                string secondGroup = match.Groups[2].ToString();
                string thirdGroup = match.Groups[3].ToString();

                if (secondGroup.Length.Equals(charLength))
                {

                    for (int i = 0; i < match.Groups[1].Length; i++)
                    {

                        int index = int.Parse(firstGroup[i].ToString());
                        if (index < secondGroup.Length)
                        {
                            sb.Append(secondGroup[index]);
                        }
                        else
                        {
                            sb.Append(" ");
                        }
                    }


                    for (int i = 0; i < thirdGroup.Length; i++)
                    {
                        try
                        {
                            int index = int.Parse(thirdGroup[i].ToString());
                            if (index < secondGroup.Length)
                            {
                                sb.Append(secondGroup[index]);
                            }
                            else
                            {
                                sb.Append(" ");
                            }
                        }
                        catch (Exception)
                        {

                        }
                    }


                    Console.WriteLine($"{match.Groups[2]} == {sb}");
                }

                input = Console.ReadLine();
            }


        }
    }
}
