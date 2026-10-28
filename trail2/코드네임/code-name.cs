using System;

class User
{
    public char codeName;
    public int score;
}

public class Codetree
{
    const int MAX_N = 5;

    public static void Main()
    {
        User[] users = new User[MAX_N];
        for (int i = 0; i < MAX_N; i++)
        {
            string[] input = Console.ReadLine().Split();
            users[i] = new User();
            users[i].codeName = input[0][0];
            users[i].score = int.Parse(input[1]);
        }

        // Please write your code here.
        char L_codeName = users[0].codeName;
        int L_score = users[0].score;
        for (int i = 0; i < MAX_N; i++)
        {
            if(users[i].score < L_score)
            {
                L_codeName = users[i].codeName;
                L_score = users[i].score;
            }
        }

        Console.Write($"{L_codeName} {L_score}");
    }
}
