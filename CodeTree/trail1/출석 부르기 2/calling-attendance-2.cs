using System;

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        for (int i = 1; i <= 100; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
                Console.WriteLine("John");
            else if (num == 2)
                Console.WriteLine("Tom");
            else if (num == 3)
                Console.WriteLine("Paul");
            else if (num == 4)
                Console.WriteLine("Sam");
            else
            {
                Console.WriteLine("Vacancy");
                break;
            }
        }
    }
}
