using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split();
        string str = "";
        for(int i = 0; i < arr.Length; i++)
        {
            str += arr[i];
        }

        for(int i = 0; i < str.Length; i++)
        {
            Console.Write(str[i]);
            if((i+1) % 5 == 0)
                Console.WriteLine();
        }   

    }
}
