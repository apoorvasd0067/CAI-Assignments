using System;
class Assignment6A
{
    static void Main(string[] args)
    {
        string sentence = "What do you know about me? Out of everything, I found nothing about you";
        string substring = "ou";
        Console.WriteLine($"The original sentence is: \"{sentence}\"");
        Console.WriteLine($"The substring to find is: \"{substring}\"");
        int occurrences = CountSubstringOccurrences(sentence, substring);
        Console.WriteLine($"Number of occurrences of \"{substring}\" in the sentence: {occurrences}");
    }
    static int CountSubstringOccurrences(string sentence, string substring)
    {
        int count = 0;
        int subLength = substring.Length;
        int senLength = sentence.Length;
        for (int i = 0; i <= senLength - subLength; i++)
        {
            bool found = true;
            for (int j = 0; j < subLength; j++)
            {
                if (sentence[i + j] != substring[j])
                {
                    found = false;
                    break;
                }
            }
            if (found)
            {
                count++;
            }
        }
        return count;
    }
}