using System;
class Assignment7B
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();
        int length = CalculateStringLength(inputString);
        Console.WriteLine($"Length of the string \"{inputString}\" is: {length}");
    }
    static int CalculateStringLength(string inputString)
    {
        int length = 0;
        foreach (char c in inputString)
        {
            length++;
        }
        return length;
    }
}