using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        int sum = 0;
        for(int i = 0; i < str.Length; i++)
        {
            int num = (int)str[i] - 48;
            if(num >= 0 && num <= 9)
                sum += num;
        }
        Console.Write(sum);
    }
}
