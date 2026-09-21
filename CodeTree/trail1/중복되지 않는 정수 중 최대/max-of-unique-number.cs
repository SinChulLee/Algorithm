using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int max = int.MinValue;
        bool isdupl = false;

        for(int i = 0; i < N; i++)
        {
            if(arr[i] > max)
            {
                for(int j = 0; j < N; j++)
                {
                    if(j != i)
                    {
                        if(arr[j] == arr[i])
                        {
                            isdupl = true;
                        }
                    }
                }
                if (!isdupl)
                {
                    max = arr[i];
                }
                isdupl = false;
            }
        }
        
        if(max == int.MinValue)
            Console.Write(-1);
        else
            Console.Write(max);
    }
}
