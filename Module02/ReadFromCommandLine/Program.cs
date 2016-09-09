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

			string test= "1";
			test += ",2";
			test += ",100";
			test += ",4";
			test += ",5";

			Console.Write("Събиране с += " + test + "\n\n");

			test = test.Replace ( ",", ";");
			Console.WriteLine ("Работа с Replace " + test + "\n\n");

			Console.WriteLine ("3-ти знак " + test.Split(';')[2] + "\n");

			string edno = "Hello";
			string dve = "World";
			object tri = edno + dve;

			string pet = "type";

			Console.WriteLine (tri + "\n\n");
		
		}
	}
}
