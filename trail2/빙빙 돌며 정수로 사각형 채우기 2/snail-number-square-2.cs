using System;

public class Codetree
{  
    static int[] dx;
    static int[] dy;
    static int[,] arr;
    static int x, y, dirnum, N, M;

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
        arr = new int[N,M];
        // 아래, 오른쪽, 위쪽, 왼쪽
        dx = new int[]{1, 0, -1, 0};
        dy = new int[]{0, 1, 0, -1};
        x = 0; y = 0; dirnum = 0;
        
        int cnt = 0;
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {  
                cnt++;
                arr[x,y] = cnt;
                int nx = x + dx[dirnum];
                int ny = y + dy[dirnum];
                if(!InRange(nx, ny) || arr[nx, ny] != 0)
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
        }

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < M; j++)
            {  
                Console.Write($"{arr[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
