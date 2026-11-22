using System;

public class Codetree
{  
    static int N;

    public static bool inRange(int x, int y)
    {
        return(1 <= x && x <= N && 1 <= y && y <= N);
    }

    public static int getDir(char a)
    {
        if(a == 'U')
            return 0;
        else if(a == 'D')
            return 1;
        else if(a == 'R')
            return 2;
        else
            return 3;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        int T = int.Parse(input[1]);
        string[] input2 = Console.ReadLine().Split();
        int R = int.Parse(input2[0]);
        int C = int.Parse(input2[1]);
        char D = input2[2][0];
        int[] dx = new int[]{-1,1,0,0};
        int[] dy = new int[]{0,0,1,-1};
        int[] opposite = new int[] { 1, 0, 3, 2 };
        int dirnum = getDir(D);
        for(int i = 0; i < T; i++)
        {
            int nx = R + dx[dirnum], ny = C + dy[dirnum];
            if(!inRange(nx, ny))
            {
                dirnum = opposite[dirnum];
            }
            else
            {
                R = nx;
                C = ny;
            }
        }
        Console.Write($"{R} {C}");
    }
}
