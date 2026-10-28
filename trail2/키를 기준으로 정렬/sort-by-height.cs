using System;

public class People
{
    public string Name;
    public int Height, Weight;

    public People(string name, int height, int weight)
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
        int n = int.Parse(Console.ReadLine());
        People[] peoples = new People[n];
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            peoples[i] = new People(input[0], int.Parse(input[1]), int.Parse(input[2]));
        }

        Array.Sort(peoples, (a,b) => a.Height - b.Height);

        for(int j = 0; j < n; j++)
            Console.WriteLine($"{peoples[j].Name} {peoples[j].Height} {peoples[j].Weight}");
    }
}
