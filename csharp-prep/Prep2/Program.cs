using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is grade percent? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string sign = "";

        // Letter grade A
        if (percent >= 90)
        {
            letter = "A";
        }

        // Letter Grade B
        else if (percent >= 80)
        {
            letter = "B";
        }

        // Letter Grade C
        else if (percent >= 70)
        {
            letter = "C";
        }

        // Letter Grade D
        else if (percent >= 60)
        {
            letter = "D";
        }

        // Letter Grade F
        else
        {
            letter = "F";
        }

        // Sign with A+ accounted for
        if (percent > 59 && percent < 97)
        {
            if (percent % 10 >= 7)
            {
                sign = "+";
            }
            else if (percent % 10 < 3)
            {
                sign = "-";
            }
        }
        else if (percent > 100)
        {
            sign = "+";
        }


        Console.WriteLine($"Your grade is: {letter}{sign} ");

        if (percent >= 60)
        {
            Console.WriteLine("Passed! Congratulations!");
        }
        else
        {
            Console.WriteLine("Failed. The second time will be better.");
        }
    }
}