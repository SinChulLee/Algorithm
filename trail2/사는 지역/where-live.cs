using System;

public class People
{
    public string Name;
    public string Code;
    public string Local;

    public People(string name, string code, string local)
    {
        this.Name = name;
        this.Code = code;
        this.Local = local;
    }

    public People()
    {
        this.Name = "";
        this.Code = "";
        this.Local = "";
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        People[] peoples = new People[n];
        for(int i = 0 ; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            peoples[i] = new People(input[0], input[1], input[2]);
        }

        Array.Sort(peoples, (a, b) => string.Compare(a.Name, b.Name));

        Console.WriteLine($"name {peoples[n-1].Name}");
        Console.WriteLine($"addr {peoples[n-1].Code}");
        Console.WriteLine($"city {peoples[n-1].Local}");
    }
}
