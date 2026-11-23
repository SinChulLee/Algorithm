using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int x = 0, y = 0;
        int[] dx = {0, -1, 0, 1};
        int[] dy = {1, 0, -1, 0};
        int dirnum = 1; // 북
        string input = Console.ReadLine();
        for(int i = 0; i < input.Length; i++)
        {
            if(input[i] == 'L')
            {
                dirnum--;
                if(dirnum < 0)
                    dirnum = 3;
            }
            else if(input[i] == 'R')
            {
                dirnum++;
                if(dirnum > 3)
                    dirnum = 0;
            }
            else
            {
                x += dx[dirnum];
                y += dy[dirnum];
            }

            if(i != 0 && x == 0 && y == 0)
            {
                Console.Write(i+1);
                return;
            }
        }
        Console.Write(-1);
    }
}
