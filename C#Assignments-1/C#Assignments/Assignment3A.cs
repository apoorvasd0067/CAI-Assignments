using System;
class Assignment3A
{
    static void Main()
    {
        string input = "A tiger is a large-hearted gentleman with boundless courage and that when he is exterminated as exterminated he will be unless public opinion rallies to his support India will be the poorer by having lost the finest of her fauna.";
        int countA = 0, countE = 0, countI = 0, countO = 0, countU = 0;
        foreach (char c in input.ToLower())
        {
            if (c == 'a')
                countA++;
            else if (c == 'e')
                countE++;
            else if (c == 'i')
                countI++;
            else if (c == 'o')
                countO++;
            else if (c == 'u')
                countU++;
        }
        Console.WriteLine("Count of a={0}, e={1}, i={2}, o={3}, u={4}", countA, countE, countI, countO, countU);
    }
}