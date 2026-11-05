using System;

public class Codetree
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] x = new int[n];
        char[] dir = new char[n];

        int[,] tiles = new int[200001,2];
        int[] lastColor = new int[200001];
        int pos = 100000;
        for (int i = 0; i < n; i++)
        {
            string[] parts = Console.ReadLine().Split();
            x[i] = int.Parse(parts[0]);
            dir[i] = parts[1][0];
            // 흰색 = 1, 검은색 = 2, 회색 = 3
            if(dir[i] == 'L') // 흰색
            {
                for(int j = 0; j < x[i]; j++)
                {
                    tiles[pos, 0]++;
                    lastColor[pos] = 1;
                    if(j < x[i] - 1)
                        pos--;
                }
   
            }
            else // 검은색
            {
                for(int j = 0; j < x[i]; j++)
                {
                    tiles[pos, 1]++;
                    lastColor[pos] = 2;
                    if(j < x[i] - 1)
                        pos++;
                }
                
            }
        }

        int W_cnt = 0;
        int B_cnt = 0;
        int G_cnt = 0;
        for(int j = 0; j < 200001; j++)
        {
            if(tiles[j, 0] >= 2 && tiles[j, 1] >= 2)
                G_cnt++;
            else if(lastColor[j] == 1)
                W_cnt++;
            else if(lastColor[j] == 2)
                B_cnt++;
        }

        Console.Write($"{W_cnt} {B_cnt} {G_cnt}");

        // Please write your code here.
    }
}