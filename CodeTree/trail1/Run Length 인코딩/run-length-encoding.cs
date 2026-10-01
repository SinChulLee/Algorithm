using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string str = Console.ReadLine();
        string ans = "";
        int cnt = 1;

        if(str.Length == 1)
        {
            Console.WriteLine(2);
            Console.Write($"{str[0]}1");
        }
        else
        {
            for(int i = 1; i < str.Length; i++)
            {
                if(str[i] != str[i-1])
                {
                    ans += str[i-1];
                    ans += cnt;
                    cnt = 1;
                }
                else
                {
                    cnt++;
                }

                if(i == str.Length-1)
                {
                    ans += str[i];
                    ans += cnt;
                }
            }
            Console.WriteLine(ans.Length);
            Console.Write(ans);
        }
    }
}
