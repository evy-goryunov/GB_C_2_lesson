using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Горюнов Евгений
4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, 
и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
С помощью цикла do while ограничить ввод пароля тремя попытками.
*/
namespace Hometasks_2_4
{
	class Program
	{

		static void Main(string[] args)
		{
			int count = 3;
			bool flag = false;
			do
			{
				Console.WriteLine("Введите логин");
				String userLogin = Console.ReadLine();
				Console.WriteLine("Введите пароль");
				String userPass = Console.ReadLine();
				flag = checkLoginPass(userLogin, userPass);

				if (flag == false)
				{
					Console.WriteLine("Вы ввели неверный логин или пароль");
					count--;
				}
				else
				{
					Console.WriteLine("Доступ разрешён");
					break;
				}


			} while (count > 0);

			Console.ReadKey();
			
		}

		public static bool checkLoginPass (String userLogin, String userPass)
		{
			bool check = false;
			String LOGIN = "root";
			String PASSWORD = "GeekBrains";

			if (userLogin == LOGIN && userPass == PASSWORD)
			{
				check = true;
			}
			
			
			return check;
		}
	}
}
