using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int cnt = 0;
        string[] input2 = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input2, int.Parse);

        for(int i = 0; i < N; i++)
        {
            if(arr[i] == M)
                cnt++;
        }

        Console.Write(cnt);

    }
}
