using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 0; i < count; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(),
                    "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsulesCount = long.Parse(Console.ReadLine());

                decimal coffeePrice = (DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * capsulesCount) * price;
                totalPrice += coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
