using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string[] arr = new string[N];
        for(int i = 0; i < N; i++)
        {
            arr[i] = Console.ReadLine();
        }

        char target = Console.ReadLine()[0];
        int cnt = 0;
        int len = 0;

        for(int i = 0; i < N; i++)
        {
            if(arr[i][0] == target)
            {
                cnt++;
                len += arr[i].Length;
            }
        }

        Console.Write($"{cnt} {((double)len)/cnt:F2}");
    }
}
