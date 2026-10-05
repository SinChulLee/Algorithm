using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        string command = Console.ReadLine();
        int len = str.Length;
        for(int i = 0; i < command.Length; i++)
        {
            if(command[i] == 'L')
            {
                str = str.Substring(1) + str.Substring(0,1);
            }
            else if(command[i] == 'R')
            {
                str = str.Substring(len-1) + str.Substring(0,len-1);
            }
        }
        Console.Write(str);
    }
}
