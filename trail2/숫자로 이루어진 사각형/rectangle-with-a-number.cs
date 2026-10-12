using System;

public class Codetree
{  
    public static void PrintRect(int n)
    {
        int cnt = 1;
        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(cnt == 10)
                    cnt = 1;
                Console.Write($"{cnt} ");
                cnt++;
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        PrintRect(N);
    }
}
