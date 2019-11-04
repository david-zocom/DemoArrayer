using System;

namespace DemoArrayer
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers;
			numbers = new int[] { 17, 12, 62, -5, 202 };
			int length = numbers.Length;
			int first = numbers[0];
			Console.WriteLine($"Vi har skapat en array med {length} värden");
			Console.WriteLine($"Första värdet är: {first}");
			int last = numbers[length - 1];
			Console.WriteLine($"Sista värdet är: {last}");

			//int maybeError = numbers[length];
			// Inte ok att försöka komma åt minnet utanför arrayen

			int[] array1 = new int[] { 0, 10 };
			int[] array2 = new int[] { 0, 10 };
			int[] array3 = array1;
			bool equal = (array1 == array2);
			Console.WriteLine("array1 och array2 är lika: " + equal);
			bool equal2 = (array1 == array3);
			Console.WriteLine("array1 och array3 är lika: " + equal2);
			// array1 och array2 finns på olika plats i minnet


			string[] frukter;
			frukter = new string[] { "äpple", "banan", "melon" };
			double[] priser;
			priser = new double[]  { 10,       15,     7 };



			
			Console.WriteLine("Välkommen till Frasses frukt!");
			Console.WriteLine("=============================");
			Console.WriteLine("Här är vårt sortiment:");
			for (int index = 0; index < frukter.Length; index++)
			{
				string frukt = frukter[index];
				double pris = priser[index];
				Console.WriteLine($"{frukt} - {pris} kr/kg");
			}

			// Nästa version:
			// I stället för att ha en if-sats för varje frukt, gå igenom arrayen
			// och se om frukten användaren vill ha finns i den!

			bool fortsättaHandla = true;
			while (fortsättaHandla)
			{
				Console.WriteLine("Vilken frukt vill du köpa?");
				string input = Console.ReadLine();
				if( input == "betala")
				{
					fortsättaHandla = false;
				}
				else if( input == "priser")
				{
					Console.WriteLine("Här är vårt sortiment:");
					for (int index = 0; index < frukter.Length; index++)
					{
						string frukt = frukter[index];
						double pris = priser[index];
						Console.WriteLine($"{frukt} - {pris} kr/kg");
					}
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
