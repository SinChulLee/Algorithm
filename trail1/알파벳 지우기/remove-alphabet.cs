using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string aa = "";
        string bb = "";
        for(int i = 0; i < a.Length; i++)
        {
            if(a[i] >= '0' && a[i] <= '9')
                aa += a[i];
        }

        for(int i = 0; i < b.Length; i++)
        {
            if(b[i] >= '0' && b[i] <= '9')
                bb += b[i];
        }
        Console.Write(int.Parse(aa) + int.Parse(bb));
    }
}
