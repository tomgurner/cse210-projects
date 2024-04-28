using System;
using System.Reflection.Emit;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.WriteLine("Enter number. Type 0 to quit: ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = int.MinValue;
        
        bool foundPositive = false;
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }

            if (number > 0 && !foundPositive)
            {
                smallestPositive = number;
                foundPositive = true;
            }
            else if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        if (foundPositive)
        {
            Console.WriteLine($"The smallest positive number is {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers found.");
        }

        numbers.Sort();

        Console.WriteLine("The sorted list is: ");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}