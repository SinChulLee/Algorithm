using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int[] ansarr = new int[10];
        int ans = 0;

        while(true)
        {
            int div = A % B;
            A = A / B;
            ansarr[div]++;
            if(A <= 1)
                break;
        }

        for(int i = 0; i < 10; i++)
        {
            ans += ansarr[i] * ansarr[i];
        }
        Console.Write(ans);
    }
}
