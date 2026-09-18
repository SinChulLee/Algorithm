using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        char[] statearr = new char[3];
        int[] degreearr = new int[3];
        int[] ansarr = new int[4];
        int cnt = 0;

        for(int i = 0; i < 3; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            statearr[i] = char.Parse(input[0]);
            degreearr[i] = int.Parse(input[1]);

            if(statearr[i] == 'Y' && degreearr[i] >= 37)
                ansarr[0]++;
            else if(statearr[i] == 'N' && degreearr[i] >= 37)
                ansarr[1]++;
            else if(statearr[i] == 'Y' && degreearr[i] < 37)
                ansarr[2]++;
            else
                ansarr[3]++;
        }

        for(int j = 0; j < 4; j++)
        {
            Console.Write($"{ansarr[j]} ");
        }
        if(ansarr[0] >= 2)
            Console.Write("E");
    }
}
