using System;
using System.Linq;
using System.Collections.Generic;  // これを追加

class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        int N = int.Parse(Console.ReadLine());
        
        // Enumerable.Range(1,N)
        List<int> weights = new List<int>();
        for(int i = 0; i < N; i++)
        {
            int weight = int.Parse(Console.ReadLine());
            weights.Add(weight);
            
        }
        // Console.WriteLine(string.Join(",",weights));
        
        int prev_weight = weights[0];
        int continue_weight_down_day_count = 0;
        int max_continue_weight_down_day_count = 0;
        int continue_weight_up_day_count = 0;
        int max_continue_weight_up_day_count = 0;
        
        for(int i = 1; i < N; i++)
        {
            // Console.WriteLine($"{weights[i]},{prev_weight}");
            if(prev_weight > weights[i])
            {
                continue_weight_down_day_count += 1;
                continue_weight_up_day_count = 0;
            }
            else if(prev_weight < weights[i])
            {
                continue_weight_up_day_count += 1;
                continue_weight_down_day_count = 0;
            }
            else
            {
                continue_weight_up_day_count = 0;
                continue_weight_down_day_count = 0;
            }
            max_continue_weight_down_day_count = Math.Max(max_continue_weight_down_day_count,continue_weight_down_day_count);
            max_continue_weight_up_day_count = Math.Max(max_continue_weight_up_day_count,continue_weight_up_day_count);
            prev_weight = weights[i];
        }
        Console.WriteLine($"{max_continue_weight_down_day_count} {max_continue_weight_up_day_count}");
        
    }
}