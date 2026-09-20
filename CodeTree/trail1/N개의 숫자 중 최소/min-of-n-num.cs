using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int min = int.MaxValue;
        int cnt = 0;

        for(int i = 0; i < N; i++)
        {
            if(arr[i] < min)
            {
                cnt = 1;
                min = arr[i];
            }
            else if(arr[i] == min)
                cnt++;
        }
        
        Console.Write($"{min} {cnt}");
    }
}
