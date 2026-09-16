using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);
        int cnt = 0;
        int sum = 0;
        for(int i = 0; i <= arr.Length; i++)
        {
            cnt++;
            if(arr[i] == 0)
                break;
        }

        for(int j = cnt-2; j > cnt-5; j--)
        {
            sum += arr[j];
        }
        Console.Write(sum);
    }
}
