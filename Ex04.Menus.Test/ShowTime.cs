using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    internal class ShowTime : ILeafMethod
    {
        public void LeafMethod()
        {
            DateTime time = DateTime.Now;
            Console.WriteLine("The Hour is: {0:D2}:{1:D2}:{2:D2}", time.Hour, time.Minute, time.Second);
        }
    }
}
