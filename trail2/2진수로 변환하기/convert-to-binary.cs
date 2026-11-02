using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] digit = new int[100];
        int cnt = 0;
        while(true)
        {
            if(N < 2)
            {
                digit[cnt++] = N;
                break;
            }
            
            digit[cnt++] = N%2;
            N = N/2;
        }
        for(int i = cnt-1; i >= 0; i--)
            Console.Write(digit[i]);
    }
}
