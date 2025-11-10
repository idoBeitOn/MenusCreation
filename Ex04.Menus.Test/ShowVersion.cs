using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowVersion : ILeafMethod
    {
        public void LeafMethod()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}
