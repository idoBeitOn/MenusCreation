using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class MethodsForDelegates
    {
        public static void ShowDate()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The date is: {0}/{1}/{2}", date.Day, date.Month, date.Year);
        }
        public static void ShowTime()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("The Hour is: {0:D2}:{1:D2}:{2:D2}", time.Hour, time.Minute, time.Second);
        }
        public static void CountCapitals()
        {
            Console.WriteLine("Please enter your sentence:");
            string inputString = Console.ReadLine();
            int numberOfCapitals = 0;
            foreach (char ch in inputString)
            {
                if (char.IsUpper(ch))
                {
                    numberOfCapitals++;
                }
            }

            Console.WriteLine(string.Format("There are {0} capitals in your sentence.", numberOfCapitals));
        }
        public static void ShowVersion()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}
