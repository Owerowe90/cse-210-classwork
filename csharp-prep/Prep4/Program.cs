using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");
        bool input = false;

        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a list of numbers. Press 0 when finished.");
        while(input == false)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            if (num != 0){
                numbers.Add(num);
                input = false;
            }

            else {
                Console.WriteLine("Thank you!");
                input = true;
            }
        }
        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}");
    }
}