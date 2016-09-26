using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int daysDeadline = int.Parse(Console.ReadLine());
            int workersDoingOvertime = int.Parse(Console.ReadLine());

            double realHoursLeft = (daysDeadline * 0.90) * 8;
            double overtimeHours = workersDoingOvertime * (2 * daysDeadline);
            double totalHours = Math.Floor(realHoursLeft + overtimeHours);

            if (totalHours >= hoursNeeded)
            {
                Console.WriteLine("Yes!{0} hours left.", totalHours - hoursNeeded);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", hoursNeeded - totalHours);
            }
        }
    }
}
