using System;
using System.IO;
using System.Linq;

class Program
{
    const int START = 0;
    int[][] a;
    int n;
    int[] x;
    int total = 0;
    int[] best;
    int totalBest = int.MaxValue;
    bool[] d;

    void ReadData()
    {
        var lines = File.ReadAllLines("travel.inp");
        n = int.Parse(lines[0]);
        a = new int[n][];
        for (int i = 0; i < n; i++)
        {
            a[i] = lines[i + 1].Split().Select(int.Parse).ToArray();
        }
    }

    void InitData()
    {
        ReadData();
        x = new int[n];
        best = new int[n];
        d = new bool[n];
        x[0] = START;
        d[START] = true;
    }

    void Output()
    {
        using (var writer = new StreamWriter("travel.out"))
        {
            writer.WriteLine(totalBest);
            writer.WriteLine(string.Join("->", best.Select(i => i + 1)) + "->" + (START + 1));
        }
    }

    void Update()
    {
        if (a[x[n - 1]][START] > 0 && total + a[x[n - 1]][START] < totalBest)
        {
            totalBest = total + a[x[n - 1]][START];
            Array.Copy(x, best, n);
        }
    }

    int count = 0;
    void Travel(int idx)
    {
        if (total > totalBest) return;
        count++;
        for (int i = 0; i < n; i++)
        {
            if (!d[i] && a[x[idx - 1]][i] > 0)
            {
                x[idx] = i;
                d[i] = true;
                total += a[x[idx - 1]][i];
                if (idx == n - 1)
                {
                    Update();
                }
                else
                {
                    Travel(idx + 1);
                }
                d[i] = false;
                total -= a[x[idx - 1]][i];
            }
        }
    }

    static void Main()
    {
        var program = new Program();
        program.InitData();
        program.Travel(1);
        program.Output();
        // Console.WriteLine("so luot chay : " + program.count);
    }
}
