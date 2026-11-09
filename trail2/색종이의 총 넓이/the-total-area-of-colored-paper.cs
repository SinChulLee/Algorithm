using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[,] arr2d = new int[201,201];
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]) + 100;
            int y = int.Parse(input[1]) + 100;
            for(int j = x; j < x + 8; j++)
                for(int k = y; k < y + 8; k++)
                    arr2d[j,k]++;
        }

        int ans = 0;
        for(int j = 0; j < 201; j++)
            for(int k = 0; k < 201; k++)
                if(arr2d[j,k] > 0)
                    ans++;
        
        Console.Write(ans);
    }
}
