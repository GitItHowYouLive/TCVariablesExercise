using System;

namespace TCVariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vrGame = "Population One";
            int currentAge = 33;
            char malcolm = 'X';
            bool cool = true;
            double down = 10.10;
            decimal seven = 7;

            Console.WriteLine($"Hi! My name is Terrence and my favorite VR game is currently {vrGame}");
            Console.WriteLine($"I am {currentAge} years old and I love to watch the {malcolm}-Games");
            Console.WriteLine($"It's {cool} that I'm awesome, even if I only have ${down} in my bank account");
            Console.WriteLine($"Also, 7 looks like this: {seven}");
        }
    }
}
