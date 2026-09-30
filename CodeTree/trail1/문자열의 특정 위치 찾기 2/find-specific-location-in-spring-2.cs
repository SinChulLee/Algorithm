using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] arr = new string[] {"apple", "banana", "grape", "blueberry", "orange"};
        char a = Console.ReadLine()[0];
        int cnt= 0;
        for(int i = 0; i < arr.Length; i++)
        {
            for(int j = 2; j < 4; j++)
            {
                if(a == arr[i][j])
                {
                    Console.WriteLine(arr[i]);
                    cnt++;
                    break;
                }
            }
        }
        Console.Write(cnt);
    }
}
