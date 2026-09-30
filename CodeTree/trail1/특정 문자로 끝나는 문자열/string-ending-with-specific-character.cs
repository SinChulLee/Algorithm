using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] arr = new string[10];
        for(int i = 0; i < 10; i++)
        {
            arr[i] = Console.ReadLine();
        }

        char target = Console.ReadLine()[0];
        bool match = false;

        for(int i = 0; i < 10; i++)
        {
            if(arr[i][arr[i].Length-1] == target)
            {
                Console.WriteLine(arr[i]);
                match = true;
            }
        }

        if(!match)
            Console.Write("None");
    }
}
