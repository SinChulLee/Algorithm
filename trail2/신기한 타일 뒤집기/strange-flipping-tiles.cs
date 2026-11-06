using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] tiles = new int[100001];
        int pos = 50000;
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            char c = input[1][0];
            if(c == 'R')
            {
                for(int j = 0; j < x; j++)
                {
                    tiles[pos] = 1;
                    if(j < x-1)
                        pos++;
                }
            }
            else
            {
                for(int j = 0; j < x; j++)
                {
                    tiles[pos] = 2;
                    if(j < x-1)
                        pos--;
                }
            }
        }

        int W_cnt = 0;
        int B_cnt = 0;
        for(int k = 0; k < tiles.Length; k++)
        {
            if(tiles[k] == 2)
                W_cnt++;
            else if(tiles[k] == 1)
                B_cnt++;
        }
        Console.Write($"{W_cnt} {B_cnt}");
    }
}
