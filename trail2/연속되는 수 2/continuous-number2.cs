using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;
        int max_cnt = 0;
        int[] arr = new int[N];
        for(int i = 0; i < N; i++)
            arr[i] = int.Parse(Console.ReadLine());

        for(int j = 0; j < N; j++)
        {
            if(j == 0 || arr[j] == arr[j-1])
                cnt++;
            else
            {
                if(cnt > max_cnt)
                    max_cnt = cnt;
                
                cnt = 1;
            }
        }

        if(cnt > max_cnt)
            max_cnt = cnt;

        Console.Write(max_cnt);
    }
}
