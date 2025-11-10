using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuOutput
    {
        public static void ShowMenuItem(string i_Name, List<MenuItem> i_MenuItems, bool i_IsMainMenu)
        {
            Console.WriteLine($"**{i_Name}**");
            Console.WriteLine("-----------------------");
            int i = 1;
            foreach (MenuItem item in i_MenuItems)
            {
                Console.WriteLine($"{i} -> {item.MenuItemName}");
                ++i;
            }

            Console.WriteLine(i_IsMainMenu ? "0 -> Exit" : "0 -> Back");
            Console.WriteLine("-----------------------");
            string requestMessage = $"Enter your request: (1 to {i_MenuItems.Count} or press '0' to ";
            Console.WriteLine(requestMessage + (i_IsMainMenu ? "Exit)." : "Back)."));
        }
        public static void PrintInputError(int i_NumberOfMenuOptions)
        {
            Console.WriteLine(string.Format("Choice input should be a number inside the range of 0 to {0}", i_NumberOfMenuOptions));
        }
    }
}
