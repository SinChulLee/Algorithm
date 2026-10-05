using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string str = input[0];
        int Q = int.Parse(input[1]);
        int len = str.Length;
        for(int i = 0; i < Q; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if(num == 1)
            {
                str = str.Substring(1) + str.Substring(0,1);
            }
            else if(num == 2)
            {
                str = str.Substring(len-1) + str.Substring(0, len-1);
            }
            else if(num == 3)
            {
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                str = new string(arr);
            }
            Console.WriteLine(str);
        }
    }
}
