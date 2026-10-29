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
        if(this.Height == other.Height && this.Weight == other.Weight)
            return this.Num - other.Num;
        if(this.Height == other.Height)
            return other.Weight - this.Weight;
        return other.Height - this.Height;
    }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int N = int.Parse(Console.ReadLine());
        Student[] students = new Student[N];
        for(int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            students[i] = new Student(int.Parse(input[0]), int.Parse(input[1]), i+1);
        }

        Array.Sort(students);

        for(int j = 0; j < N; j++)
            Console.WriteLine($"{students[j].Height} {students[j].Weight} {students[j].Num}");
    }
}
