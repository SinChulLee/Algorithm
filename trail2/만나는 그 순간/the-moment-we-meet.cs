using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int d, t;
        int[] A = new int[1000001];
        int[] B = new int[1000001];
        int ans =  -1;
        int sec = 0;
        int pos = 0;
        for(int i = 0; i < N; i++)
        {
            string[] input1 = Console.ReadLine().Split();
            d = input1[0][0];
            t = int.Parse(input1[1]);
            for(int m = 0; m < t; m++)
            {
                sec++;
                if(d == 'R')
                    pos++;
                else
                    pos--;
                A[sec] = pos;
            }
        }

        sec = 0;
        pos = 0;
        for(int j = 0; j < M; j++)
        {
            string[] input2 = Console.ReadLine().Split();
            d = input2[0][0];
            t = int.Parse(input2[1]);
            for(int n = 0; n < t; n++)
            {
                sec++;
                if(d == 'R')
                    pos++;
                else
                    pos--;
                B[sec] = pos;
            }
        }

        for(int k = 1; k <= sec; k++)
        {
            if(A[k] == B[k])
            {
                Console.Write(k);
                return;
            }
        }
        Console.Write(-1);
    }
}
