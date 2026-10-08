using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string A = input[0];
        string B = input[1];
        string AB = A + B;
        string BA = B + A;
        int ans = int.Parse(AB) + int.Parse(BA);
        Console.Write(ans);
    }
}
