using System;

public class Student : IComparable<Student>
{
    public string Name;
    public int Kor, Eng, Mat;

    public Student(string name, int kor, int eng, int mat)
    {
        this.Name = name;
        this.Kor = kor;
        this.Eng = eng;
        this.Mat = mat;
    }

    public Student() {}

    public int CompareTo(Student other)
    {
        if(this.Kor != other.Kor)
            return other.Kor - this.Kor;
        if(this.Eng != other.Eng)
            return other.Eng - this.Eng;
        return other.Mat - this.Mat;
        
    }

    // public int CompareTo(Student other)
    // {
    // if (this.Kor != other.Kor)
    //     return other.Kor.CompareTo(this.Kor);

    // if (this.Eng != other.Eng)
    //     return other.Eng.CompareTo(this.Eng);

    // return other.Mat.CompareTo(this.Mat);
    // }
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        Student[] students = new Student[n];
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            students[i] = new Student(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]));
        }

        Array.Sort(students);

        for(int j = 0; j < n; j++)
        {
            Console.WriteLine($"{students[j].Name} {students[j].Kor} {students[j].Eng} {students[j].Mat}");
        }
    }
}
