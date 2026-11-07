using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[,] arr2d = new int[201, 201];
        int ans = 0;
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]) + 100;
            int y1 = int.Parse(input[1]) + 100;
            int x2 = int.Parse(input[2]) + 100;
            int y2 = int.Parse(input[3]) + 100;
            for(int j = x1; j < x2; j++)
            {
                for(int k = y1; k < y2; k++)
                    arr2d[j,k]++;
            }
        }
        
        for(int j = 0; j <= 200; j++)
        {
            for(int k = 0; k <= 200; k++)
                if(arr2d[j,k] > 0)
                    ans++;
        }
        Console.Write(ans);
    }
}
