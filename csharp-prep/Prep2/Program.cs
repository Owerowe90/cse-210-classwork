using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        bool guessed = false;
        int turns = 0;
        while(guessed == false)
        {
            Console.Write("Please Enter Your Guess: ");
            turns += 1;
            int answer = int.Parse(Console.ReadLine());
            if (answer > number)
            {
                Console.WriteLine("lower");
                guessed = false;
            }
            else if (answer < number)
            {
                Console.WriteLine("higher");
                guessed = false;
            }
            else
            {
                Console.WriteLine("Good Job!");
                guessed = true;
            }
        }
        Console.WriteLine($"It took you {turns} turns to guess the number!");
    }
}