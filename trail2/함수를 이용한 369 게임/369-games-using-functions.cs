using System;

public class Codetree
{  
    public static bool IsMultiple3(int n)
    {
        if(n % 3 == 0)
            return true;
        else
            return false;
    }

    public static int IsMagicnum(int a, int b)
    {
        int cnt = 0;
        for(int i = a; i <= b; i++)
        {
            if(i.ToString().Contains("3") || i.ToString().Contains("6") || i.ToString().Contains("9") || IsMultiple3(i))
                cnt++;
        }
        return cnt;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int cnt = IsMagicnum(A, B);
        Console.Write(cnt);
    }
}
