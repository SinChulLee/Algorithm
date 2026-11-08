using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d = new int[2001,2001];
        for(int i = 1; i <= 3; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]) + 1000;
            int y1 = int.Parse(input[1]) + 1000;
            int x2 = int.Parse(input[2]) + 1000;
            int y2 = int.Parse(input[3]) + 1000;
            for(int j = x1; j < x2; j++)
                for(int k = y1; k < y2; k++)
                    arr2d[j,k] = i;
        }

        int ans = 0;
        for(int j = 0; j < 2001; j++)
            for(int k = 0; k < 2001; k++)
                if(arr2d[j,k] == 1 || arr2d[j,k] == 2)
                    ans++;
        
        Console.Write(ans);

    }
}
