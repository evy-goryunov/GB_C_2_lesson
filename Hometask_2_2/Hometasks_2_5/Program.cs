using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Горюнов Евгений
// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
// б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

namespace Hometasks_2_5
{
	class Program
	{
		static void Main(string[] args)
		{
			double weight;
			double height;
			double bodyMassIndex;
			double normalWeight;
			double normalBodyMassIndex = 23;


			Console.WriteLine("Введите ваш вес в килограммах.");
			weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите ваш рост в метрах.");
			height = Convert.ToDouble(Console.ReadLine());

			bodyMassIndex = weight / (height * height);
			normalWeight = normalBodyMassIndex * (height * height);



			Console.WriteLine("Ваш ИМТ: {0:F1}", bodyMassIndex);

			if (bodyMassIndex <= 18)
				Console.WriteLine("У вас дефицит веса, лучше питайтесь");
			else if (bodyMassIndex > 18 && bodyMassIndex <= 25) Console.WriteLine("Ваш вес в норме");
			else if (bodyMassIndex > 25) Console.WriteLine("У вас лишний вес, пора скинуть пару кило");
			Console.WriteLine("Норма массы тела для вас: {0:F1}", normalWeight);
			Console.ReadKey();
		}
	}
}
