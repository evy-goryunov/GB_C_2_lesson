using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Горюнов Евгений
//2. Написать метод подсчета количества цифр числа.

namespace Hometask_2_2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите число");
			String number = Console.ReadLine();
			Console.WriteLine($"Цифр в числе: {Counter(number)}");
			Console.ReadKey();
		}

		public static int Counter(String num)
		{
			int count = num.Length;
			return count;
		}
	}
}
