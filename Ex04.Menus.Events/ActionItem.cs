using System;

namespace Ex04.Menus.Events
{

	public class ActionItem : MenuItem
	{
		private event Action m_Action;
		
		public ActionItem(string i_Title, Action i_Action) : base(i_Title)
		{
			m_Action += i_Action;
		}
		
		public override void Show()
		{
			m_Action?.Invoke();
			Console.WriteLine("Press Enter to continue...");
			Console.ReadLine();
		}
    }
}