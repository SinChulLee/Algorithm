using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[,] arr2d = new int[5,5];
        for(int i = 0; i < 5; i++)
        {
            arr2d[0,i] = 1;
            arr2d[i,0] = 1;
        }

        for(int i = 1; i < 5; i++)
        {
            for(int j = 1; j < 5; j++)
            {
                arr2d[i,j] = arr2d[i-1,j] + arr2d[i,j-1];
            }
        }

        for(int i = 0; i < 5; i++)
        {
            for(int j = 0; j < 5; j++)
            {
                Console.Write($"{arr2d[i,j]} ");
            }
            Console.WriteLine();
        }
    }
}
