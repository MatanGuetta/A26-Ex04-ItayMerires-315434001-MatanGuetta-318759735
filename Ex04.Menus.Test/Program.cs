using Ex04.Menus.Events;
using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.TestInterfaceMenu();
            program.TestEventsMenu();
        }

        public void TestInterfaceMenu()
        {
            // 1. Create the Main Menu
            Ex04.Menus.Interfaces.MainMenu mainMenu = new Ex04.Menus.Interfaces.MainMenu("Interface Main Menu");

            // 2. Create Sub-Menu "Version and Capitals"
            Ex04.Menus.Interfaces.MainMenu subMenuVersion = new Ex04.Menus.Interfaces.MainMenu("Version and Capitals");

            // 2.1 Add Actions to Sub-Menu (Using the Classes you created)
            subMenuVersion.AddMenuItem(new Ex04.Menus.Interfaces.ActionItem("Show Version").AddListener(new ShowVersion()));
            subMenuVersion.AddMenuItem(new Ex04.Menus.Interfaces.ActionItem("Count Capitals").AddListener(new CountCapitals()));

            // 3. Create Sub-Menu "Show Date/Time"
            Ex04.Menus.Interfaces.MainMenu subMenuDateTime = new Ex04.Menus.Interfaces.MainMenu("Show Current Date/Time");

            // 3.1 Add Actions to Sub-Menu
            subMenuDateTime.AddMenuItem(new Ex04.Menus.Interfaces.ActionItem("Show Time").AddListener(new ShowTime()));
            subMenuDateTime.AddMenuItem(new Ex04.Menus.Interfaces.ActionItem("Show Date").AddListener(new ShowDate()));

            // 4. Add Sub-Menus to Main Menu
            mainMenu.AddMenuItem(subMenuVersion);
            mainMenu.AddMenuItem(subMenuDateTime);

            // 5. Run
            mainMenu.Show();
        }

        public void TestEventsMenu()
        {
            // 1. Create the Main Menu
            Ex04.Menus.Events.MainMenu mainMenu = new Ex04.Menus.Events.MainMenu("Delegates Main Menu");

            // 2. Create Sub-Menu "Version and Capitals"
            Ex04.Menus.Events.MainMenu subMenuVersion = new Ex04.Menus.Events.MainMenu("Version and Capitals");

            // 2.1 Add Actions (Using methods in this class)
            Ex04.Menus.Events.ActionItem versionItem = new Ex04.Menus.Events.ActionItem("Show Version");
            versionItem.Selected += showVersion;
            subMenuVersion.AddMenuItem(versionItem);

            Ex04.Menus.Events.ActionItem capitalsItem = new Ex04.Menus.Events.ActionItem("Count Capitals");
            capitalsItem.Selected += countUppercaseLetters;
            subMenuVersion.AddMenuItem(capitalsItem);

            // 3. Create Sub-Menu "Show Date/Time"
            Ex04.Menus.Events.MainMenu subMenuDateTime = new Ex04.Menus.Events.MainMenu("Show Current Date/Time");

            Ex04.Menus.Events.ActionItem timeItem = new Ex04.Menus.Events.ActionItem("Show Time");
            timeItem.Selected += showTime;
            subMenuDateTime.AddMenuItem(timeItem);

            Ex04.Menus.Events.ActionItem dateItem = new Ex04.Menus.Events.ActionItem("Show Date");
            dateItem.Selected += showDate;
            subMenuDateTime.AddMenuItem(dateItem);

            // 4. Add Sub-Menus to Main Menu
            mainMenu.AddMenuItem(subMenuVersion);
            mainMenu.AddMenuItem(subMenuDateTime);

            // 5. Run
            mainMenu.Show();
        }

        private void showTime()
        {
            Console.WriteLine("The current time is: " + DateTime.Now.ToShortTimeString());
        }

        private void showDate()
        {
            Console.WriteLine("The current date is: " + DateTime.Now.ToShortDateString());
        }
        
        private void showVersion()
        {
            Console.WriteLine($"The version is: " + Environment.Version);
        }

        private void countUppercaseLetters()
        {
            Console.WriteLine("Please enter a sentence:");
            string input = Console.ReadLine() ?? "";
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsUpper(c)) count++;
            }
            Console.WriteLine($"There are {count} capital letters in your sentence.");
        }
    }
}
