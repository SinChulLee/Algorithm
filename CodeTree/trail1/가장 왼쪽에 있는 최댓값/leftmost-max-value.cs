using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int cnt = N;
        int maxcnt = 0;
        int max = int.MinValue;

        while(cnt > 0)
        {
            for(int i = 0; i < cnt; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    maxcnt = i;
                }
            }
            Console.Write($"{maxcnt+1} ");
            max = int.MinValue;
            cnt = maxcnt;
        }
    }
}
