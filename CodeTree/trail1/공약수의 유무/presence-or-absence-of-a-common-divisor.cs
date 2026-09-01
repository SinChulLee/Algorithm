using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        bool isexist = false;

        for (int i = A; i <= B; i++)
        {
            if (1920 % i == 0 && 2880 % i == 0)
                isexist = true;
        }
        if (isexist)
            Console.Write(1);
        else
            Console.Write(0);
    }
}
