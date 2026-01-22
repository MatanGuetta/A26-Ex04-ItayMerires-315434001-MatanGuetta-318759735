using System;

namespace Ex04.Menus.Events
{

	public abstract class MenuItem
	{
		string m_Title;

		public MenuItem(string i_Title)
		{
			this.m_Title = i_Title;
		}

		public string Title
		{
			get { return m_Title; }
		}

		public abstract void Show();

    }

}