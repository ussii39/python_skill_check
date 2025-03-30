using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static int ScoreAnswer(string correct, string answer)
    {
        // 完全一致の場合は2点
        if (correct == answer)
            return 2;
            
        // 長さが異なる場合は0点
        if (correct.Length != answer.Length)
            return 0;
            
        // 異なる文字の数をカウント（位置ごとに比較）
        int diffCount = 0;
        for (int i = 0; i < correct.Length; i++)
        {
            if (correct[i] != answer[i])
                diffCount++;
        }
        
        // 1文字だけ異なる場合は1点、それ以外は0点
        return diffCount == 1 ? 1 : 0;
    }
    
    static void Main()
    {
        // // テストケースの実行（オプション）
        // var testCases = new[]
        // {
        //     new { Correct = "apple", Answer = "apple", Expected = 2, Description = "完全一致" },
        //     new { Correct = "apple", Answer = "aple", Expected = 0, Description = "長さが異なる" },
        //     new { Correct = "orange", Answer = "olange", Expected = 1, Description = "1文字だけ異なる" },
        //     new { Correct = "grape", Answer = "glepe", Expected = 0, Description = "2文字以上異なる" }
        // };

        // foreach (var test in testCases)
        // {
        //     int score = ScoreAnswer(test.Correct, test.Answer);
        //     Console.WriteLine($"{test.Description}: {(score == test.Expected ? "成功" : "失敗")} - 期待値:{test.Expected}, 実際:{score}");
        // }
        
        // 実際の問題を解く
        int N = int.Parse(Console.ReadLine());
        int totalScore = 0;
        
        for(int i = 0; i < N; i++)
        {
            string[] texts = Console.ReadLine().Split();
            string correct = texts[0];
            string answer = texts[1];
            
            int score = ScoreAnswer(correct, answer);
            totalScore += score;
        }
        
        // 合計得点を表示
        Console.WriteLine(totalScore);
    }
}