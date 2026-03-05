using System;
					
public class Program
{
	static string Cantor(int n)
	{
		if (n == 0)
            return "-";

        string prev = Cantor(n - 1);
        string space = new string(' ', prev.Length);

        return prev + space + prev;
	}
	
	public static void Main()
	{
		string line;
		while ((line = Console.ReadLine()) != null)
        {
            int n = int.Parse(line);
            Console.WriteLine(Cantor(n));
        }
	}
}