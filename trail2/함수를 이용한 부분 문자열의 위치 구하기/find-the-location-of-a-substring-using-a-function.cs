using System;

public class Codetree
{  
    public static string a;
    public static string b;
    public static int N;
    public static int M;

    public static int IsBu()
    {
        for(int i = 0; i <= N-M; i++)
        {
            bool ismatch = true;
            for(int j = 0; j < M; j++)
            {
                if(a[i+j] != b[j])
                {
                    ismatch = false;
                    break;
                }
            }
            if (ismatch)
                return i;
        }
        return -1;
    }

    public static void Main()
    {
        // Please write your code here.
        a = Console.ReadLine();
        b = Console.ReadLine();
        N = a.Length;
        M = b.Length;
        Console.Write(IsBu());
    }
}
