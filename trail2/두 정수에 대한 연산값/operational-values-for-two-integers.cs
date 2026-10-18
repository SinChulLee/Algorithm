using System;

public class IntWrapper
{
    public int value;

    public IntWrapper(int value)
    {
        this.value = value;
    }
}

public class Codetree
{  
    public static void pro(IntWrapper a, IntWrapper b)
    {
        if(a.value > b.value)
        {
            a.value += 25;
            b.value *= 2;
        }
        else
        {
            b.value += 25;
            a.value *= 2;
        }
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        IntWrapper a = new IntWrapper(int.Parse(input[0]));
        IntWrapper b = new IntWrapper(int.Parse(input[1]));
        pro(a,b);
        Console.Write($"{a.value} {b.value}");
    }
}
