using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int num;
        bool satisfied = true;

        for (int i = 0; i < 5; i++)
        {
            num = int.Parse(Console.ReadLine());
            if (num % 3 != 0)
            {
                satisfied = false;
                Console.Write(0);
                break;
            }            
        }

        if (satisfied)
            Console.Write(1);

    }
}
