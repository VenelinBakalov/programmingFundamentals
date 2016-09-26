using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysPeriod = int.Parse(Console.ReadLine());
            int doctors = 7;
            int patientsTreated = 0;
            int patientsUntreated = 0;

            for (int i = 1; i <= daysPeriod; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if (patientsUntreated > patientsTreated)
                    {
                        doctors++;
                    }
                }
                if (patients <= doctors)
                {
                    patientsTreated += patients;
                }
                else
                {
                    patientsTreated += doctors;
                    patientsUntreated += patients - doctors;
                }
            }
            Console.WriteLine("Treated patients: {0}.", patientsTreated);
            Console.WriteLine("Untreated patients: {0}.", patientsUntreated);
        }
    }
}
