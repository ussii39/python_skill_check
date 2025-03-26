using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int H = inputs[0];
        int W = inputs[1];
        
// ・画素値が 128 以上 : 1 (白)
// ・画素値が 127 以下 : 0 (黒)
        for(int i = 0; i < H; i++)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> colors = new List<int>();
            for(int j = 0; j < W; j++)
            {
                if(arr[j] >= 128)
                {
                    colors.Add(1);
                }else
                {
                    colors.Add(0);
                }
            }
            Console.WriteLine(string.Join(" ",colors));
        }
    }
}