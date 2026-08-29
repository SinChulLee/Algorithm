using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int cnt = 0;
        for (int i = 0; i < 5; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                cnt++;
        }
        Console.Write(cnt);
    }
}
