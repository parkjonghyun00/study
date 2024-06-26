// https://www.acmicpc.net/problem/2606

int ComputerCount = int.Parse(Console.ReadLine());
int ComputerPair = int.Parse(Console.ReadLine());

Graph graph = new Graph(ComputerCount);

for (int i = 0; i < ComputerPair; i++)
{
    int[] temp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    
    graph.AddBranch(temp[0], temp[1]);
}

graph.SearchBFS(1);

Console.WriteLine(graph.CheckCount() - 1);

class Graph
{
    private int count;
    private List<int>[] graph;
    private bool[] visit;

    public Graph(int count) 
    { 
        this.count = ++count;

        graph = new List<int>[count];
        visit = new bool[count];

        for (int i = 0; i < count; i++)
        {
            graph[i] = new List<int> ();
        }
    }

    public void AddBranch(int leftItem, int rightItem)
    {
        graph[leftItem].Add(rightItem);
        graph[rightItem].Add(leftItem);
    }

    public void SearchBFS(int now)
    {
        visit[now] = true;

        for (int i = 1; i < count; i++)
        {
            if (graph[now].Contains(i) && !visit[i])
            {
                SearchBFS(i);
            }
        }
    }

    public int CheckCount()
    {
        int result = 0;

        for (int i = 0; i < visit.Length ; i++)
        {
            if (visit[i])
            {
                result++;
            }
        }

        return result;
    }
}
