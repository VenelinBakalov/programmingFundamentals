using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int picturesTaken = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long totalFilterTime = (long)filterTime * picturesTaken;
            int goodPictures = (int)(Math.Ceiling((double)(picturesTaken) * filterFactor / 100));
            long totalUploadTime = goodPictures * (long)uploadTime;
            long totalTime = totalFilterTime + totalUploadTime;

            /*long days = totalTime / 86400;
            long daysLeft = totalTime % 86400;
            long hours = daysLeft / 3600;
            long hoursLeft = daysLeft % 3600;
            long minutes = hoursLeft / 60;
            long seconds = hoursLeft % 60;
            */
            long seconds = totalTime % 60;
            long minutes = totalTime / 60;
            long hours = 0;
            long days = 0;
            while (minutes >= 60)
            {
                minutes -= 60;
                hours++;
            }
            while (hours >= 24)
            {
                hours -= 24;
                days++;
            }
            
            Console.WriteLine($"{days}:{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}");
        }
    }
}
