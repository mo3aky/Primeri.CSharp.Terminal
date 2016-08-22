using System;

namespace Module02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a=0, b=0;
			int sum = 0;
			string programe_name = "Модул 102-Примери";
			string programe_version= "1.1";

			//Събиране на числа
			a = 5;
			b = 10;
			sum = a + b;
				
			Console.WriteLine (programe_name );
			Console.WriteLine ("Версия: " + programe_version + "\n\n");
			//Писане в конзола
			Console.Write ( a );
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine( sum );

			//Допълнителни редове
			Console.WriteLine ("\nСъбиране");
				a +=b;
				Console.WriteLine (a);

			Console.WriteLine ("\nИзваждане");
			a -=b;
			Console.WriteLine (a);

			Console.WriteLine ("\nУмножение");
			a *=b;
			Console.WriteLine (a);

			Console.WriteLine ("\nДобавяне на единица");
			a++;
			Console.WriteLine (a);

			Console.WriteLine ( "Стандартно делене: " +  ( 7 / 3 ).ToString()); 
			Console.WriteLine ( "Остатък: "  + ( 7 % 3 ).ToString()); 


		}
	}
}
