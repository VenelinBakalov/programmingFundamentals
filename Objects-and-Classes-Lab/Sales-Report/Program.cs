using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale[] sales = ReadSales();

            string[] towns = sales.Select(s => s.Town).Distinct().OrderBy(t => t).ToArray();

            foreach (string town in towns)
            {
                decimal salesByTown = sales.Where(s => s.Town == town).Select(s => s.Price * s.Quantity).Sum();
                Console.WriteLine($"{town} -> {salesByTown:f2}");
            }
        }

        static Sale[] ReadSales()
        {
            int count = int.Parse(Console.ReadLine());

            Sale[] sales = new Sale[count];

            for (int i = 0; i < sales.Length; i++)
            {
                sales[i] = ReadSale();
            }

            return sales;
        }

        static Sale ReadSale()
        {
            string[] saleInfo = Console.ReadLine().Split().ToArray();
            Sale sale = new Sale (saleInfo[0], saleInfo[1], 
                            decimal.Parse(saleInfo[2]), decimal.Parse(saleInfo[3]));
            return sale;
        }
    }

    class Sale
    {
        public string Town;
        public string Product;
        public decimal Price;
        public decimal Quantity;

        public Sale(string Town, string Product, decimal Price, decimal Quantity)
        {
            this.Town = Town;
            this.Product = Product;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
