using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int count = 0;
        string[] input = Console.ReadLine().Split(' ');
        for(int i = 0; i < N; i++)
        {
            int num = int.Parse(input[i]);
            
            if(num % 2 == 0)
            {
                array[count] = num;
                count++;
            }
        }

        for(int j = count - 1; j >= 0; j--)
        {
            Console.Write($"{array[j]} ");
        }
    }
}
