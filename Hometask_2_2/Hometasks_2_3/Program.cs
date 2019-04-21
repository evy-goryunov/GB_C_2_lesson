using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
namespace Hometasks_2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			int count = 0;
			Console.WriteLine("Вводите числа чтобы узнать их сумму нечетных положительных чисел");
			while(true)
			{
				int num = Convert.ToInt32(Console.ReadLine());
				if (num > 0 && num % 2 != 0) count = count + num;
				else if (num == 0)
				{
					break;
				}
			}
			Console.WriteLine($"Сумма нечётных положительных чисел: {count}");
			Console.ReadKey();
		}
	}
}
