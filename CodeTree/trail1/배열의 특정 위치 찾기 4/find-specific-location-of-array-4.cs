using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int cnt = 0;
        int sum = 0;

        for(int i = 0; i < array.Length; i++)
        {
            if(array[i] == 0)
                break;
            if (array[i] % 2 == 0)
            {
                sum += array[i];
                cnt++;
            }
        }
        Console.WriteLine($"{cnt} {sum}");
    }
}
