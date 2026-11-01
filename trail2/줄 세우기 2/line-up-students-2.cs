using System;

public class Student : IComparable<Student>
{
    public int Height, Weight, Num;

    public Student(int height, int weight, int num)
    {
        this.Height = height;
        this.Weight = weight;
        this.Num = num;
    }

    public Student() {}

    public int CompareTo(Student other)
    {
        if(this.Height != other.Height)
            return this.Height.CompareTo(other.Height);
        
        return other.Weight.CompareTo(this.Weight);
    }
}

public class Codetree
{
    public const int MAX_N = 1000;

    public static int[] h = new int[MAX_N];
    public static int[] w = new int[MAX_N];

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            h[i] = int.Parse(input[0]);
            w[i] = int.Parse(input[1]);
            students[i] = new Student(h[i], w[i], i);
        }

        Array.Sort(students);

        for(int j = 0; j < n; j++)
            Console.WriteLine($"{students[j].Height} {students[j].Weight} {students[j].Num+1}");

        // Please write your code here.
    }
}
