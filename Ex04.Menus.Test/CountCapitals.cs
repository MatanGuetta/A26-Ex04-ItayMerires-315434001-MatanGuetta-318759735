using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
	public class CountCapitals : IExecutable
	{

		void IExecutable.Execute()
		{
			Console.WriteLine("Please enter a sentence:");
			string input = Console.ReadLine();
			int capitalCount = 0;
			foreach (char c in input)
			{
				if (char.IsUpper(c))
				{
					capitalCount++;
				}
			}
			Console.WriteLine($"Number of capital letters: " + capitalCount);
		}
    }
}
