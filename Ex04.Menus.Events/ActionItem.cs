using System;

namespace Ex04.Menus.Events
{

	public class ActionItem : MenuItem
	{
		public event Action? Selected;
		
		public ActionItem(string i_Title) : base(i_Title) { }

        protected virtual void OnSelected()
        {
            Selected?.Invoke();
        }

        public override void Show()
		{
			Console.Clear();

            OnSelected();

			Console.WriteLine("Press Enter to continue...");
			Console.ReadLine();
		}
    }
}