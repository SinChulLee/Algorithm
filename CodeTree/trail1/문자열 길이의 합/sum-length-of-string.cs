using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int len = 0;
        int cnt = 0;
        for(int i = 0; i < N; i++)
        {
            string str = Console.ReadLine();
            len += str.Length;
            if(str[0] == 'a')
                cnt++;
        }
        Console.Write($"{len} {cnt}");
    }
}
