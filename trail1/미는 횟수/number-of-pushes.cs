using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string A = Console.ReadLine();
        string B = Console.ReadLine();
        int cnt = 0;
        while(true)
        {
            if(A == B)
            {
                Console.Write(cnt);
                break;
            }
            A = A.Substring(A.Length-1, 1) + A.Substring(0, A.Length-1);
            cnt++;
            if(cnt > A.Length)
            {
                Console.Write(-1);
                break;
            }
        }
    }
}




