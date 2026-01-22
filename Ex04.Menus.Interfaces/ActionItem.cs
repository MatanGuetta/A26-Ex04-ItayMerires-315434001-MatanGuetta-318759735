using System;

namespace Ex04.Menus.Interfaces
{

	public class ActionItem : MenuItem
    {
		private readonly List<IExecutable> r_Listeners;

		ActionItem(string i_Title) : base(i_Title)
		{
			r_Listeners = new List<IExecutable>();
        }

		void AddListener(IExecutable i_Listener)
		{
			r_Listeners.Add(i_Listener);
        }

		void RemoveListener(IExecutable i_Listener)
		{
			r_Listeners.Remove(i_Listener);
        }

        public override void Show()
        {
            Console.Clear();
			Console.WriteLine("=== " + this.Title + " ===");

            foreach (IExecutable listener in m_Listeners)
            {
                listener.Execute();
            }

            Console.WriteLine("\nPress Enter to return to the previous menu.");
			Console.ReadLine();
        }
    }
}
