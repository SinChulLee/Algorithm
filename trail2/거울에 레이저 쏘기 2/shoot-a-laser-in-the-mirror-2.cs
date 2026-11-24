using System;

public class Codetree
{  
    static int N;
    public static bool InRange(int x, int y)
    {
        return 0 <= x && x < N && 0 <= y && y < N;
    }

    public static (int, int, int) func(int N, int K)
    {
        int x = 0;
        int y = 0;
        int dir = 0;
        if(K <= N)
        {
            x = 0;
            y = K - 1;
            dir = 0;
        }
        else if(K <= 2 * N)
        {
            x = K - N - 1;
            y = N - 1;
            dir = 1;
        }
        else if(K <= 3 * N)
        {
            x = N - 1;
            y = 3 * N - K;
            dir = 2;
        }
        else
        {
            x = 4 * N - K;
            y = 0;
            dir = 3;
        }
        return (x, y, dir);
    }

    public static void Main()
    {
        // Please write your code here.
        N = int.Parse(Console.ReadLine());
        string[,] arr = new string[N,N];
        for(int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            for(int j = 0; j < N; j++)
            {
                arr[i,j] = input[j].ToString();
            }
        }

        int K = int.Parse(Console.ReadLine());
        int cnt = 0;
        // 하좌상우
        int[] dx = {1, 0, -1, 0};
        int[] dy = {0, -1, 0, 1};
        var (x, y, dir) = func(N, K);
        while(InRange(x,y))
        {
            // 거울에 따른 방향 변경
            // if(arr[x,y] == "/")
            // {
            //     dir = dir ^ 1;
            // }
            // else
            // {
            //     dir = 3 - dir;
            // }
            if(arr[x,y] == "/")
            {
                if(dir == 0) dir = 1;
                else if(dir == 1) dir = 0;
                else if(dir == 2) dir = 3;
                else if(dir == 3) dir = 2;
            }
            else
            {
                if(dir == 0) dir = 3;
                else if(dir == 1) dir = 2;
                else if(dir == 2) dir = 1;
                else if(dir == 3) dir = 0;
            }

            cnt++;

            // 변경된 방향으로 이동
            x += dx[dir];
            y += dy[dir];
        }
        Console.Write(cnt);
    }
}
