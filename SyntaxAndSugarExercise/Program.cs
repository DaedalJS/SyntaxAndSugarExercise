using System;

namespace SyntaxAndSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("give us a number.");
            var answer = Console.ReadLine();

            var response = (int.Parse(answer) < 9) ? $"{answer} is less than nine." : $"{answer} is greater than or equal to nine.";

            Console.WriteLine($"{response}");
        }
    }
}
