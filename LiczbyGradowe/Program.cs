using System;

namespace LiczbyGradowe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			Console.WriteLine("Podaj liczbę");
			n = int.Parse(Console.ReadLine());

			while (n != 1)
			{
				if (n % 2 == 0)
				{
					n /= 2;
				}

				else
				{
					n = 3 * n + 1;
				}
			Console.WriteLine(n);
			}
			
			
		}
	}
}
