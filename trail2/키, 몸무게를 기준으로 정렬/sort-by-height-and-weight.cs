using System;

public class People : IComparable<People>
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

    public int CompareTo(People people)
    {
        if(this.Height != people.Height)
            return this.Height.CompareTo(people.Height);
        if(this.Weight != people.Weight)
            return people.Weight.CompareTo(this.Weight);
        return 0;
    }
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

        Array.Sort(peoples);

        for(int j = 0; j < n; j++)
        {
            Console.WriteLine($"{peoples[j].Name} {peoples[j].Height} {peoples[j].Weight}");
        }
    }
}
