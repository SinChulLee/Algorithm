using System;

public class IntWrapper
{
    public int value;

    public IntWrapper(int value)
    {
        this.value = value;
    }
}

public class Codetree
{  
    public static void ConvertPrint(int N, int[] arr)
    {
        for(int i = 0; i < N; i++)
        {
            if(arr[i] < 0)
                arr[i] = -arr[i];
            Console.Write($"{arr[i]} ");
        }
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        ConvertPrint(N, arr);
    }
}
