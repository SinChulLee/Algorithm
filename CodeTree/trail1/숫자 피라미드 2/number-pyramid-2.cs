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
            for(int j = 1; j <= i; j++)
            {
                Console.Write($"{cnt} ");
                cnt++;
            }
            Console.WriteLine();
        }
    }
}
