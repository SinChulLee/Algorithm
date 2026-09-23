using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d = new int[4, 4];

        for(int i = 0; i < 4; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 4; j++)
            {
                arr2d[i,j] = arr[j];
            }
        }

        for(int i = 0; i < 4; i++)
        {
            int sum = 0;
            for(int j = 0; j < 4; j++)
            {
                sum += arr2d[i,j];
            }
            Console.WriteLine(sum);
        }
    }
}
