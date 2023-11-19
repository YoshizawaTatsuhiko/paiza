using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<int, List<int>> _adjacencyList = new Dictionary<int, List<int>>();
    private static Stack<int> _stack = new Stack<int>();
    private static HashSet<int> _visitedList = new HashSet<int>();

    private static void Main()
    {
        int[] datas = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int n = datas[0], m = datas[1], x = datas[2];

        for (int i = 1; i <= n; i++) _adjacencyList.Add(i, new List<int>());

        for (int i = 0; i < m; i++)
        {
            int[] data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            _adjacencyList[data[0]].Add(data[1]);
            _adjacencyList[data[1]].Add(data[0]);
        }

        foreach(var valueList in _adjacencyList.Values) valueList.Sort();
        DFS(x);

        foreach(var item in _visitedList) Console.WriteLine(item);
    }

    private static void DFS(int vertex)
    {
        if (!_visitedList.Add(vertex)) return;

        foreach (var data in _adjacencyList[vertex])
        {
            _stack.Push(vertex);
            DFS(data);
            _stack.Pop();
        }
    }
}