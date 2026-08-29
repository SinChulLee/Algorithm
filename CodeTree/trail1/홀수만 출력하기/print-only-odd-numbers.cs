using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] num = new int[N];
        for (int i = 0; i < N; i++)
        {
            num[i] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < N; j++)
        {
            if (num[j] % 2 != 0 && num[j] %  3 == 0)
                Console.WriteLine(num[j]);
        }
    }
}
