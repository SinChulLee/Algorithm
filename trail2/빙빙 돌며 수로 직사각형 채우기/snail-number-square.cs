using System;

public class Codetree
{  
    static int N;
    static int M;

    public static bool inRange(int x, int y)
    {
        return (0 <= x && x < N && 0 <= y && y < M);
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        int[,] ans = new int[N,M];
        int[] dx = {0,1,0,-1};
        int[] dy = {1,0,-1,0};
        int x = 0;
        int y = 0;
        int dirNum = 0;
        for(int cnt = 1; cnt <= N*M; cnt++)
        {
            ans[x,y] = cnt;
            int nx = x + dx[dirNum];
            int ny = y + dy[dirNum];
            if(!inRange(nx,ny) || ans[nx, ny] != 0)
            {
                dirNum++;
                if(dirNum > 3)
                    dirNum = 0;
                nx = x + dx[dirNum];
                ny = y + dy[dirNum];
            }
            x = nx;
            y = ny;
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {
                Console.Write($"{ans[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
