using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[100];
        arr = Array.ConvertAll(input, int.Parse);
        int cnt = 0;


        for(int i = 0; i < 100; i++)
        {
            if(arr[i] == 0)
                break;
            cnt++;
        }

        for(int j = 0; j < cnt; j++)
        {
            if(arr[j] % 2 == 1)
                arr[j] += 3;
            else
                arr[j] /= 2;
            Console.Write($"{arr[j]} ");
        }
    }
}
