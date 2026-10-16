using System;

public class Codetree
{  
    public static bool judge(int n1, int n2, int[] A, int[] B)
    {
        for(int i = 0; i <= n1-n2; i++)
        {
            int j = 0;
            while(j < n2 && A[i+j] == B[j])
            {
                j++;
            }

            if(j == n2)
                return true;
        }
        return false;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int n1 = int.Parse(input[0]);
        int n2 = int.Parse(input[1]);
        int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        bool Istrue = judge(n1, n2, A, B);
        if(Istrue)
            Console.Write("Yes");
        else
            Console.Write("No");
    }
}
