using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] array = new int[10];
        int count = 0;

        string[] input = Console.ReadLine().Split(' ');

        for(int i = 0; i < input.Length; i++)
        {
            int num = int.Parse(input[i]);
            if(num == 0)
                break;
            array[i] = num;
            count++;
        }

        for(int j = count - 1; j >= 0; j--)
        {
            Console.Write($"{array[j]} ");
        }
    }
}
