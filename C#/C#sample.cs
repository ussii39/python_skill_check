using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        // ========== 1. 配列 (Arrays) ==========
        Console.WriteLine("===== 配列 (Arrays) =====");
        
        // 一次元配列
        int[] numbers = new int[5]; // 初期値は0で埋められる
        numbers[0] = 10;
        numbers[1] = 20;
        
        // 初期化子を使った宣言
        string[] fruits = new string[] { "りんご", "バナナ", "オレンジ" };
        // 短縮形
        int[] scores = { 85, 90, 75, 80, 95 };
        
        // 二次元配列 (長方形配列)
        int[,] matrix = new int[3, 4]; // 3行4列の配列
        matrix[0, 0] = 1;
        matrix[1, 2] = 5;
        
        // 二次元配列の初期化
        int[,] grid = new int[,] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        
        // 二次元配列の行数と列数を取得
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        Console.WriteLine($"行数: {rows}, 列数: {cols}");
        
        // 二次元配列の全要素にアクセス
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"{grid[i, j]} ");
            }
            Console.WriteLine();
        }
        
        // ジャグ配列 (各行の長さが異なる二次元配列)
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };
        
        // ジャグ配列の初期化
        int[][] jaggedMatrix = new int[][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 6, 7, 8, 9 }
        };
        
        // ジャグ配列へのアクセス
        for (int i = 0; i < jaggedMatrix.Length; i++) {
            for (int j = 0; j < jaggedMatrix[i].Length; j++) {
                Console.Write($"{jaggedMatrix[i][j]} ");
            }
            Console.WriteLine();
        }
        
        // 配列のメソッド
        Array.Resize(ref scores, 10); // 配列のサイズ変更
        Array.Sort(scores); // 配列の並べ替え
        Array.Reverse(scores); // 配列の反転
        int index = Array.IndexOf(scores, 90); // 要素の検索
        Array.Fill(numbers, 100); // 特定の値で配列を埋める
        bool allPass = Array.TrueForAll(scores, s => s >= 60); // すべての要素が条件を満たすか確認
        
        // ========== 2. リスト (List<T>) ==========
        Console.WriteLine("\n===== リスト (List<T>) =====");
        
        // リストの宣言と初期化
        List<string> cities = new List<string>();
        cities.Add("東京");
        cities.Add("大阪");
        cities.Add("名古屋");
        
        // 初期化子を使った宣言
        List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11, 13 };
        
        // 容量の指定（パフォーマンス最適化）
        List<double> measurements = new List<double>(10000);
        
        // リストのメソッド
        cities.Insert(1, "横浜"); // 特定の位置に要素を挿入
        cities.Remove("大阪"); // 特定の要素を削除
        cities.RemoveAt(0); // インデックスを指定して削除
        bool containsNagoya = cities.Contains("名古屋"); // 要素の存在確認
        int nagoyaIndex = cities.IndexOf("名古屋"); // 要素のインデックスを取得
        cities.Sort(); // リストの並べ替え
        
        // AddRange で複数要素を追加
        cities.AddRange(new[] { "福岡", "札幌", "神戸" });
        
        // RemoveAll で条件に合う要素をすべて削除
        primeNumbers.RemoveAll(x => x > 10);
        
        // ForEach でリスト内の各要素に対して処理を実行
        cities.ForEach(city => Console.WriteLine($"都市: {city}"));
        
        // リストの範囲操作
        List<string> subsetCities = cities.GetRange(1, 2); // インデックス1から2要素取得
        
        // リストをフィルタリング (LINQを使用)
        List<int> evenNumbers = primeNumbers.Where(x => x % 2 == 0).ToList();
        
        // リストのクエリ (LINQを使用)
        var sortedCities = cities.OrderByDescending(c => c.Length).ToList();
        
        // ========== 3. 二次元リスト ==========
        Console.WriteLine("\n===== 二次元リスト =====");
        
        // 二次元リストの宣言（リストのリスト）
        List<List<int>> matrix2d = new List<List<int>>();
        
        // 二次元リストの初期化
        for (int i = 0; i < 3; i++) {
            List<int> row = new List<int>();
            for (int j = 0; j < 4; j++) {
                row.Add(i * 4 + j);
            }
            matrix2d.Add(row);
        }
        
        // 二次元リストへのアクセス
        for (int i = 0; i < matrix2d.Count; i++) {
            for (int j = 0; j < matrix2d[i].Count; j++) {
                Console.Write($"{matrix2d[i][j]} ");
            }
            Console.WriteLine();
        }
        
        // 行の追加
        matrix2d.Add(new List<int> { 12, 13, 14, 15 });
        
        // 特定の行の要素を追加
        matrix2d[0].Add(100);
        
        // 不規則な二次元リスト（各行の要素数が異なる）
        List<List<string>> irregularMatrix = new List<List<string>> {
            new List<string> { "A", "B", "C" },
            new List<string> { "D", "E" },
            new List<string> { "F", "G", "H", "I" }
        };
        
        // ========== 4. Dictionary (連想配列) - 既に一部がpaste.txtにある ==========
        Console.WriteLine("\n===== Dictionary (追加例) =====");
        
        // 複雑なキーの使用例（タプルをキーにする）
        var coordinates = new Dictionary<(int x, int y), string>();
        coordinates.Add((0, 0), "原点");
        coordinates.Add((10, 20), "ポイントA");
        coordinates.Add((-5, 15), "ポイントB");
        
        // 複合キーの取得
        if (coordinates.TryGetValue((0, 0), out string locationName)) {
            Console.WriteLine($"座標 (0,0) の名前: {locationName}");
        }
        
        // キーの存在確認の代替方法
        string value = coordinates.GetValueOrDefault((100, 100), "未知の場所");
        Console.WriteLine($"座標 (100,100) の名前: {value}");
        
        // ネストされたディクショナリ
        var employeesByDepartment = new Dictionary<string, Dictionary<string, string>>() {
            { 
                "営業部", 
                new Dictionary<string, string> { 
                    { "E001", "山田太郎" },
                    { "E002", "佐藤花子" }
                }
            },
            { 
                "技術部", 
                new Dictionary<string, string> { 
                    { "E003", "鈴木一郎" },
                    { "E004", "田中次郎" }
                }
            }
        };
        
        // ネストされたディクショナリへのアクセス
        string employeeName = employeesByDepartment["技術部"]["E003"];
        Console.WriteLine($"技術部のE003: {employeeName}");
        
        // ========== 5. SortedDictionary & SortedList ==========
        Console.WriteLine("\n===== SortedDictionary & SortedList =====");
        
        // SortedDictionary（キーでソートされた辞書）
        SortedDictionary<string, int> sortedScores = new SortedDictionary<string, int>() {
            { "佐藤", 85 },
            { "田中", 90 },
            { "鈴木", 78 },
            { "高橋", 92 }
        };
        
        // 自動的にキーでソートされる
        foreach (var pair in sortedScores) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
        
        // SortedList（SortedDictionaryと似ているがメモリ使用量が少ない）
        SortedList<int, string> rankingList = new SortedList<int, string>() {
            { 3, "佐藤" },
            { 1, "田中" },
            { 4, "鈴木" },
            { 2, "高橋" }
        };
        
        // キーでソートされた順にアクセス
        foreach (var pair in rankingList) {
            Console.WriteLine($"ランク {pair.Key}: {pair.Value}");
        }
        
        // インデックスでのアクセス（SortedDictionaryにはない機能）
        string secondRanked = rankingList.Values[1]; // 2番目に小さいキーの値
        
        // ========== 6. HashSet & SortedSet ==========
        Console.WriteLine("\n===== HashSet & SortedSet =====");
        
        // HashSet（重複のない要素のコレクション）
        HashSet<string> uniqueNames = new HashSet<string>() {
            "田中", "鈴木", "佐藤", "田中" // 重複は自動的に無視される
        };
        
        // 要素の追加
        uniqueNames.Add("高橋");
        
        // 要素の存在確認（高速）
        bool hasTanaka = uniqueNames.Contains("田中");
        
        // セット操作
        HashSet<string> otherNames = new HashSet<string>() { "鈴木", "山田", "伊藤" };
        
        // 和集合
        uniqueNames.UnionWith(otherNames);
        
        // 積集合
        HashSet<string> intersection = new HashSet<string>(uniqueNames);
        intersection.IntersectWith(otherNames);
        
        // 差集合
        HashSet<string> difference = new HashSet<string>(uniqueNames);
        difference.ExceptWith(otherNames);
        
        // 対称差（両方のセットに含まれない要素）
        HashSet<string> symmetricDifference = new HashSet<string>(uniqueNames);
        symmetricDifference.SymmetricExceptWith(otherNames);
        
        // SortedSet（ソートされた重複のない要素のコレクション）
        SortedSet<int> sortedUniqueNumbers = new SortedSet<int>() { 5, 2, 8, 1, 5, 3 };
        
        foreach (int num in sortedUniqueNumbers) {
            Console.Write($"{num} "); // 1, 2, 3, 5, 8 の順で表示
        }
        Console.WriteLine();
        
        // ========== 7. Queue & Stack ==========
        Console.WriteLine("\n===== Queue & Stack =====");
        
        // Queue（先入れ先出し - FIFO）
        Queue<string> printQueue = new Queue<string>();
        printQueue.Enqueue("文書1.pdf");
        printQueue.Enqueue("文書2.pdf");
        printQueue.Enqueue("文書3.pdf");
        
        // 先頭の要素を取得して削除
        string nextDocument = printQueue.Dequeue();
        Console.WriteLine($"次に印刷: {nextDocument}");
        
        // 先頭の要素を取得（削除しない）
        string peekDocument = printQueue.Peek();
        Console.WriteLine($"次の印刷待ち: {peekDocument}");
        
        // Stack（後入れ先出し - LIFO）
        Stack<string> historyStack = new Stack<string>();
        historyStack.Push("ページ1");
        historyStack.Push("ページ2");
        historyStack.Push("ページ3");
        
        // 最後に追加された要素を取得して削除
        string currentPage = historyStack.Pop();
        Console.WriteLine($"現在のページ: {currentPage}");
        
        // 最後に追加された要素を取得（削除しない）
        string previousPage = historyStack.Peek();
        Console.WriteLine($"前のページ: {previousPage}");
        
        // ========== 8. LinkedList ==========
        Console.WriteLine("\n===== LinkedList =====");
        
        // LinkedList（双方向リンクリスト）
        LinkedList<string> playlist = new LinkedList<string>();
        
        // 要素の追加
        LinkedListNode<string> firstSong = playlist.AddFirst("曲1");
        LinkedListNode<string> lastSong = playlist.AddLast("曲3");
        
        // 特定のノードの前後に要素を追加
        playlist.AddAfter(firstSong, "曲2");
        playlist.AddBefore(lastSong, "曲2.5");
        
        // リンクリストのノード間の移動
        LinkedListNode<string> current = playlist.First;
        while (current != null) {
            Console.WriteLine($"再生中: {current.Value}");
            current = current.Next;
        }
        
        // 要素の削除
        playlist.Remove("曲2");
        playlist.RemoveFirst();
        playlist.RemoveLast();
 
        
        // ========== 10. ImmutableCollections ==========
        Console.WriteLine("\n===== 不変コレクション =====");
        
        // 不変リスト（.NET Core 2.0以降）
        // using System.Collections.Immutable;
        // ImmutableList<int> immutableList = ImmutableList.Create<int>(1, 2, 3);
        // ImmutableList<int> newList = immutableList.Add(4); // 元のリストは変更されず、新しいリストが返される
        
        // 不変ディクショナリ
        // ImmutableDictionary<string, int> immutableDict = ImmutableDictionary.Create<string, int>()
        //     .Add("A", 1)
        //     .Add("B", 2);
        
        // ========== 11. LINQ操作 ==========
        Console.WriteLine("\n===== LINQ操作 =====");
        
        List<int> dataSet = new List<int> { 3, 8, 1, 7, 5, 2, 9, 4, 6 };
        
        // フィルタリング
        var evenNumbers2 = dataSet.Where(x => x % 2 == 0);
        
        // 変換
        var squares = dataSet.Select(x => x * x);
        
        // 並べ替え
        var ascending = dataSet.OrderBy(x => x);
        var descending = dataSet.OrderByDescending(x => x);
        
        // グループ化
        var grouped = dataSet.GroupBy(x => x % 3);
        
        foreach (var group in grouped) {
            Console.WriteLine($"余り {group.Key}: {string.Join(", ", group)}");
        }
        
        // 集計
        int sum = dataSet.Sum();
        double average = dataSet.Average();
        int min = dataSet.Min();
        int max = dataSet.Max();
        
        // 存在確認
        bool hasEvenNumber = dataSet.Any(x => x % 2 == 0);
        bool allPositive = dataSet.All(x => x > 0);
        
        // 最初と最後の要素
        int first = dataSet.First();
        int last = dataSet.Last();
        
        // 安全な取得
        int firstEven = dataSet.FirstOrDefault(x => x % 2 == 0);
        
        // 複数条件でLINQを連結
        var complexQuery = dataSet
            .Where(x => x > 3)
            .OrderBy(x => x)
            .Select(x => x * 10)
            .Take(3);
        
        Console.WriteLine($"複雑なクエリの結果: {string.Join(", ", complexQuery)}");
        
        // ========== 12. イテレータパターン ==========
        Console.WriteLine("\n===== イテレータパターン =====");
        
        // カスタムイテレータを使用（yield return）
        foreach (int number in GenerateSequence(1, 5)) {
            Console.WriteLine($"生成された数: {number}");
        }
        
        // 複雑な条件のイテレータ
        foreach (string item in FilteredItems(new[] { "A", "BB", "CCC", "DDDD" })) {
            Console.WriteLine($"フィルタされたアイテム: {item}");
        }
    }
    
    // イテレータメソッドの例
    static IEnumerable<int> GenerateSequence(int start, int count) {
        for (int i = 0; i < count; i++) {
            yield return start + i;
        }
    }
    
    // 条件付きイテレータ
    static IEnumerable<string> FilteredItems(IEnumerable<string> items) {
        foreach (var item in items) {
            if (item.Length > 1) {
                yield return item;
            }
        }
    }
}