using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');
            int leftEquals = 0;
            int rightEquals = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    leftEquals++;
                }
                else
                {
                    break;
                }
            }

            int lengthBuffer = Math.Min(firstArray.Length, secondArray.Length); // get the minimal length
            int differenceBuffer= Math.Abs(firstArray.Length - secondArray.Length);


            for (int i = lengthBuffer - 1; i >= 0; i--)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    string a = firstArray[i + differenceBuffer];
                    string b = secondArray[i]; 

                    if (a == b)
                    {
                        rightEquals++;
                    } 
                }
                else
                {
                    string a = firstArray[i];
                    string b = secondArray[i + differenceBuffer];
                    if (a == b)
                    {
                        rightEquals++;
                    }
                }
            }

           /*for (int i = Math.Max(firstArray.Length - 1, secondArray.Length - 1); i >= 0; i--)
            {
                if (firstArray.Length > secondArray.Length)
                {
                    if (firstArray[i] == secondArray[i - (firstArray.Length - secondArray.Length)] && i - (firstArray.Length - secondArray.Length) >= 0)
                    {
                        rightEquals++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    if (secondArray[i] == firstArray[i - (secondArray.Length - firstArray.Length)] && i - (secondArray.Length - firstArray.Length) >= 0)
                    {
                        rightEquals++;
                    }
                    else
                    {
                        break;
                    }
                }
            }*/
            Console.WriteLine(Math.Max(leftEquals, rightEquals));
        }
    }
}
