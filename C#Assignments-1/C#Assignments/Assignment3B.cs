using System;
class Assignment3B
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows:");
        int numRows = int.Parse(Console.ReadLine());
        for (int i = 1; i <= numRows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}