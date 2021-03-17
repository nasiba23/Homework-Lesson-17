using System;
using System.Linq;

namespace HomeworkLesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
        }

        static void FirstTask()
        {
            Console.Write("Введите слово, а мы все строчные гласные заменим цифрами: ");
            var word = Console.ReadLine();
            var newWord = word
                .ToCharArray()
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
            Console.Write("Введите слово, а мы все цифры заменим гласными: ");
            var word = Console.ReadLine();
            var newWord = word
                .ToCharArray()
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
    }
}