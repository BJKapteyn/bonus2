using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus2
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = 0;
            int year = 0;
            int day = 0;
            int daysOld;
            int monthsOld;
            int yearsOld;
            DateTime today = DateTime.Now;

            bool Month(string m)
            {
                if (Int32.TryParse(m, out int x))
                {
                    month = Convert.ToInt32(m);
                    if (month >= 0 && month <= 12)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            bool Year(string y)
            {
                if (Int32.TryParse(y, out int x))
                {
                    year = Convert.ToInt32(y);
                    if (year >= 1900 && year <= today.Year)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            bool Day(string d)
            {
                if (Int32.TryParse(d, out int x))
                {
                    day = Convert.ToInt32(d);
                    if (day >= 0 && day <= DateTime.DaysInMonth(year, month))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            Console.WriteLine("Sup playa, whats your birthday so I'll know if I can holla at ya.");
            Console.WriteLine("Enter the year you were born.");
            while (!Year(Console.ReadLine()))
            {
                Console.WriteLine("Enter a real year foo!");
            }

            Console.WriteLine("Enter the numeric month you were born. (1-12)");
            while (!Month(Console.ReadLine()))
            {
                Console.WriteLine("Enter a real month sucka!");
            }

            Console.WriteLine("Enter the numeric day you were born.");
            while (!Day(Console.ReadLine()))
            {
                Console.WriteLine("Enter an actual day joker!");
            }

            //grab the difference between your birthday and today.
            DateTime yourBirthday = new DateTime(year, month, day);
            TimeSpan howOld = today.Subtract(yourBirthday);

            yearsOld = howOld.Days / 365;
            monthsOld = (howOld.Days % 365) / 30;
            int daysInBirthMonth = DateTime.DaysInMonth(year, month);

            if (Math.Abs(day - daysInBirthMonth + today.Day) > daysInBirthMonth)
            {
                daysOld = Math.Abs(day - daysInBirthMonth + today.Day);
            }
            else
            {
                daysOld = today.Day - day;
            }
            Console.WriteLine($"You are {yearsOld} years {monthsOld} months and {daysOld} days old.");

            if (yearsOld >= 18)
            {
                Console.WriteLine($"{yearsOld}? Ey yo yo yo lemme get yo numba!");
            }
            else
            {
                Console.WriteLine($"{yearsOld}? Oh, uh, are you selling girlscout cookies by chance?");
            }

            Console.ReadKey();
            



        }
    }
}
