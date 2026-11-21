using System;

public class Codetree
{  
    static int N;

    public static bool IsVaild(int x, int y)
    {
        return (0 <= x && x < N && 0 <= y && y < N);
    }

    public static void Main()
    {
        // Please write your code here.
        N = int.Parse(Console.ReadLine());
        int[][] a = new int[N][];
        for(int i = 0; i < N; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            a[i] = arr;
        }

        int ans = 0;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                int cnt = 0;
                if(IsVaild(i,j+1) && a[i][j+1] == 1)
                    cnt++;
                if(IsVaild(i,j-1) && a[i][j-1] == 1)
                    cnt++;
                if(IsVaild(i+1,j) && a[i+1][j] == 1)
                    cnt++;
                if(IsVaild(i-1,j) && a[i-1][j] == 1)
                    cnt++;
                if(cnt > 2)
                    ans++;
            }
        }

        Console.Write(ans);
    }
}
