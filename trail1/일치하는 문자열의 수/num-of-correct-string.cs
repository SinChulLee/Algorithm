using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        string A = input[1];
        int cnt = 0;
        for(int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            if(A == str)
                cnt++;
        }
        Console.Write(cnt);
    }
}
