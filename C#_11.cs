using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] inputs = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        int N = inputs[0], M = inputs[1];
        // Console.WriteLine($"{N},{M}");
        
        // Tupleのリストを作成して保存
        List<Tuple<int, string>> actions = new List<Tuple<int, string>>();
        
        for(int i = 0; i < M; i++)
        {
            string[] parts = Console.ReadLine().Split();
            int a = int.Parse(parts[0]);
            string b = parts[1];
            
            // 正しいTupleの作成方法
            var pair = new Tuple<int, string>(a, b);
            actions.Add(pair);
        }
        for(int i = 1; i <= N; i++)
        {
            var currentActions = new List<string>();
            // List<string> currentActions = new List<string>();
            // currentActions.Clear(); // リストを空にする
            
            // 各アクションルールをチェック
            foreach(var pair in actions)
            {
                int a = pair.Item1;
                string b = pair.Item2;
                
                // i が a の倍数ならアクションを追加
                if(i % a == 0)
                {
                    currentActions.Add(b);
                }
            }
            
            // 結果出力
            if(currentActions.Count == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(string.Join(" ", currentActions));
            }
        }
    }
}