using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split(' ');
        int N1 = int.Parse(input[0]);
        int N2 = int.Parse(input[1]);
        int[] arr_N1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] arr_N2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int cnt = 0;
        bool istrue = false;

        for(int i = 0; i <= N1-N2; i++)
        {
            bool isMatch = true;
            for(int j = 0; j < N2; j++)
            {
                if(arr_N1[i+j] != arr_N2[j])
                {
                    isMatch = false;
                    break;
                }
            }

            if(isMatch)
            {
                istrue = true;
                break;
            }
        }

        Console.Write(istrue ? "Yes" : "No");
    }
}
