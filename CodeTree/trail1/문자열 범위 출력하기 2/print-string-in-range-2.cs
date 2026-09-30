using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());

        if(str.Length >= N)
        {
            for(int i = str.Length-1; i >= str.Length-N; i--)
            {
                Console.Write(str[i]);
            }
        }
        else
        {
            for(int i = str.Length-1; i >= 0; i--)
                Console.Write(str[i]);
        }
        
    }
}
