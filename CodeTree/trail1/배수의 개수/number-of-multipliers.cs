using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int cnt_3 = 0;
        int cnt_5 = 0;
        for (int i = 1; i <= 10; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0)
                cnt_3++;
            if (num % 5 == 0)
                cnt_5++;
        }

        Console.Write($"{cnt_3} {cnt_5}");
    }
}
