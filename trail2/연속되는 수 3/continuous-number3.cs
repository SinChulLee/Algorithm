using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int max_cnt = 1;
        int cnt = 1;
        int[] arr = new int[N];
        for(int i = 0; i < N; i++)
            arr[i] = int.Parse(Console.ReadLine());

        for(int j = 1; j < N; j++)
        {
            if(arr[j] < 0 && arr[j-1] < 0)
            {
                cnt++;
            }
            else if(arr[j] >= 0 && arr[j-1] >= 0)
            {
                cnt++;
            }
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
