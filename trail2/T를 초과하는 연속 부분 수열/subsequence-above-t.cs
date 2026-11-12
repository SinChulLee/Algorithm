using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int T = int.Parse(input[1]);
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int cnt = 0;
        int max_cnt = 0;

        for(int i = 0; i < N; i++)
        {
            if(arr[i] > T)
                cnt++;
            else
                cnt = 0;
            
            max_cnt = Math.Max(cnt, max_cnt);
        }

        Console.Write(max_cnt);
    }
}
