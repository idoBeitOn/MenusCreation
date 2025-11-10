using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class LeafMenuItem : MenuItem
    {
        private ILeafMethod m_Method;
        public ILeafMethod Method
        {
            get
            {
                return m_Method;
            }

            set
            {
                m_Method = value;
            }
        }
        public LeafMenuItem(string i_Name, MenuItem i_PrecedingItem, ILeafMethod i_Method)
        {
            MenuItemName = i_Name;
            PrecedingItem = i_PrecedingItem;
            Method = i_Method;
        }
        public override MenuItem RunItem()
        {
            Method.LeafMethod();

            return PrecedingItem.RunItem();
        }
    }
}
