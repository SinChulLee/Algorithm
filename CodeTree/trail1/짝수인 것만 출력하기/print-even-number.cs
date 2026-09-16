using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int[] ansarr = new int[N];
        int cnt = 0;

        for(int i = 0; i < N; i++)
        {
            if(arr[i] % 2 == 0)
            {
                ansarr[cnt] = arr[i];
                cnt++;
            }
        }

        for(int j = 0; j < cnt; j++)
        {
            Console.Write($"{ansarr[j]} ");
        }

    }
}
