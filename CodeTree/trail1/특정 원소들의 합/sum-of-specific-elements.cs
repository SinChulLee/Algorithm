using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d = new int[4,4];

        for(int i = 0; i < 4; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 4; j++)
            {
                arr2d[i,j] = arr[j];
            }
        }

        int sum = 0;
        for(int k = 0; k < 4; k++)
        {
            for(int h = 0; h < 4; h++)
            {
                if(k >= h)
                    sum += arr2d[k,h];
            }
        }

        Console.Write(sum);
    }
}
