using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int cnt = 9;

        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {
                Console.Write(cnt);
                cnt--;
                if(cnt == 0)
                    cnt = 9;
            }    
            Console.WriteLine();
        }
    }
}
