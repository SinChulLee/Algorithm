using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int cnt = 0;
        while(true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine(num/2);
                cnt++;
                if (cnt == 3)
                    break;
            }
        }
    }
}
