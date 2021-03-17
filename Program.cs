using System;
using System.Linq;

namespace HomeworkLesson17
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstTask();
        }

        static void FirstTask()
        {
            Console.Write("Enter a word: ");
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
    }
}