using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] arr = new string[4];
        for(int i = 0; i < 4; i++)
        {
            arr[i] = Console.ReadLine();
        }

        for(int i = 3; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
