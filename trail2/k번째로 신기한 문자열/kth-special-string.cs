using System;

public class Codetree
{  
    public static void F(int count, int K, string[] arr)
    {
        Array.Sort(arr,0,count);
        Console.Write(arr[K-1]);
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        string T = input[2];
        string[] arr = new string[N];
        int count = 0;
        for(int i = 0; i < N; i++)
        {
            string str = Console.ReadLine();
            if(str.Length >= T.Length && str.Substring(0, T.Length) == T)
            {
                arr[count] = str;
                count++;
            }
        }
        F(count,K,arr);
    }
}
