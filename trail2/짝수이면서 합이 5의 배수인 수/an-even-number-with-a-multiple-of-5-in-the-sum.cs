using System;

public class Codetree
{  
    public static void Ismagicnum(int n)
    {
        if(n % 2 == 0 && ((n / 10) + (n % 10)) % 5 == 0)
            Console.Write("Yes");
        else
            Console.Write("No");
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        Ismagicnum(n);
    }
}
