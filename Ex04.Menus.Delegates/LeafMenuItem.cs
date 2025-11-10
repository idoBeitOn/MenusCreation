using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class LeafMenuItem : MenuItem
    {
        public event Action LeafMethodNotifier;
        public LeafMenuItem(string i_Name, MenuItem i_PrecedingItem)
        {
            MenuItemName = i_Name;
            PrecedingItem = i_PrecedingItem;
        }
        private void notifyLeafMethod()
        {
            if (LeafMethodNotifier != null)
            {
                LeafMethodNotifier.Invoke();
            }
        }
        public override MenuItem RunItem()
        {
            notifyLeafMethod();

            return PrecedingItem.RunItem();
        }
    }
}
