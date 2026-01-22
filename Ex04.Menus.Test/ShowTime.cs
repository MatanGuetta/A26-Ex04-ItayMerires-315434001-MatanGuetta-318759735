using System;

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
