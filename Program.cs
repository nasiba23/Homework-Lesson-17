using System;
using System.Linq;

namespace HomeworkLesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            // FirstTask();
            // SecondTask();
            ThirdTask();
        }

        static void FirstTask()
        {
            Console.Write("Enter a word: ");
            var word = Console.ReadLine();
            var newWord = word
                .Select(ch => ch == 'a' ? '1' : ch)
                .Select(ch => ch == 'e' ? '2' : ch)
                .Select(ch => ch == 'i' ? '3' : ch)
                .Select(ch => ch == 'o' ? '4' : ch)
                .Select(ch => ch == 'u' ? '5' : ch);
            foreach (var x in newWord)
            {
                Console.Write(x);
            }
        }

        static void SecondTask()
        {
            Console.Write("Enter a number: ");
            var word = Console.ReadLine();
            var newWord = word
                .Select(ch => ch == '1' ? 'a' : ch)
                .Select(ch => ch == '2' ? 'e' : ch)
                .Select(ch => ch == '3' ? 'i' : ch)
                .Select(ch => ch == '4' ? 'o' : ch)
                .Select(ch => ch == '5' ? 'u' : ch);
            foreach (var ch in newWord)
            {
                Console.Write(ch);
            }
        }

        static void ThirdTask()
        {
            var word = "gdfgdf234dg54gf*23oP42";

            var symbol = word
                .FirstOrDefault(char.IsPunctuation);

            var operation = new string(word
                .Where(ch => char.IsDigit(ch) || char.IsPunctuation(ch)).ToArray()).Split(symbol);

            var result = symbol switch
            {
                '+' => double.Parse(operation[0]) + double.Parse(operation[1]),
                '-' => double.Parse(operation[0]) - double.Parse(operation[1]),
                '*' => double.Parse(operation[0]) * double.Parse(operation[1]),
                '/' => double.Parse(operation[0]) / double.Parse(operation[1]),
                _ => 0,
            };
            Console.WriteLine(Math.Round(result).ToString());
        }
    }
}