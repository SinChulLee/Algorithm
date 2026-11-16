using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        const int OFFSET = 1000001;
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[] A = new int[OFFSET];
        int[] B = new int[OFFSET];
        int pos = 0;
        int sec = 0;
        for(int i = 0; i < N; i++)
        {
            input = Console.ReadLine().Split();
            int v = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            for(int j = 0; j < t; j++)
            {
                sec++;
                A[sec] = A[sec - 1] + v;
            }
        }

        pos = 0; sec = 0;
        for(int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split();
            int v = int.Parse(input[0]);
            int t = int.Parse(input[1]);
            for(int j = 0; j < t; j++)
            {
                sec++;
                B[sec] = B[sec - 1] + v;
            }
        }

        string first = string.Empty;
        int cnt = 0;
        for(int i = 0; i <= sec; i++)
        {
            if(A[i] > B[i])
            {
                if(first == "B")
                    cnt++;
                first = "A";
            }
            if(A[i] < B[i])
            {
                if(first == "A")
                    cnt++;
                first = "B";
            }
        }   
        Console.Write(cnt);
    }
}
