using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class RunMenus
    {
        public static void RunDelegatesMenu()
        {
            Delegates.MainMenu mainMenu = new Delegates.MainMenu("Delegates Main Menu");
            Delegates.MiddleMenuItem dateAndTime = new Delegates.MiddleMenuItem("Show Date/Time", null);
            Delegates.LeafMenuItem showDate = new Delegates.LeafMenuItem("Show Date", dateAndTime);
            Delegates.LeafMenuItem showTime = new Delegates.LeafMenuItem("Show Time", dateAndTime);
            Delegates.MiddleMenuItem versionAndCapitals = new Delegates.MiddleMenuItem("Version and Capitals", null);
            Delegates.LeafMenuItem countCapitals = new Delegates.LeafMenuItem("Count Capitals", versionAndCapitals);
            Delegates.LeafMenuItem showVersion = new Delegates.LeafMenuItem("Show Version", versionAndCapitals);
            showDate.LeafMethodNotifier += new Action(MethodsForDelegates.ShowDate);
            showTime.LeafMethodNotifier += new Action(MethodsForDelegates.ShowTime);
            countCapitals.LeafMethodNotifier += new Action(MethodsForDelegates.CountCapitals);
            showVersion.LeafMethodNotifier += new Action(MethodsForDelegates.ShowVersion);
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);
            versionAndCapitals.AddItem(countCapitals);
            versionAndCapitals.AddItem(showVersion);
            mainMenu.AddItem(dateAndTime);
            mainMenu.AddItem(versionAndCapitals);
            mainMenu.RunMenu();
        }
        public static void RunInterfaceMenu()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Interfaces Main Menu");
            Interfaces.MiddleMenuItem dateAndTime = new Interfaces.MiddleMenuItem("Show Date/Time", null);
            Interfaces.LeafMenuItem showDate = new Interfaces.LeafMenuItem("Show Date", dateAndTime, new ShowDate());
            Interfaces.LeafMenuItem showTime = new Interfaces.LeafMenuItem("Show Time", dateAndTime, new ShowTime());
            Interfaces.MiddleMenuItem versionAndCapitals = new Interfaces.MiddleMenuItem("Version and Capitals", null);
            Interfaces.LeafMenuItem countCapitals = new Interfaces.LeafMenuItem("Count Capitals", versionAndCapitals, new CountCapitals());
            Interfaces.LeafMenuItem showVersion = new Interfaces.LeafMenuItem("Show Version", versionAndCapitals, new ShowVersion());
            dateAndTime.AddItem(showDate);
            dateAndTime.AddItem(showTime);
            versionAndCapitals.AddItem(countCapitals);
            versionAndCapitals.AddItem(showVersion);
            mainMenu.AddItem(dateAndTime);
            mainMenu.AddItem(versionAndCapitals);
            mainMenu.RunMenu();
        }
    }
}
