using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int lowmax = -1;
        int highmin = 1000;

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] < 500)
            {
                if(arr[i] > lowmax)
                    lowmax = arr[i];
            }
            else
            {
                if(arr[i] < highmin)
                    highmin = arr[i];
            }
        }

        Console.Write($"{lowmax} {highmin}");
    }
}
