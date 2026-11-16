using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        const int OFFSET = 2000001;
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[] A = new int[OFFSET];
        int[] B = new int[OFFSET];

        int pos = 0;
        int A_sec = 0;
        for(int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split();
            int t = int.Parse(input[0]);
            char d = input[1][0];
            for(int j = 0; j < t; j++)
            {
                A_sec++;
                if(d == 'L')
                    pos--;
                else
                    pos++;
                A[A_sec] = pos;
            }
        }

        pos = 0;
        int B_sec = 0;
        for(int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split();
            int t = int.Parse(input[0]);
            char d = input[1][0];
            for(int j = 0; j < t; j++)
            {
                B_sec++;
                if(d == 'L')
                    pos--;
                else
                    pos++;
                B[B_sec] = pos;
            }
        }

        // A 또는 B의 sec이 더 클경우 sec이 더 작은 로봇의 값은 마지막 위치로 고정해야함
        if(A_sec > B_sec)
        {
            for(int i = B_sec + 1; i <= A_sec; i++)
            {
                B[i] = B[B_sec];
            }
        }
        else if(B_sec > A_sec)
        {
            for(int i = A_sec + 1; i <= B_sec; i++)
            {
                A[i] = A[A_sec];
            }
        }

        int cnt = 0;
        for(int i = 1; i <= Math.Max(A_sec,B_sec); i++)
        {
            if(A[i] == B[i])
                if(A[i-1] != B[i-1])
                    cnt++;
        }
        Console.Write(cnt);
    }
}