using System;

public class Codetree
{  
    public static int ConvertDir(char c)
    {
        if(c == 'W')
            return 0;
        else if(c == 'S')
            return 1;
        else if(c == 'N')
            return 2;
        else
            return 3;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int x = 0, y = 0;
        int[] dx = {0, 1, -1, 0};
        int[] dy = {-1, 0, 0, 1};
        int T = 0;
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            char c = input[0][0];
            int L = int.Parse(input[1]);

            for(int j = 0; j < L; j++)
            {
                x += dx[ConvertDir(c)];
                y += dy[ConvertDir(c)];
                T++;
                if(i != 0)
                {
                    if(x == 0 && y == 0)
                    {
                        Console.Write(T);
                        return;
                    }
                }
            }
        }
        Console.Write(-1);

    }
}
