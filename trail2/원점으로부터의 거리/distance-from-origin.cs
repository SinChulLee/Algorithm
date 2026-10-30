using System;

public class Point : IComparable<Point>
{
    public int X,Y,Num;

    public Point(int x, int y, int num)
    {
        this.X = x;
        this.Y= y;
        this.Num = num;
    }

    public int Distance()
    {
        if(this.X < 0)
            this.X = -this.X;
        if(this.Y < 0)
            this.Y = -this.Y;
        int distance = this.X+this.Y;
        return distance;

        //  return Math.Abs(this.X) + Math.Abs(this.Y);
    }

    public int CompareTo(Point other)
    {
        if(this.Distance() != other.Distance())
            return this.Distance().CompareTo(other.Distance());
        return this.Num.CompareTo(other.Num);
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            points[i] = new Point(int.Parse(input[0]), int.Parse(input[1]), i+1);
        }

        Array.Sort(points);

        for(int j = 0; j < n; j++)
            Console.WriteLine(points[j].Num);
    }
}
