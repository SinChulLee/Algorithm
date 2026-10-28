using System;

public class Bomb
{
    public string code;
    public char color;
    public int second;

    public Bomb(string code, char color, int second)
    {
        this.code = code;
        this.color = color;
        this.second = second;
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        Bomb bomb = new Bomb(input[0], input[1][0], int.Parse(input[2]));
        Console.WriteLine($"code : {bomb.code}");
        Console.WriteLine($"color : {bomb.color}");
        Console.WriteLine($"second : {bomb.second}");
    }
}
