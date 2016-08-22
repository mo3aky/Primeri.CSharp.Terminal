using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			int a = 10, b = 0;

			Console.WriteLine ("Моля Въведете а: ");
			b = Convert.ToInt32 (Console.ReadLine ());
		
			Console.WriteLine ( "Резултатът a + b e " + (a + b).ToString () + "\n\n\n");
		}
	}
}
