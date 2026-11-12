using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        const int OFFSET = 1000;
        int N = int.Parse(Console.ReadLine());
        int[,] arr2d = new int[2001,2001];
        for(int i = 1; i <= N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]) + OFFSET;
            int y1 = int.Parse(input[1]) + OFFSET;
            int x2 = int.Parse(input[2]) + OFFSET;
            int y2 = int.Parse(input[3]) + OFFSET;
            if(i % 2 == 1) // 빨강
            {
                for(int j = x1; j < x2; j++)
                    for(int k = y1; k < y2; k++)
                        arr2d[j,k] = 1;
            }
            else // 파랑
            {
                for(int j = x1; j < x2; j++)
                    for(int k = y1; k < y2; k++)
                        arr2d[j,k] = 2;
            }
        }
        int cnt = 0;
        for(int i = 0; i < 2001; i++)
                for(int j = 0; j < 2001; j++)
                    if(arr2d[i,j] == 2)
                        cnt++;
        
        Console.Write(cnt);
    }
}
