using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string A = Console.ReadLine();
        string B = Console.ReadLine();

        while(A.Contains(B))
        {
            int index = A.IndexOf(B);
            A = A.Remove(index, B.Length);
        }
        Console.Write(A);
    }
}
