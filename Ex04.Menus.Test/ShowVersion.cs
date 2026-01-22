using System;

namespace Ex04.Menus.Test
{
	public class ShowVersion : IExecutable
	{
		void IExecutable.Execute()
		{
			Console.WriteLine($"The version is: " + Environment.Version);
		}
    }
}
