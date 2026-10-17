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
    public static void exchange(IntWrapper n, IntWrapper m)
    {
        int temp = n.value;
        n.value = m.value;
        m.value = temp;
    }

    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        IntWrapper n = new IntWrapper(int.Parse(input[0]));
        IntWrapper m = new IntWrapper(int.Parse(input[1]));
        exchange(n,m);
        Console.Write($"{n.value} {m.value}");
    }
}
