using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        private string m_MenuItemName;
        private MenuItem m_PrecedingItem;
        public string MenuItemName
        {
            get
            {
                return m_MenuItemName;
            }

            set
            {
                m_MenuItemName = value;
            }
        }
        public MenuItem PrecedingItem
        {
            get
            {
                return m_PrecedingItem;
            }

            set
            {
                m_PrecedingItem = value;
            }
        }
        public abstract MenuItem RunItem();
    }
}
