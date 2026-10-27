using System;

class User
{
    public string ID;
    public int Level;

    public User(string ID, int Level)
    {
        this.ID = ID;
        this.Level = Level;
    }
}

public class Codetree
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string id2 = input[0];
        int level2 = int.Parse(input[1]);
        // Please write your code here.
        User u1 = new User("codetree",10);
        User u2 = new User(id2,level2);
        Console.WriteLine($"user {u1.ID} lv {u1.Level}");
        Console.WriteLine($"user {u2.ID} lv {u2.Level}");
    }
}
