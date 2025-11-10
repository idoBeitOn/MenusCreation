using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MiddleMenuItem : MenuItem
    {
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }
        public MiddleMenuItem(string i_Name, MenuItem i_PrecedingItem)
        {
            MenuItemName = i_Name;
            PrecedingItem = i_PrecedingItem;
        }
        public void AddItem(MenuItem i_MenuItemToAdd)
        {
            r_MenuItems.Add(i_MenuItemToAdd);
        }
        public void RemoveItem(MenuItem i_MenuItemToRemove)
        {
            r_MenuItems.Remove(i_MenuItemToRemove);
        }
        public override MenuItem RunItem()
        {
            ShowMiddleMenu();
            int userInput = MenuInput.GetInputFromUser(r_MenuItems.Count);
            Console.Clear();
            MenuItem item;
            if (userInput == 0)
            {
                item = PrecedingItem;
            }
            else
            {
                item = MenuItems[userInput - 1];
            }

            return item;
        }
        public void ShowMiddleMenu()
        {
            bool isMainMenu = false;
            MenuOutput.ShowMenuItem(MenuItemName, MenuItems, isMainMenu);
        }
    }
}
