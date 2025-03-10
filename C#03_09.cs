using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int M = input[0], N = input[1];
        int[] card = Enumerable.Range(1, M).ToArray();
        int mid = M / 2;
        
        // Console.WriteLine($"{M} {N}");
        // Console.WriteLine(string.Join(", ", card));
        
        for(int i = 0; i < N; i++)
        {
            // C# 8.0以前の方法で配列をスライス
            int[] right = new int[mid];
            Array.Copy(card, 0, right, 0, mid);
            
            int[] left = new int[card.Length - mid];
            Array.Copy(card, mid, left, 0, card.Length - mid);
            
            List<int> temp = new List<int>();
            
            // left と right の長さが異なる可能性があるため、それぞれ別々にループする
            int maxLength = Math.Max(left.Length, right.Length);
            
            for(int j = 0; j < maxLength; j++)
            {
                // left の要素があれば追加
                if (j < left.Length)
                {
                    temp.Add(left[j]);
                }
                
                // right の要素があれば追加
                if (j < right.Length)
                {
                    temp.Add(right[j]);
                }
            }
            
            card = temp.ToArray();
        }
        
        Console.WriteLine(string.Join(" ", card));
    }
}