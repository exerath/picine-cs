using System.IO;
using System;

namespace Project
{
	public class Program
	{
		static public void Main(string [] args)
		{
			string []input = args[0].Split(' ');
			if (input[1] == "RUB")
			{
				Exchanger.ConvertRub(double.Parse(input[0]));
			}
			if (input[1] == "EUR")
			{
				Exchanger.ConvertEur(double.Parse(input[0]));
			}

			if (input[1] == "USD")
			{
				Exchanger.ConvertUsd(double.Parse(input[0]));
			}
			else
			{
				Console.WriteLine ("Ошибка ввода. Проверьте входные данные и повторите запрос.");
			}
		}

	}
	public class Exchanger
	{
		static public void ConvertRub(double sum)
		{
			string path = @"C:\CODE\C# picine\d01\d01_ex00.cs\rates\RUB.txt";
			double RubToEur, RubToUsd;
			string text = File.ReadAllText(@path);
			string []Line;
			Line = text.Split('\n');
			double USD, EUR;
			USD = double.Parse(Line[0].Substring(4));
			EUR = double.Parse(Line[1].Substring(4));

			RubToUsd = Math.Round((sum * USD), 2);
			RubToEur = Math.Round((sum * EUR), 2);

			Console.WriteLine ($"Сумма в исходной валюте: {sum}");
			Console.WriteLine ($"Сумма в USD: {RubToUsd}");
			Console.WriteLine ($"Сумма в EUR: {RubToEur}");
		}
		static public void ConvertUsd(double sum)
		{
			string path = @"C:\CODE\C# picine\d01\d01_ex00.cs\rates\USD.txt";
			double UsdToRub, UsdToEur;
			string text = File.ReadAllText(@path);
			string []Line;
			Line = text.Split('\n');
			double RUB, EUR;
			RUB = double.Parse(Line[0].Substring(4));
			EUR = double.Parse(Line[1].Substring(4));

			UsdToRub = Math.Round((sum * RUB), 2);
			UsdToEur = Math.Round((sum * EUR), 2);

			Console.WriteLine ($"Сумма в исходной валюте: {sum}");
			Console.WriteLine ($"Сумма в RUB: {UsdToRub}");
			Console.WriteLine ($"Сумма в EUR: {UsdToEur}");
		}
		static public void ConvertEur(double sum)
		{
			string path = @"C:\CODE\C# picine\d01\d01_ex00.cs\rates\EUR.txt";
			double EurToUsd, EurToRub;
			string text = File.ReadAllText(@path);
			string []Line;
			Line = text.Split('\n');
			double USD, RUB;
			USD = double.Parse(Line[0].Substring(4));
			RUB = double.Parse(Line[1].Substring(4));

			EurToUsd = Math.Round((sum * USD), 2);
			EurToRub = Math.Round((sum * RUB), 2);

			Console.WriteLine ($"Сумма в исходной валюте: {sum}");
			Console.WriteLine ($"Сумма в USD: {EurToUsd}");
			Console.WriteLine ($"Сумма в RUB: {EurToRub}");
		}
	}
}