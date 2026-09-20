using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int cnt = 0;

        for(int i = 0; i < N; i++)
        {
            if(arr[i] == 2)
                cnt++;

            if(cnt == 3)
            {
                Console.Write(i+1);
                break;
            }
        }
    }
}
