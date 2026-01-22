using System;

namespace Ex04.Menus.Interfaces
{

	public class ActionItem : MenuItem, IExecutable
    {
		List<IExecutable> m_Listeners;

		ActionItem(string i_Title) : base(i_Title)
		{
			m_Listeners = new List<IExecutable>();
        }

		void AddListener(IExecutable i_Listener)
		{

		}

		void RemoveListener(IExecutable i_Listener)
		{

		}

        public override void Show()
        {
            system.Console.Clear();
			Console.WriteLine("=== " + this.Title + " ===");
			Execute();
			Console.WriteLine("Press Enter to return to the previous menu.");
			Console.ReadLine();

        }
    }
}
