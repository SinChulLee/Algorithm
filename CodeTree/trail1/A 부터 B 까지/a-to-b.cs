using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int cnt = A;

        while (cnt <= B)
        {
            Console.Write($"{cnt} ");
            if (cnt % 2 != 0)
            {
                cnt *= 2;
            }
            else if (cnt % 2 == 0)
            {
                cnt += 3;
            }
        }
    }
}
