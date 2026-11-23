using System;

public class Codetree
{  
    static int N;

    public static bool InRange(int x, int y)
    {
        return (0 <= x && x < N && 0 <= y && y < N);
    }

    public static bool IsComfor(int x, int y, int[,] square)
    {
        int cnt = 0;
        // 왼, 오, 위, 아래
        if(InRange(x,y-1) && square[x,y-1] > 0)
            cnt++;
        if(InRange(x,y+1) && square[x,y+1] > 0)
            cnt++;
        if(InRange(x-1,y) && square[x-1,y] > 0)
            cnt++;
        if(InRange(x+1,y) && square[x+1,y] > 0)
            cnt++;

        if(cnt == 3)
            return true;
        else
            return false;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int[,] square = new int[N,N];
        for(int i = 0; i < M; i++)
        {
            input = Console.ReadLine().Split();
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            r--; c--;
            square[r,c]++;
            if(IsComfor(r, c, square))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}
