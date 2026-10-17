using System;

public class Codetree
{  
    public static bool Judge(string A)
    {
        string str = A;
        for(int i = 0; i < A.Length; i++)
        {
            if(str[i] != A[A.Length-i-1])
                return false;
        }
        return true;
    }

    public static void Main()
    {
        // Please write your code here.
        string A = Console.ReadLine();
        if(Judge(A))
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
