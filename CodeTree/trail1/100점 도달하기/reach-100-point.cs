using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = N;
        while (cnt <= 100)
        {
            if (cnt >= 90)
                Console.Write("A ");
            else if (cnt >= 80)
                Console.Write("B ");
            else if (cnt >= 70)
                Console.Write("C ");
            else if (cnt >= 60)
                Console.Write("D ");
            else
                Console.Write("F ");
            cnt++;
        }
    }
}
