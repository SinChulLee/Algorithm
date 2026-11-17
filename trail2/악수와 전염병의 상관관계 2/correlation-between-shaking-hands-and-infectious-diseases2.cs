using System;
using System.Collections.Generic;
using System.Linq;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        int P = int.Parse(input[2]);
        int T = int.Parse(input[3]);
        // dev = 개발자 전염 유무, remain = 개발자 남은 전염 횟수 (인덱스는 dev와 같음)
        bool[] dev = new bool[N+1]; 
        int[] remain = new int[N+1];
        dev[P] = true;
        remain[P] = K;

        // handshakes 정보 저장
        List<(int, int, int)> handshakes = new List<(int, int, int)>();
        for(int i = 0; i < T; i++)
        {
            input = Console.ReadLine().Split();
            int t = int.Parse(input[0]);
            int x = int.Parse(input[1]);
            int y = int.Parse(input[2]);
            handshakes.Add((t,x,y));
        }

        handshakes = handshakes.OrderBy(s => s.Item1).ToList();
        for(int j = 0; j < handshakes.Count; j++)
        {
            int x = handshakes[j].Item2;
            int y = handshakes[j].Item3;
            // 양성일 경우
            if(dev[x] || dev[y])
            {
                // 전염 시작
        
                // x가 음성일 경우
                if(!dev[x])
                {
                    // 전염 횟수가 남아 있을 경우
                    if(remain[y] > 0)
                    {
                        dev[x] = true;
                        remain[y]--;
                        // 남은 전염 횟수 받기
                        remain[x] = K;
                    }
                }
                // y가 음성일 경우
                else if(!dev[y])
                {
                    // 전염 횟수가 남아 있을 경우
                    if(remain[x] > 0)
                    {
                        dev[y] = true;
                        remain[x]--;
                        // 남은 전염 횟수 받기
                        remain[y] = K;
                    }
                }
                // 둘다 양성일 경우
                else
                {
                    // 전염 횟수만 차감
                    remain[x]--;
                    remain[y]--;
                }
            }
        }

        for(int k = 1; k < dev.Length; k++)
            Console.Write(dev[k] == true ? 1 : 0);
    }
}
