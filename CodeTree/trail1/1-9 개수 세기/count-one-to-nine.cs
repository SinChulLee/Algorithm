using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[9];

        for(int i = 0; i < N; i++)
        {
            int num = int.Parse(input[i]);
            for(int j = 1; j < 10; j++)
            {
                if(num == j)
                {
                    arr[j-1] += 1;
                    break;
                }
            }
        }

        for(int k = 0; k < 9; k++)
            Console.WriteLine(arr[k]);


    }
}
