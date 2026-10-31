using System;

public class Num : IComparable<Num>
{
    public int Value, Index;

    public Num(int value, int index)
    {
        this.Value = value;
        this.Index = index;
    }

    public Num() {}


    public int CompareTo(Num num)
    {
        if(this.Value != num.Value)
            return this.Value.CompareTo(num.Value);
        return this.Index.CompareTo(num.Index);
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Num[] nums = new Num[N];
        int[] arrs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for(int i = 0; i < N; i++)
            nums[i] = new Num(arrs[i], i);

        Array.Sort(nums);

        int[] result = new int[N];

        for (int i = 0; i < N; i++)
        {
            result[nums[i].Index] = i;
        }

        for (int i = 0; i < N; i++)
            Console.Write($"{result[i]+1} ");
    }
}
