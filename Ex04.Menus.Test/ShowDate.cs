using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowDate : ILeafMethod
    {
        public void LeafMethod()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("The date is: {0}/{1}/{2}", date.Day, date.Month, date.Year);
        }
    }
}
