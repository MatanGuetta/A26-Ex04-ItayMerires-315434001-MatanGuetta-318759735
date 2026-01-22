using System;

namespace Ex04.Menus.Test
{
	public class ShowTime : IExecutable
	{
		void IExecutable.Execute()
		{
			Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        }
    }
}
