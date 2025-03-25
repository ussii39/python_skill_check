using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // 文化設定を変更して小数点をピリオドに固定
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        
        // 子供の数を取得
        int N = int.Parse(Console.ReadLine());
        
        // 身長の最小値と最大値を初期化
        double minHeight = 100.0; // 条件より最小100cm
        double maxHeight = 200.0; // 条件より最大200cm
        
        // N人の子供の情報を取得して処理
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            string comparison = input[0];
            double height = double.Parse(input[1]);
            
            if (comparison == "le") // 身長不明の子供の方が低いか同じ (height以下)
            {
                maxHeight = Math.Min(maxHeight, height);
            }
            else if (comparison == "ge") // 身長不明の子供の方が高い (height以上)
            {
                minHeight = Math.Max(minHeight, height);
            }
        }
        
        // 結果を小数第1位まで出力
        Console.WriteLine($"{minHeight:F1} {maxHeight:F1}");
    }
}