using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int temp;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = i+1; j < arr.Length; j++)
            {
                if(arr[i] < arr[j])
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }

        for(int k = 0; k < 2; k++)
        {
            Console.Write($"{arr[k]} ");
        }
    }
}
