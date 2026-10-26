using System;

public class Codetree
{  
    public static int F(int n, int[] arr)
    {
        int left = 0;
        int right = 2*n-1;
        int maxsum = 0;
        Array.Sort(arr);
        // 각 그룹의 원소 합의 최댓값이 최소가 되도록 N개의 그룹으로 나누고 최댓값 반환
        // 배열 그룹으로 분할
        while(left<right)
        {
            int sum = arr[left] + arr[right];
            if(sum > maxsum)
                maxsum = sum;
            left++;
            right--;
        }
        return maxsum;
    }

    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Console.Write(F(N,arr));
    }
}
