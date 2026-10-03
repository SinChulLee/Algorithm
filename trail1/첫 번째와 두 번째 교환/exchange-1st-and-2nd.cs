using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        char[] arr = str.ToCharArray();
        char c1 = str[0];
        char c2 = str[1];
        string ans = "";

        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == c1)
                arr[i] = c2;
            else if(arr[i] == c2)
                arr[i] = c1;
            ans += arr[i];
        }

        Console.Write(ans);
    }
}
