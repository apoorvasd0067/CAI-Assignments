using System;

public class Assignment7C
{
    public static void Main()
    {
        
        int n;

        Console.Write("enter num of elements in the array :\n");  
        n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr[i] = Convert.ToInt32(Console.ReadLine());  
        }
        Console.WriteLine("Enter the position");
        int popelement = int.Parse(Console.ReadLine());
        if (popelement < arr.Length)
        {
            int[] newArray = new int[arr.Length - 1]; 
            for (int i = 0; i < popelement; i++)
            {
                newArray[i] = arr[i];
            }

            for (int i = popelement; i < arr.Length - 1; i++)
            {
                newArray[i] = arr[i + 1];
            }

            arr = newArray;
            Console.Write("\nElements in array are: ");


            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                Console.Write(" ");
            }

            Console.Write(" ");
        }
    }
}
