using System;
using System.Collections.Generic;
using System.Linq;


namespace LiczbyGradowe
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = 0;
			List<int> list = new List<int>();
			Console.WriteLine("Podaj liczbę");
			n = int.Parse(Console.ReadLine());
			list.Add(n);
			while (n != 1)
			{
				if (n % 2 == 0)
				{
					n /= 2;
					list.Add(n);
				}

				else
				{
					n = 3 * n + 1;
					list.Add(n);

				}
				Console.WriteLine(n);

			}
			Console.WriteLine("Maksymalna liczba: " + list.Max());
			Console.WriteLine("Ilość ktoków: " + list.Count);

		}
	}
}
