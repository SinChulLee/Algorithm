using System;

public class People
{
    public string Name;
    public int Height;
    public double Weight;

    public People(string name, int height, double weight)
    {
        this.Name = name;
        this.Height = height;
        this.Weight = weight;
    }

    public People() {}
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        People[] peoples = new People[5];
        for(int i = 0; i < 5; i++)
        {
            string[] input = Console.ReadLine().Split();
            peoples[i] = new People(input[0], int.Parse(input[1]), double.Parse(input[2]));
        }

        Console.WriteLine("name");
        Array.Sort(peoples, (a,b) => a.Name.CompareTo(b.Name));
        for(int j = 0; j < 5; j++)
            Console.WriteLine($"{peoples[j].Name} {peoples[j].Height} {peoples[j].Weight:F1}");
        
        Console.WriteLine();

        Console.WriteLine("height");
        Array.Sort(peoples, (a,b) => b.Height.CompareTo(a.Height));
        for(int j = 0; j < 5; j++)
            Console.WriteLine($"{peoples[j].Name} {peoples[j].Height} {peoples[j].Weight:F1}");
    }
}
