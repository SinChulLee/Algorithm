using System;

public class Codetree
{  
    public static bool IsEqual(int n, int[] a, int[] b)
    {
        Array.Sort(a);
        Array.Sort(b);
        for(int i = 0; i < n; i++)
        {
            if(a[i] != b[i])
                return false;
        }
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        if(IsEqual(n,A,B))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
