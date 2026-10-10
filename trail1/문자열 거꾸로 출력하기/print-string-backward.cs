using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        while(true)
        {
            string str = Console.ReadLine();
            if(str == "END")
                break;
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            str = new string(arr);
            Console.WriteLine(str);
        }
    }
}
