using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] line = new int[2001];
        int pos = 1000;
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x = int.Parse(input[0]);
            if(input[1][0] == 'R')
            {
                for(int j = 0; j < x; j++)
                {
                    line[pos]++;
                    pos++;
                }
                
            }
            else
            {
                for(int j = 0; j < x; j++)
                {
                    pos--;
                    line[pos]++;
                }
            }
        }

        int cnt = 0;
        for(int k = 0; k < line.Length; k++)
            if(line[k] > 1)
                cnt++;
        
        Console.Write(cnt);
    }
}
