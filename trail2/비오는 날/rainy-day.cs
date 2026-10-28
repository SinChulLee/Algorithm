using System;

public class Weather
{
    public string Date;
    public string Day;
    public string Wt;

    public Weather(string date, string day, string wt)
    {
        this.Date = date;
        this.Day = day;
        this.Wt = wt;
    }

    public Weather() {}
}

public class Codetree
{  
    public static void Main()
    {
        // Please write your code here.
        int n = int.Parse(Console.ReadLine());
        Weather[] weathers = new Weather[n];
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            weathers[i] = new Weather(input[0], input[1], input[2]);
        }

        Array.Sort(weathers, (a,b) => string.Compare(a.Date, b.Date));
        for(int j = 0; j < n; j++)
            if(weathers[j].Wt == "Rain")
            {
                Console.Write($"{weathers[j].Date} {weathers[j].Day} {weathers[j].Wt}");
                break;
            }
    }
}
