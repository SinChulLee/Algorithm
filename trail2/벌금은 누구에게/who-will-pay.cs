using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);
        int K = int.Parse(input[2]);
        int[] student = new int[N];
        for(int i = 0; i < M; i++)
        {
            int num = int.Parse(Console.ReadLine());
            num = num - 1;
            student[num]++;
            if(student[num] >= K)
            {
                Console.Write(num+1);
                return;
            }
        }
        Console.Write(-1);
    }
}
