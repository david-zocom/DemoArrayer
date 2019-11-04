using System;

namespace DemoArrayer
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Välkommen till Frasses frukt!");
			Console.WriteLine("=============================");
			bool fortsättaHandla = true;
			while (fortsättaHandla)
			{
				Console.WriteLine("Vilken frukt vill du köpa?");
				string input = Console.ReadLine();
				if( input == "betala")
				{
					fortsättaHandla = false;
				}
				else if (input == "grapefrukt")
				{
					throw new Exception("Förbjuden frukt!");
				}
				else if (input == "päron")
				{
					Console.WriteLine("Tyvärr, vi har slut på päron");
				}
				else if (input == "melon")
				{
					Console.WriteLine("Varsågod");
				}
				else
				{
					//Console.WriteLine("Tyvärr, den frukten finns inte");
					Console.WriteLine("Jag känner inte till den frukten. Försök igen!");
				}
				Console.WriteLine();
			}  // while
			Console.WriteLine("Välkommen åter");
		}
	}
}
