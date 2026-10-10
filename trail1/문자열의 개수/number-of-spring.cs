using System;
using System.Collections.Generic;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int cnt = 0;
        List<string> arr = new List<string>();
        while(true)
        {
            string str = Console.ReadLine();
            if(str == "0")
            {
                Console.WriteLine(cnt);
                foreach(string s in arr)
                    Console.WriteLine(s);
                break;
            }
            cnt++;
            if(cnt % 2 == 1)
                arr.Add(str);
        }
    }
}
