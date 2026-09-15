using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int sum = 0;
        int cnt = 0;
        for(int i = 0; i < N; i++)
        {
            sum = 0;
            string[] input = Console.ReadLine().Split(' ');
            for(int j = 0; j < 4; j++)
            {
                int score = int.Parse(input[j]);
                sum += score;
            }
            int avg = sum/4;
            if(avg >= 60)
            {
                Console.WriteLine("pass");
                cnt++;
            }
            else
                Console.WriteLine("fail");
        }
        Console.WriteLine(cnt);
    }
}
