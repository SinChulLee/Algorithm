using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 1;

        for(int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= N; j++)
            {
                if(j >= i)
                {
                    Console.Write($"{cnt} ");
                    cnt++;
                }
                else
                    Console.Write($"  ");
                if(cnt > 9)
                    cnt = 1;
            }
            Console.WriteLine();
        }
    }
}
