using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        char[,] arr2d = new char[5,3];
        for(int i = 0; i < 5; i++)
        {
            char[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), char.Parse);
            for(int j = 0; j < 3; j++)
            {
                arr2d[i,j] = arr[j];
            }
        }

        for(int k = 0; k < 5; k++)
        {
            for(int h = 0; h < 3; h++)
            {
                arr2d[k,h] = (char)(arr2d[k,h] - 32);
                Console.Write($"{arr2d[k,h]} ");
            }
            Console.WriteLine();
        }
    }
}
