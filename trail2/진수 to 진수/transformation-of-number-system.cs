using System;

public class Codetree
{
    public static void Main()
    {
        string[] tokens = Console.ReadLine().Split();
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);
        string n = Console.ReadLine().Trim();

        // Please write your code here.
        int num = 0;
        for(int i = 0; i < n.Length; i++)
            num = num * a + (n[i] - '0');
        
        int[] digit = new int[100];
        int cnt = 0;
        while(true)
        {
            if(num < b)
            {
                digit[cnt++] = num;
                break;
            }
            digit[cnt++] = num % b;
            num /= b;
        }

        for(int i = cnt - 1; i >= 0; i--)
            Console.Write(digit[i]);
    }
}