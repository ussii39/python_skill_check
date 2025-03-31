using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
        List<int> bars = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        // N = 6 M = 3
        // a_1 a_2 ... a_N
        int N = line[0];
        int M = line[1];
        bool hasOK = false;
        for (int i = 0; i <= N - M; i++)
        {
            List<int> range = bars.GetRange(i, M);
            if (range.All(x => x == 0))
            {
                hasOK = true;
                break;
            }
        }
        Console.WriteLine(hasOK ? "NG" : "OK");
    }
            
}