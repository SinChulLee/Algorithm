using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d = new int[2,4];

        for(int i = 0; i < 2; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 4; j++)
            {
                arr2d[i,j] = arr[j];
            }
        }

        int sum = 0;
        int[] sum1 = new int[2];
        int[] sum2 = new int[4];
        for(int k = 0; k < 2; k++)
        {
            for(int h = 0; h < 4; h++)
            {
                sum += arr2d[k,h];
                sum1[k] += arr2d[k,h];
                sum2[h] += arr2d[k,h];
            }
        }

        for(int n = 0; n < 2; n++)
        {
            Console.Write($"{(double)(sum1[n])/4:F1} ");
        }
        Console.WriteLine();
        for(int m = 0; m < 4; m++)
        {
            Console.Write($"{(double)(sum2[m])/2:F1} ");
        }
        Console.WriteLine();
        Console.WriteLine($"{(double)(sum)/8:F1}");
    }
}
