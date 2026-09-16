using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int target = 0;
        for(int i = 0; i < 10; i++)
        {
            if(arr[i] % 3 == 0)
            {
                target = i;
                break;
            }
        }
        Console.Write(arr[target-1]);
    }
}
