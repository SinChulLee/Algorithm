using System;

public class Codetree
{  
    public static void ConvertPrint(int n, int b)
    {
        int[] digit = new int[100];
        int cnt = 0;
        while(true)
        {
            if(n < b)
            {
                digit[cnt++] = n;
                break;
            }

            digit[cnt++] = n % b;
            n = n / b;
        }

        for(int i = cnt-1; i >= 0; i--)
            Console.Write(digit[i]);
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        ConvertPrint(N,B);
    }
}
