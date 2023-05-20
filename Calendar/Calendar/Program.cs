/*
    Name: Christian Jay Putol
    Date Created: 03/17/2023
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year in this format(yyyy): ");
            int year = int.Parse(Console.ReadLine());


            for (int month = 1; month <= 12; month++)
            {
                DateTime date = new DateTime(year, month, 1);
                Console.WriteLine("--------------------");
                Console.WriteLine(date.ToString("    MMMM yyyy"));

                Console.WriteLine("Su Mo Tu We Th Fr Sa");

                int daysInMonth = DateTime.DaysInMonth(year, month);
                DayOfWeek startDayOfWeek = new DateTime(year, month, 1).DayOfWeek;
                int dayOfWeek = Convert.ToInt32(startDayOfWeek);
                for (int i = 0; i < dayOfWeek; i++)
                {
                    Console.Write("   ");
                }
                for (int day = 1; day <= daysInMonth; day++)
                {
                    Console.Write("{0,2} ", day);
                    if ((day + dayOfWeek) % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("\n--------------------\n");
            }
        }
    }
}
