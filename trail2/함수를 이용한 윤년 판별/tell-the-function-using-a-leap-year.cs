using System;

public class Codetree
{  
    public static bool Isyoon(int y)
    {
        if(y % 4 != 0 || (y % 100 == 0 && y % 400 != 0))
            return false;
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        int y = int.Parse(Console.ReadLine());
        if(Isyoon(y))
            Console.Write("true");
        else
            Console.Write("false");
    }
}
