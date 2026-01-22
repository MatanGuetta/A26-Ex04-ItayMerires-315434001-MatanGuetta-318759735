using System;

namespace Ex04.Menus.Interfaces
{

	public class ActionItem : MenuItem
    {
		private readonly List<IExecutable> r_Listeners;

		public ActionItem(string i_Title) : base(i_Title)
		{
			r_Listeners = new List<IExecutable>();
        }

		public void AddListener(IExecutable i_Listener)
		{
			r_Listeners.Add(i_Listener);
        }

		public void RemoveListener(IExecutable i_Listener)
		{
			r_Listeners.Remove(i_Listener);
        }

        public override void Show()
        {
            Console.Clear();
			Console.WriteLine("=== " + this.Title + " ===");

            foreach (IExecutable listener in r_Listeners)
            {
                listener.Execute();
            }

            Console.WriteLine("\nPress Enter to return to the previous menu.");
			Console.ReadLine();
        }
    }
}
