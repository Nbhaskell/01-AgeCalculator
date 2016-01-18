using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Starting Variables
            bool validinput = false;
            string input = "";
            DateTime dateValue;

            // User Input
            Console.WriteLine("What is your birthday? Use the format MM/DD/YYYY");
            input = Console.ReadLine();

            // Proper format, recapture if not
            while (validinput == false)
            {
                if (DateTime.TryParse(input, out dateValue))
                {
                    if (dateValue > DateTime.Now)
                    {
                        Console.WriteLine("OOPS! looks like you entered a date in the future. Please enter your date of birth using the format MM/DD/YYYY.");
                        input = Console.ReadLine();
                    }

                    else
                    {
                        validinput = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter the date in the proper format: MM/DD/YYYY");
                    input = Console.ReadLine();
                }

            }

            
            while (true)
            {
                DateTime today = DateTime.Now;
                DateTime birthday = DateTime.Parse(input);

                // Difference in days
                TimeSpan dbldays = today.Subtract(birthday);
                double days = dbldays.Days;

                // Days in year
                double years = days / 365.25;
                double wholeYears = Math.Floor(years);
                int years1 = Convert.ToInt32(wholeYears);

                // Days in week
                double daysNoYears = days % 365.25;
                double weeks = daysNoYears / 7;
                double wholeWeeks = Math.Floor(weeks);
                int weeks1 = Convert.ToInt32(wholeWeeks);

                // Days in days
                double remainingDays = days - ((wholeYears * 365.25) + (wholeWeeks * 7));
                double wholeDays = Math.Floor(remainingDays);
                int days1 = Convert.ToInt32(wholeDays);

                Console.WriteLine("You are " + years1 + "years old, " + weeks1 + " weeks old, and " + days1 + " days old!");

                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

    }
}