using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        char a = arr[0];
        char b = arr[1];
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == b)
                arr[i] = a;
        }
        Console.Write(new string(arr));
    }
}
