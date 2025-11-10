using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class CountCapitals : ILeafMethod
    {
        public void LeafMethod()
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
    }
}
