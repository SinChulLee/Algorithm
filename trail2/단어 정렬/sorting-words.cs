using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        for(int i = 0; i < n; i++)
            arr[i] = Console.ReadLine();

        Array.Sort(arr);

        for(int j = 0; j < n; j++)
            Console.WriteLine(arr[j]);
    }
}
