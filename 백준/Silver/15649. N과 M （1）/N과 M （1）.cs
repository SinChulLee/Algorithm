using System;
					
public class Program
{
	static int N, M;
    static bool[] visited;
    static int[] arr;
	
	static void DFS(int depth)
	{
		if (depth == M)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            if (!visited[i])
            {
                visited[i] = true;
                arr[depth] = i;

                DFS(depth + 1);

                visited[i] = false;
            }
        }
	}
	
	public static void Main()
	{
		string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);

        visited = new bool[N + 1];
        arr = new int[M];

        DFS(0);
	}
}