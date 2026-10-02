using System;

public class Codetree
{
    public static void Main()
    {
        string A = Console.ReadLine();
        string B = Console.ReadLine();

        int cnt = 0;

        for (int i = 0; i <= A.Length - B.Length; i++)
        {
            if (A[i] == B[0] && A[i + 1] == B[1])
            {
                cnt++;
            }
        }

        Console.Write(cnt);
    }
}