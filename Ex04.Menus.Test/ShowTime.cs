using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class ShowTime : IExecutable
	{
		void IExecutable.Execute()
		{
			Console.WriteLine("The time is: " + DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
