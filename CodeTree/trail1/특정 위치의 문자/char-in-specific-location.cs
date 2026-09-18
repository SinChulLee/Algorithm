using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        char[] arr = {'L', 'E', 'B', 'R', 'O', 'S'};
        char c = Console.ReadLine()[0];
        int ans = -1;
        for(int i = 0; i < 6; i++)
        {
            if(arr[i] == c)
                ans = i;
        }

        if(ans == -1)
            Console.Write("None");
        else
            Console.Write(ans);
    }
}
