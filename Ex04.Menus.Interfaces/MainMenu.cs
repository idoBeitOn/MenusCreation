using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;



namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private string m_MenuName;
        private readonly List<MenuItem> r_MenuItems = new List<MenuItem>();
        public string MenuName
        {
            get
            {
                return m_MenuName;
            }
        }
        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }
        public MainMenu(string i_MenuName)
        {
            m_MenuName = i_MenuName;
        }
        public void AddItem(MenuItem i_MenuItemToAdd)
        {
            MenuItems.Add(i_MenuItemToAdd);
        }
        public void RemoveItem(MenuItem i_MenuItemToRemove)
        {
            MenuItems.Remove(i_MenuItemToRemove);
        }
        public void ShowMainMenu()
        {
            bool isMainMenu = true;
            MenuOutput.ShowMenuItem(MenuName, MenuItems, isMainMenu);
        }
        public void RunMenu()
        {
            ShowMainMenu();
            bool stopProgram = false;
            int userInput = MenuInput.GetInputFromUser(MenuItems.Count);
            if (userInput == 0)
            {
                return;
            }

            MenuItem item = MenuItems[userInput - 1];
            Console.Clear();
            while (!stopProgram)
            {
                item = item.RunItem();
                if (item == null)
                {
                    RunMenu();
                    stopProgram = true;
                }
            }
        }
    }
}
