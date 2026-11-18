using System;

public class Codetree
{
    public static void Main()
    {
        string[] first = Console.ReadLine().Split();
        int n = int.Parse(first[0]);
        int m = int.Parse(first[1]);

        int[] va = new int[n], ta = new int[n];
        for (int i = 0; i < n; i++)
        {
            string[] line = Console.ReadLine().Split();
            va[i] = int.Parse(line[0]);
            ta[i] = int.Parse(line[1]);
        }

        int[] vb = new int[m], tb = new int[m];
        for (int i = 0; i < m; i++)
        {
            string[] line = Console.ReadLine().Split();
            vb[i] = int.Parse(line[0]);
            tb[i] = int.Parse(line[1]);
        }

        // Please write your code here.
        const int OFFSET = 1000001;
        int[] A = new int[OFFSET], B = new int[OFFSET];
        int sec = 0; int pos = 0;
        // 시간당 A 위치 기록
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < ta[i]; j++)
            {
                sec++;
                pos += va[i];
                A[sec] = pos;
            }
        }

        sec = 0; pos = 0;
        // 시간당 B 위치 기록
        for (int i = 0; i < m; i++)
        {
            for(int j = 0; j < tb[i]; j++)
            {
                sec++;
                pos += vb[i];
                B[sec] = pos;
            }
        }

        int cnt = 0;
        string presentfirst = string.Empty;
        for(int i = 1; i <= sec; i++)
        {
            if(A[i] > B[i] && presentfirst != "A")
            {
                cnt++;
                presentfirst = "A";
            }
            else if(A[i] < B[i] && presentfirst != "B")
            {
                cnt++;
                presentfirst = "B";
            }
            else if(A[i] == B[i] && presentfirst != "AB")
            {
                cnt++;
                presentfirst = "AB";
            }
        }
        Console.Write(cnt);
    }
}