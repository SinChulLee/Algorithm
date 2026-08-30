using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int target = new int();

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
            if (sum >= N)  
            {
                target = i;
                break;
            }  
        }

        Console.Write(target);
    }
}
