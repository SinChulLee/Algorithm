using System;

public class Product
{
    public string Name;
    public int Code;

    public Product(string name, int code)
    {
        this.Name = name;
        this.Code = code;
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        string[] input = Console.ReadLine().Split();
        Product p1 = new Product("codetree", 50);
        Product p2 = new Product(input[0], int.Parse(input[1]));

        Console.WriteLine($"product {p1.Code} is {p1.Name}");
        Console.WriteLine($"product {p2.Code} is {p2.Name}");
    }
}
