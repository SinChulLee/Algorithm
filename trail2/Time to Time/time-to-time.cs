using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        int D = int.Parse(input[3]);
        int elapesdTime = 0;
        while(true)
        {
            if(A == C && B == D)
                break;
            elapesdTime++;
            B++;

            if(B == 60)
            {
                B = 0;
                A++;
            }
        }

        Console.Write(elapesdTime);
    }
}
