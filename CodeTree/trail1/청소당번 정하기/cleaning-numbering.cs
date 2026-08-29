using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());

        int cnt = 1;
        int a_cnt = 0;
        int b_cnt = 0;
        int c_cnt = 0;
        for (int i = 0; i < n; i++)
        {
            if (cnt % 12 == 0)
                c_cnt++;
            else if (cnt % 3 == 0)
                b_cnt++;
            else if (cnt % 2 == 0)
                a_cnt++;
            cnt++;
        }
        Console.Write($"{a_cnt} {b_cnt} {c_cnt}");
    }
}
