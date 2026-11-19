using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] dx = new int[] {1, -1, 0, 0};
        int[] dy = new int[] {0, 0, -1, 1};
        int N = int.Parse(Console.ReadLine());
        int x = 0, y = 0;
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            char dir = input[0][0];
            int d = int.Parse(input[1]);
            switch(dir)
            {
                case 'E':
                {
                    for(int j = 0; j < d; j++)
                    {
                        x += dx[0];
                        y += dy[0];
                    }
                    break;
                }
                case 'W':
                {
                    for(int j = 0; j < d; j++)
                    {
                        x += dx[1];
                        y += dy[1];
                    }
                    break;
                }
                case 'S':
                {
                    for(int j = 0; j < d; j++)
                    {
                        x += dx[2];
                        y += dy[2];
                    }
                    break;
                }
                case 'N':
                {
                    for(int j = 0; j < d; j++)
                    {
                        x += dx[3];
                        y += dy[3];
                    }
                    break;
                }
            }
                
        }
        Console.Write($"{x} {y}");
    }
}
