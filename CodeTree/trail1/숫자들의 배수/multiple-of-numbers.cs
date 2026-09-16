using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = new int[100];
        int cnt1 = 0;
        int cnt2 = 0;
        int num = 0;

        for(int i = 0; i < 100; i++)
        {
            num += N;
            if(num % 5 == 0)
                cnt2++;
            arr[i] = num;
            cnt1++;
            if(cnt2 == 2)
                break;
        }

        for(int j = 0; j < cnt1; j++)
        {
            Console.Write($"{arr[j]} ");
        }
    }
}
