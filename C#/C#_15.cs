using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 日数を取得
        int days = int.Parse(Console.ReadLine());
        
        // 天気データを取得
        int[] weatherData = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        // 虹が出る可能性のある日を計算
        List<int> rainbowDays = FindRainbowDays(weatherData, days);
        
        // 三項演算子を使用して結果を出力
        Console.WriteLine(rainbowDays.Count == 0 ? "-1" : string.Join(" ", rainbowDays));
    }
    
    /// <summary>
    /// 雨の日(2)の翌日が晴れ(0)である日を見つけ、その日のインデックスを返す
    /// </summary>
    /// <param name="weatherData">天気データの配列</param>
    /// <param name="days">日数</param>
    /// <returns>虹が出る可能性のある日のインデックスのリスト</returns>
    private static List<int> FindRainbowDays(int[] weatherData, int days)
    {
        List<int> rainbowDays = new List<int>();
        
        for (int i = 1; i < days; i++)
        {
            // 三項演算子を使用するほどの複雑さはないので、条件に合致する場合のみリストに追加
            if (weatherData[i - 1] == 2 && weatherData[i] == 0)
            {
                rainbowDays.Add(i);
            }
        }
        
        return rainbowDays;
    }
}