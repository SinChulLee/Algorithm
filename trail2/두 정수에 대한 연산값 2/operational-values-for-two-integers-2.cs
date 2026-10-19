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
    public static void Modify(IntWrapper a, IntWrapper b)
    {
        if(a.value > b.value)
        {
            b.value += 10;
            a.value *= 2;
        }
        else
        {
            a.value += 10;
            b.value *= 2;
        }
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        IntWrapper a = new IntWrapper(int.Parse(input[0]));
        IntWrapper b = new IntWrapper(int.Parse(input[1]));
        Modify(a,b);
        Console.Write($"{a.value} {b.value}");
    }
}