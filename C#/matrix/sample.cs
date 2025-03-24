using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 文字列のHashSetを作成
        HashSet<string> fruits = new HashSet<string> { "apple", "banana", "orange", "apple" };
        List<List<int>> matrix = new List<List<int>>
         { new List<int> { 1, 2, 3, 4 },
          new List<int> { 5, 6, 7, 8, 9 },
          new List<int> { 10, 11, 12, 13 },
          new List<int> { 14, 16, 17, 18, 19 }
          };

        // インデックス1から2つの行（2行目と3行目）を取得
        List<List<int>> partialMatrix = matrix.GetRange(1, 2);
        // 各行を文字列に変換して出力
        foreach (var row in partialMatrix)
        {
            Console.WriteLine("[" + string.Join(", ", row) + "]");
        }
        // 結果：
        // [5, 6, 7, 8, 9]
        // [10, 11, 12, 13]

        List<int> partialRow = matrix[1].GetRange(2, 2);
        System.Console.WriteLine(string.Join(",",partialRow));
        // 2行目（インデックス1）の3番目から2つの要素を取得
        // 結果：[7, 8]

    }
}