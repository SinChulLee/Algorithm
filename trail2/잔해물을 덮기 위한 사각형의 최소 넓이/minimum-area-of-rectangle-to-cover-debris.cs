using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        int a_x1 = int.Parse(input[0]) + 1000;
        int a_y1 = int.Parse(input[1]) + 1000;
        int a_x2 = int.Parse(input[2]) + 1000;
        int a_y2 = int.Parse(input[3]) + 1000;

        int b_x1 = int.Parse(input2[0]) + 1000;
        int b_y1 = int.Parse(input2[1]) + 1000;
        int b_x2 = int.Parse(input2[2]) + 1000;
        int b_y2 = int.Parse(input2[3]) + 1000;

        int[,] arr2d = new int[2001,2001];
        for(int i = a_x1; i < a_x2; i++)
            for(int j = a_y1; j < a_y2; j++)
                arr2d[i,j] = 1;

        for(int i = b_x1; i < b_x2; i++)
            for(int j = b_y1; j < b_y2; j++)
                arr2d[i,j] = 2;

        int m_x1 = int.MaxValue;
        int m_y1 = int.MaxValue;
        int m_x2= int.MinValue;
        int m_y2 = int.MinValue;
        for(int i = 0; i < 2001; i++)
            for(int j = 0; j < 2001; j++)
                if(arr2d[i,j] == 1)
                {
                    if(i < m_x1)
                        m_x1 = i;

                    if(j < m_y1)
                        m_y1 = j;

                    if(i > m_x2)
                        m_x2 = i;

                    if(j > m_y2)
                        m_y2 = j;
                }
        if(m_x1 == int.MaxValue)
        {
            Console.Write(0);
            return;
        }
        int ans = (m_x2 - m_x1 + 1) * (m_y2 - m_y1 + 1);
        Console.Write(ans);
    }
}
