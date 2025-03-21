using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
//     入力例1
//      3 5
//      5
//      15
//      10
// N R
// a_1
// a_2
// ...
// a_N
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] inputs = Console.ReadLine().Split().Select((x) => int.Parse(x)).ToArray();
        int N = inputs[0];
        int R = inputs[1];
        int maxCount = 0;
        List<int> sales = new List<int>();
        // Console.WriteLine($"{N},{R}");
        for(int i=0; i < N; i++)
        {
            int a = int.Parse(Console.ReadLine());
            int saleCount = a / R;
            maxCount = Math.Max(maxCount,saleCount);
            sales.Add(saleCount);
            // Console.WriteLine($"{i+1}:{new string('*', saleCount)}");
        }
        for(int i=0; i < N; i++)
        {
            int saleCount = sales[i];
            int operatorCount = maxCount - saleCount;
            Console.WriteLine($"{i+1}:{new string('*', saleCount) + new string('.',operatorCount)}");
        }
    }
}