using System;

namespace Ex04.Menus.Interfaces
{
	public class MainMenu : MenuItem
    {
		List<MenuItem> m_MenuItems;
		public MainMenu(string i_Title) : base(i_Title)
		{
			m_MenuItems = new List<MenuItem>();
		}

		public void AddMenuItem(MenuItem i_MenuItem)
		{
			m_MenuItems.Add(i_MenuItem);
		}

		public override void Show()
		{
			bool exitRequested = false;
			while (!exitRequested)
			{
				Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=== " + this.Title + " ===");
                Console.ResetColor();

                for (int i = 0; i < m_MenuItems.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {m_MenuItems[i].Title}");
                }

                Console.WriteLine("0. Exit");//**************************
				Console.Write("Select an option: ");
				string userInput = Console.ReadLine();

				if (int.TryParse(userInput, out int choice))
				{
					if (choice == 0)
					{
						exitRequested = true;
					}
					else if (choice > 0 && choice <= m_MenuItems.Count)
					{
						m_MenuItems[choice - 1].Show();
					}
					else
					{
						Console.WriteLine("Invalid choice. Press Enter to try again.");
						Console.ReadLine();
					}
				}
				else
				{
					Console.WriteLine("Invalid input. Press Enter to try again.");
					Console.ReadLine();
				}
			}
        }


    }
}
