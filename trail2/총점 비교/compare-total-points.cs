using System;

public class Student : IComparable<Student>
{
    public string Name;
    public int Sub1, Sub2, Sub3;
    
    public Student(string name, int sub1, int sub2, int sub3)
    {
        this.Name = name;
        this.Sub1 = sub1;
        this.Sub2 = sub2;
        this.Sub3 = sub3;
    }

    public Student() {}

    public int CompareTo(Student other)
    {
        return (this.Sub1 + this.Sub2 + this.Sub3) - (other.Sub1 + other.Sub2 + other.Sub3);
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
            students[i] = new Student(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
        }

        Array.Sort(students);

        for(int j = 0; j < N; j++)
            Console.WriteLine($"{students[j].Name} {students[j].Sub1} {students[j].Sub2} {students[j].Sub3}");
    }
}
