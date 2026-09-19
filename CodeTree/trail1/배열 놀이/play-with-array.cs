using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int Q = int.Parse(input[1]);
        string[] input2 = Console.ReadLine().Split(' ');
        int[] N_arr = Array.ConvertAll(input2, int.Parse);

        for(int i = 0; i < Q; i++)
        {
            string[] input3 = Console.ReadLine().Split(' ');
            int num = int.Parse(input3[0]);
            if(num == 1)
            {
                int a = int.Parse(input3[1]);
                Console.WriteLine(N_arr[a-1]);
          
            }
            else if(num == 2)
            {
                int b = int.Parse(input3[1]);
                bool isexist = false;
                for(int j = 0; j < N; j++)
                {
                    if(b == N_arr[j])
                    {
                        Console.WriteLine(j+1);
                        isexist = true;
                        break;
                    }
                }
                if(!isexist)
                    Console.WriteLine(0);
            }
            else if(num == 3)
            {
                int s = int.Parse(input3[1]);
                int e = int.Parse(input3[2]);
                for(int k = s-1; k <= e-1; k++)
                {
                    Console.Write($"{N_arr[k]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
