using System;

namespace Subtask_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string str, strToReplace;
			string isContinue = "yes";

			while (isContinue == "yes")
			{
				Console.Write("Введiть стрiчку: ");
				str = Console.ReadLine();
				Console.Write("Введiть стрiчку, на яку ми замiнемо пiдстрiчки з подвоєнням лiтер: ");
				strToReplace = Console.ReadLine();

				StringOperations stringOperations = new StringOperations(str);

				Console.WriteLine("Iндекс другого входження заданої пiдстрiчки в текст: " +
					stringOperations.IndexOfSecondOccurrence());
				Console.WriteLine("Кiлькiсть слiв, що починаються з великої лiтри: " +
					stringOperations.CapitalizedWordsAmount());
				Console.WriteLine("Всi слова, що мiстили подвоєння лiтер, замiненi на заданий " +
					"користувачем текст: " + 
					stringOperations.ReplacingWordWithDoubledLetters(strToReplace));

				Console.Write("Введiть yes, якщо хочете повторити виконання програми: ");
				isContinue = Console.ReadLine();
			}

			Console.ReadKey();
		}
	}
}
