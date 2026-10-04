using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int l = str.Length;
        for(int i = 0; i < l; i++)
        {
            if(str.Length == 1)
                break;

            int num = int.Parse(Console.ReadLine());
            if(num >= str.Length)
                str = str.Remove(str.Length-1,1);
            else
                str = str.Remove(num,1);
            Console.WriteLine(str);
        }
    }
}
