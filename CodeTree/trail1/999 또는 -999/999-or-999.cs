using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int max = int.MinValue;
        int min = int.MaxValue;
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        for(int i = 0; i < arr.Length; i++)
        {
            int num = arr[i];
            if(num == 999 || num == -999)
                break;
            if(num < min)
                min = num;
            if(num > max)
                max = num;
        }
        Console.Write($"{max} {min}");
    }
}
