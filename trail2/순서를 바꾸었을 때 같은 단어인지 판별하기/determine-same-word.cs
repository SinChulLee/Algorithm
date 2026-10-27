using System;

public class Codetree
{  
    public static bool F(string a, string b)
    {
        char[] Aarr = a.ToCharArray();
        char[] Barr = b.ToCharArray();
        if(Aarr.Length != Barr.Length)
            return false;
        Array.Sort(Aarr); Array.Sort(Barr);
        for(int i = 0; i < Aarr.Length; i++)
        {
            if(Aarr[i] != Barr[i])
                return false;
        }
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        if(F(a,b))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
