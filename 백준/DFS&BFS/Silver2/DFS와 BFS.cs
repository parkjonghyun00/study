//https://www.acmicpc.net/problem/1260

int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Graph graph = new Graph(input[0]);

for (int i = 0; i < input[1]; i++)
{
    int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    graph.AddNode(temp[0], temp[1]);
}

graph.DFS(input[2]);
Console.WriteLine();

graph.BFS(input[2]);

class Graph
{
    private int count;
    private bool[] check;
    private List<int>[] list;

    public Graph(int count)
    {
        list = new List<int>[count + 1];
        check = new bool[count + 1];

        for (int i = 0; i < count + 1; i++)
        {
            list[i] = new List<int> ();
        }

        this.count = count + 1;
    }


    public void AddNode(int startIndex, int destIndex)
    {
        list[startIndex].Add(destIndex);
        list[destIndex].Add(startIndex);
    }

    public void DFS(int now)
    {
        check[now] = true;
        Console.Write(now + " ");

        for (int i = 1; i <= count; i++)
        {
            if (list[now].Contains(i) && !check[i])
            { 
                DFS(i);
            }
        }
    }

    public void BFS(int start)
    {
        bool[] visited = new bool[count+1];

        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        visited[start] = true;

        while (queue.Count > 0)
        {
            int now = queue.Dequeue();
            Console.Write(now + " ");

            for (int next = 1; next < count; next++)
            {
                if (!list[now].Contains(next))
                    continue;
                if (visited[next])
                    continue;

                queue.Enqueue(next);


                visited[next] = true;
            }
        }
    }
}
