using System;
using System.Linq;
class Program
// a b R　　　#工事現場のx座標,工事現場のy座標,工事現場の騒音の大きさ
// N　　　　　#木陰の数
// x_1 y_1　　#木陰1のx座標,木陰1のy座標
// x_2 y_2　　#木陰2のx座標,木陰2のy座標
// ...
// x_N y_N　　#木陰Nのx座標,木陰Nのy座標
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0], b = input[1], R = input[2];
        // Console.WriteLine($"{a} {b} {R}");
        int N = int.Parse(Console.ReadLine());
        for(int i = 0; i < N; i++)
        {
            int[] shade = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x = shade[0], y = shade[1];
            if (Math.Pow(x - a, 2) + Math.Pow(y - b, 2) >= Math.Pow(R, 2))
            {
                Console.WriteLine("silent");
            }
            else
            {
                Console.WriteLine("noisy");
            }
        
        }
    }
}