using System;

class C
{
    public string secretCode;
    public char meetingPoint;
    public int time;

    public C(string SC, char MP, int T)
    {
        this.secretCode = SC;
        this.meetingPoint = MP;
        this.time = T;
    }

}

public class Codetree
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string secretCode = input[0];
        char meetingPoint = input[1][0];
        int time = int.Parse(input[2]);
        // Please write your code here.
        C c = new C(secretCode, meetingPoint, time);
        Console.WriteLine($"secret code : {c.secretCode}");
        Console.WriteLine($"meeting point : {c.meetingPoint}");
        Console.WriteLine($"time : {c.time}");
    }
}
