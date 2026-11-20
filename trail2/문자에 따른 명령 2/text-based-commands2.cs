using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string L = Console.ReadLine();
        char[] arr = L.ToCharArray();
        int[] dx = new int[]{1, 0, -1, 0};
        int[] dy = new int[]{0, -1, 0, 1};

        int x = 0; int y = 0;
        int cnt = 3;
        for(int i = 0; i < arr.Length; i++)
        {
            switch(arr[i])
            {
                case 'L':
                {
                    cnt--;
                     if (cnt < 0)
                        cnt = 3;
                    break;
                }
                case 'R':
                {
                    cnt++;
                     if (cnt > 3)
                        cnt = 0;
                    break;
                }
                case 'F':
                {
                    x += dx[cnt];
                    y += dy[cnt];
                    break;
                }
            }
        }

        Console.Write($"{x} {y}");
    }
}
