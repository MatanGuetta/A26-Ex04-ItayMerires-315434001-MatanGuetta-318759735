using System;

namespace Ex04.Menus.Test
{
	public class ShowDate : IExecutable
    {
		void IExecutable.Execute()
		{
			Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy"));
        }
    }
}
