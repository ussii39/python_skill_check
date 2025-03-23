using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static int calcPicel(int H,int W,int dy,int dx)
    {
        // (30 × 240) + (30 × 180) - (30 × 30) = 11700 画素となります。
        int allPicel = H * W;
        int commonPicel = Math.Max(0,W - Math.Abs(dx)) * Math.Max(0,H - Math.Abs(dy));
        
        return allPicel - commonPicel;
        
    }
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        // H, W = map(int, input().split())
        // dy, dx = map(int, input().split())
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int H = inputs[0], W = inputs[1]; 
        // Console.WriteLine($"{H},{W}");
        int[] reInputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int dy = reInputs[0], dx = reInputs[1];
        Console.WriteLine(calcPicel(H,W,dy,dx));
        
    }
}