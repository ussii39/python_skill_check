using System;
using System.Linq;
class Program
{
//     N
// a_1 ... a_N
// T Q
// x_1 k_1
// ...
// x_Q k_Q
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var input = Console.ReadLine();
        int[] items = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        var nextLine = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int T = nextLine[0] ,Q = nextLine[1];
        int N = int.Parse(input);
        // Console.WriteLine(items[0]);
        // Console.WriteLine(string.Join(" ", items));
        // Console.WriteLine($"{T} {Q}");
        // Console.WriteLine(N);
        
        for(int i=0; i<Q; i++)
        {
            int[] itemsInfo = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int itemIndex = itemsInfo[0], itemCount = itemsInfo[1]; 
            int totalCost = items[itemIndex-1]*itemCount;
            // Console.WriteLine(totalCost);
            if(T >= totalCost)
            {
                T -= totalCost;
            }
        }
        Console.WriteLine(T);
    }
}