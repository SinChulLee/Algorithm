using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        if (n == 2)
            Console.Write(28);
        else if (n == 4 || n == 6 || n == 9 || n == 11)
            Console.Write(30);
        else
            Console.Write(31);
    }   
}
