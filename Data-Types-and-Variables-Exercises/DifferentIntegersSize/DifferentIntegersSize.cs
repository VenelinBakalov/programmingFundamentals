using System;


namespace DifferentIntegersSize
{
    public class DifferentIntegersSize
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            bool isSByte = true;
            bool isByte = true;
            bool isShort = true;
            bool isUShort = true;
            bool isInt = true;
            bool isUInt = true;
            bool isLong = true;

            try
            {
                long currentType = long.Parse(input);


                //Console.WriteLine("{0} can fit in: \n*sbyte\n*short\n*int\n*long", input);
                //return;
            }
            catch (Exception)
            {
                isLong = false;
            }

            try
            {
                uint currentType = uint.Parse(input);
            }
            catch (Exception)
            {
                isUInt = false;
                
            }
            try
            {
                int currentType = int.Parse(input);
            }
            catch (Exception)
            {
                isInt = false;
            }

            try
            {
                ushort currentType = ushort.Parse(input);
            }
            catch (Exception)
            {
                isUShort = false;
            }

            try
            {
                short currentType = short.Parse(input);
            }
            catch (Exception)
            {
                isShort = false;
            }

            try
            {
                byte currentType = byte.Parse(input);
            }
            catch (Exception)
            {
                isByte = false;
            }

            try
            {
                sbyte currentType = sbyte.Parse(input);
            }
            catch (Exception)
            {
                isSByte = false;
            }

            string output = "";
            if (isLong)
            {
                Console.WriteLine("{0} can fit in:", input);
                output += isSByte ? "* sbyte\n" : "";
                output += isByte ? "* byte\n" : "";
                output += isShort ? "* short\n" : "";
                output += isUShort ? "* ushort\n" : "";
                output += isInt ? "* int\n" : "";
                output += isUInt ? "* uint\n" : "";
                output += isLong ? "* long\n" : "";
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
            /*
            string numAsString = Console.ReadLine();
            BigInteger number;
            bool numberFitsInBigInteger = BigInteger.TryParse(numAsString, out number);
 
            int lenght = numAsString.Length;
           
            if (number >= long.MinValue && number <= long.MaxValue)
            {
                Console.WriteLine($"{numAsString} can fit in:");
                if (number >= sbyte.MinValue && number <= sbyte.MaxValue) Console.WriteLine("* sbyte");
                if (number >= byte.MinValue && number <= byte.MaxValue) Console.WriteLine("* byte");
                if (number >= short.MinValue && number <= short.MaxValue) Console.WriteLine("* short");
                if (number >= ushort.MinValue && number <= ushort.MaxValue) Console.WriteLine("* ushort");
                if (number >= int.MinValue && number <= int.MaxValue) Console.WriteLine("* int");
                if (number >= uint.MinValue && number <= uint.MaxValue) Console.WriteLine("* uint");
                if (number >= long.MinValue && number <= long.MaxValue) Console.WriteLine("* long");
            }
            else
            {
                Console.WriteLine($"{numAsString} can't fit in any type");
            }
            */
      
        }
    }
}
