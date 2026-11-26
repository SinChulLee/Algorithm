using System;

public class Codetree
{  
    static int N, M, x, y;
    static int dirnum = 0;
    static int[] dx = new int[]{0, 1, 0, -1};
    static int[] dy = new int[]{1, 0, -1, 0};
    static char[,] arr;

    public static bool InRange(int x, int y)
    {
        return 0 <= x && x < N && 0 <= y && y < M;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);
        x = 0; y = 0;
        arr = new char[N,M];
        char cnt = 'A';
        for(int i = 0; i < N * M; i++)
        {
            arr[x,y] = cnt;
            cnt++;
            if(cnt > 'Z')
                cnt = 'A';
            int nx = x + dx[dirnum];
            int ny = y + dy[dirnum];
            if(!InRange(nx, ny) || arr[nx,ny] != '\0')
            {
                dirnum++;
                if(dirnum > 3)
                    dirnum = 0;
                nx = x + dx[dirnum];
                ny = y + dy[dirnum];
            }
            x = nx;
            y = ny;
        }
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
                Console.Write($"{arr[i,j]} ");
            Console.WriteLine();
        }

    }
}
