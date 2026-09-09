using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 0;

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                if(i % 2 == 0)
                    cnt++;
                else
                    cnt = cnt + 2;
                Console.Write($"{cnt} ");
            }
            Console.WriteLine();
        }
    }
}
