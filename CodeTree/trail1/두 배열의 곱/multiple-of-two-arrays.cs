using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d1 = new int[3,3];
        int[,] arr2d2 = new int[3,3];

        for(int i = 0; i < 3; i++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int j = 0; j < 3; j++)
            {
                arr2d1[i,j] = arr[j];
            }
        }

        Console.ReadLine();

        for(int h = 0; h < 3; h++)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int k = 0; k < 3; k++)
            {
                arr2d2[h,k] = arr[k];
            }
        }

        

        for(int m = 0; m < 3; m++)
        {
            for(int n = 0; n < 3; n++)
            {
                Console.Write($"{arr2d1[m,n] * arr2d2[m,n]} ");
            }
            Console.WriteLine();
        }
    }
}
