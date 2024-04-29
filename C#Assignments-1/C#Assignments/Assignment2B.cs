using System;
class Assignment2B
{
    static void Main()
    {
        Console.WriteLine("Enter a five-digit number:");
        int number = int.Parse(Console.ReadLine());

        if (number >= 10000 && number <= 99999)
        {
            int newNumber = 0;
            int divisor = 10000;

            while (divisor > 0)
            {
                int digit = number / divisor % 10;
                digit = (digit + 1) % 10;
                newNumber = newNumber * 10 + digit;
                divisor /= 10;
            }
            Console.WriteLine("Output--> " + newNumber);
        }
        else
        {
            Console.WriteLine("Please enter a valid five-digit number.");
        }
    }
}