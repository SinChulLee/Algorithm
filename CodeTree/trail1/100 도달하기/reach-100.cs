using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[100];
        arr[0] = 1; arr[1] = N;
        int cnt = 2;
        for(int i = 2; i < 100; i++)
        {
            arr[i] = arr[i-2] + arr[i-1];
            cnt++;
            if(arr[i] > 100)
                break;
        }

        for(int j = 0; j < cnt; j++)
            Console.Write($"{arr[j]} ");
    }
}
