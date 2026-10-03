using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string S = input[0];
        int Q = int.Parse(input[1]);
        char[] arr = S.ToCharArray();

        for(int i = 0; i < Q; i++)
        {
            input = Console.ReadLine().Split();
            int num = int.Parse(input[0]);
            if(num == 1)
            {
                int index1 = int.Parse(input[1]) - 1;
                int index2 = int.Parse(input[2]) - 1;
                char c1 = arr[index1];
                char c2 = arr[index2];
                arr[index1] = c2;
                arr[index2] = c1;
            }
            else if(num == 2)
            {  
                char x = input[1][0];
                char y = input[2][0];
                for(int j = 0; j < arr.Length; j++)
                {
                    if(arr[j] == x)
                        arr[j] = y;
                }
            }
            Console.WriteLine(new string(arr));
        }
    }
}
