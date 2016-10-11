using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace Count_Work_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = ReadDate();
            DateTime endDate = ReadDate();

            DateTime[] officialHolidays = new DateTime[] {
                new DateTime(4, 01, 01),
                new DateTime(4, 03, 03),
                new DateTime(4, 05, 01),
                new DateTime(4, 05, 06),
                new DateTime(4, 05, 24),
                new DateTime(4, 09, 06),
                new DateTime(4, 09, 22),
                new DateTime(4, 11, 01),
                new DateTime(4, 12, 24),
                new DateTime(4, 12, 25),
                new DateTime(4, 12, 26)
                };

            int workingDays = 0;

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DayOfWeek dayOfWeek = currentDate.DayOfWeek;
                DateTime dateToCheck = new DateTime(4, currentDate.Month, currentDate.Day);

                if (!dayOfWeek.Equals(DayOfWeek.Saturday) && !dayOfWeek.Equals(DayOfWeek.Sunday) && !officialHolidays.Contains(dateToCheck))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);

  //   var oneholiday = new DateTime(2015, 05, 24);
  //
  //   var godina = 2012;
  //   var den = 24;
  //   var mesec = 05;
  //
  //   var datefromInput = new DateTime(godina, mesec, den);
  //   bool isSaturday = datefromInput.DayOfWeek == DayOfWeek.Saturday;
  //
  //   var holidayCanidate = new DateTime(2015, datefromInput.Month, datefromInput.Day);
  //
  //
  //   HashSet<int> days = new HashSet<int>();
  //   days.Add(06);
  //   days.Add(06);
  //
  //   days.Contains(6);
            // [nomerNaMesec] => Set(pochiwniDniWToziMesec)
            // 01 => [01],
            // 02 => [],
            // 03 => [03],
            // 04 => [],
            // 05 => [01, 24]
            // 09 => [06, 22]
            // dictionary.ContainsKey(meseca) && dictionary[meseca].Contains(kanidatZaPochivenDen);
        }

        static DateTime ReadDate()
        {
            string dateAsString = Console.ReadLine();
            DateTime date = DateTime.ParseExact(dateAsString, "d-M-yyyy", CultureInfo.InvariantCulture);

            return date;
        }
    }
}
