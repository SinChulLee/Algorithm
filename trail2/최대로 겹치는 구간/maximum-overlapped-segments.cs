using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] Checked = new int[200];
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int x1 = int.Parse(input[0]);
            int x2 = int.Parse(input[1]);
            int start = x1 + 100;
            int end = x2 + 100;
            for(int j = start; j < end; j++)
                Checked[j]++;
        }

        int max = Checked[0];
        for(int k = 0; k < Checked.Length; k++)
        {
            if(Checked[k] > max)
                max = Checked[k];
        }

        Console.Write(max);
    }
}
