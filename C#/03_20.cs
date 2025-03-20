using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        // N
        // s_1 e_1
        // s_2 e_2
        // ...
        // s_N e_N
        int N = int.Parse(Console.ReadLine());
        List<List<int>> available_days = new List<List<int>>();
        
        for (int i = 0; i < N; i++)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            available_days.Add(input);
        }
        
        // Console.WriteLine(string.Join(",", available_days.Select(x => string.Join(" ", x))));
        
        // 平坦化する - SelectManyを使用
        List<int> flattenedList = available_days.SelectMany(x => x).ToList();
        
        // 最大値と最小値を取得
        int max_day = flattenedList.Max();
        int min_day = flattenedList.Min();
        
        bool isCanAllAvailableDay = false;
        for(int day = min_day; day <= max_day; day++){
            int available_days_count = 0;
            foreach(var available_day in available_days)
            {
                if (day >= available_day[0] && day <= available_day[1])
                {
                    // Console.WriteLine(string.Join(" ", available_day));
                    available_days_count += 1;
                }
            }
            if (available_days_count == N)
            {
                isCanAllAvailableDay = true;
            }
            // Console.WriteLine($"{day}");
        }
        
        string result = isCanAllAvailableDay ? "OK" : "NG";
        Console.WriteLine(result);
    }
}