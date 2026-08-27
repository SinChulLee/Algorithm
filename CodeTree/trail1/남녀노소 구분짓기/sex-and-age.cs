using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int gen = int.Parse(Console.ReadLine());
        int age = int.Parse(Console.ReadLine());

        if (gen == 0)
        {
            if (age >= 19)
                Console.Write("MAN");
            else
                Console.Write("BOY");
        }
        else
        {
            if (age >= 19)
                Console.Write("WOMAN");
            else
                Console.Write("GIRL");
        }
    }
}
