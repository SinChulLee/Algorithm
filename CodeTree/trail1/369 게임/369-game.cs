using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());

        int cnt = 1;

        while (cnt <= N)
        {
            string s = cnt.ToString();
            if (cnt % 3 == 0 || s.Contains('3') 
            || s.Contains('6') || s.Contains('9'))
            {
                Console.Write("0 ");
            }
            else
                Console.Write($"{cnt} ");
            cnt++;
        }

    }
}
