using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQExamples
{
    // サンプルデータ用のクラス
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Category: {Category}, Price: {Price}, Stock: {Stock}";
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Country: {Country}";
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, CustomerId: {CustomerId}, ProductId: {ProductId}, Quantity: {Quantity}, OrderDate: {OrderDate.ToShortDateString()}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // サンプルデータの作成
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "ノートパソコン", Category = "電子機器", Price = 100000, Stock = 10 },
                new Product { Id = 2, Name = "スマートフォン", Category = "電子機器", Price = 80000, Stock = 20 },
                new Product { Id = 3, Name = "ヘッドフォン", Category = "アクセサリー", Price = 15000, Stock = 30 },
                new Product { Id = 4, Name = "マウス", Category = "アクセサリー", Price = 5000, Stock = 50 },
                new Product { Id = 5, Name = "タブレット", Category = "電子機器", Price = 60000, Stock = 15 },
                new Product { Id = 6, Name = "キーボード", Category = "アクセサリー", Price = 8000, Stock = 40 }
            };

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "佐藤", Country = "日本" },
                new Customer { Id = 2, Name = "鈴木", Country = "日本" },
                new Customer { Id = 3, Name = "田中", Country = "日本" },
                new Customer { Id = 4, Name = "Smith", Country = "アメリカ" },
                new Customer { Id = 5, Name = "Johnson", Country = "アメリカ" }
            };

            var orders = new List<Order>
            {
                new Order { Id = 1, CustomerId = 1, ProductId = 1, Quantity = 1, OrderDate = new DateTime(2023, 1, 15) },
                new Order { Id = 2, CustomerId = 2, ProductId = 3, Quantity = 2, OrderDate = new DateTime(2023, 2, 10) },
                new Order { Id = 3, CustomerId = 1, ProductId = 2, Quantity = 1, OrderDate = new DateTime(2023, 3, 5) },
                new Order { Id = 4, CustomerId = 3, ProductId = 5, Quantity = 1, OrderDate = new DateTime(2023, 4, 20) },
                new Order { Id = 5, CustomerId = 4, ProductId = 6, Quantity = 3, OrderDate = new DateTime(2023, 5, 2) },
                new Order { Id = 6, CustomerId = 5, ProductId = 4, Quantity = 2, OrderDate = new DateTime(2023, 6, 10) },
                new Order { Id = 7, CustomerId = 2, ProductId = 1, Quantity = 1, OrderDate = new DateTime(2023, 7, 8) }
            };

            Console.WriteLine("===== データ操作系メソッド =====");

            // Select() - 射影（各要素を変換）
            Console.WriteLine("\n----- Select() -----");
            Console.WriteLine("商品名のみを抽出:");
            var productNames = products.Select(p => p.Name);
            foreach (var name in productNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n商品名と価格を匿名型で抽出:");
            var productInfos = products.Select(p => new { p.Name, p.Price });
            foreach (var info in productInfos)
            {
                Console.WriteLine($"{info.Name}: {info.Price}円");
            }

            // Where() - フィルタリング（条件に合う要素のみ抽出）
            Console.WriteLine("\n----- Where() -----");
            Console.WriteLine("10,000円以上の商品:");
            var expensiveProducts = products.Where(p => p.Price >= 10000);
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine(product);
            }

            // OrderBy() - 昇順ソート
            Console.WriteLine("\n----- OrderBy() -----");
            Console.WriteLine("価格の安い順に商品を並べ替え:");
            var orderedByPrice = products.OrderBy(p => p.Price);
            foreach (var product in orderedByPrice)
            {
                Console.WriteLine($"{product.Name}: {product.Price}円");
            }

            // OrderByDescending() - 降順ソート
            Console.WriteLine("\n----- OrderByDescending() -----");
            Console.WriteLine("在庫の多い順に商品を並べ替え:");
            var orderedByStockDesc = products.OrderByDescending(p => p.Stock);
            foreach (var product in orderedByStockDesc)
            {
                Console.WriteLine($"{product.Name}: {product.Stock}個");
            }

            // ThenBy() - 2次ソート（昇順）
            Console.WriteLine("\n----- ThenBy() -----");
            Console.WriteLine("カテゴリ順、次に価格の安い順:");
            var orderedByCategoryThenPrice = products
                .OrderBy(p => p.Category)
                .ThenBy(p => p.Price);
            foreach (var product in orderedByCategoryThenPrice)
            {
                Console.WriteLine($"{product.Category} - {product.Name}: {product.Price}円");
            }

            // ThenByDescending() - 2次ソート（降順）
            Console.WriteLine("\n----- ThenByDescending() -----");
            Console.WriteLine("カテゴリ順、次に価格の高い順:");
            var orderedByCategoryThenPriceDesc = products
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.Price);
            foreach (var product in orderedByCategoryThenPriceDesc)
            {
                Console.WriteLine($"{product.Category} - {product.Name}: {product.Price}円");
            }

            // GroupBy() - グループ化
            Console.WriteLine("\n----- GroupBy() -----");
            Console.WriteLine("カテゴリごとに商品をグループ化:");
            var groupedByCategory = products.GroupBy(p => p.Category);
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"カテゴリ: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($"  {product.Name}: {product.Price}円");
                }
            }

            // Join() - 結合
            Console.WriteLine("\n----- Join() -----");
            Console.WriteLine("注文と商品情報を結合:");
            var ordersWithProducts = orders.Join(
                products,
                o => o.ProductId,
                p => p.Id,
                (o, p) => new { OrderId = o.Id, ProductName = p.Name, Quantity = o.Quantity, TotalPrice = p.Price * o.Quantity }
            );
            foreach (var order in ordersWithProducts)
            {
                Console.WriteLine($"注文 #{order.OrderId}: {order.ProductName} x {order.Quantity} = {order.TotalPrice}円");
            }

            // Distinct() - 重複を除去
            Console.WriteLine("\n----- Distinct() -----");
            var countries = customers.Select(c => c.Country).Distinct();
            Console.WriteLine("重複を除いた国のリスト:");
            foreach (var country in countries)
            {
                Console.WriteLine(country);
            }

            // Skip() - 指定した数の要素をスキップ
            Console.WriteLine("\n----- Skip() -----");
            Console.WriteLine("最初の2つの商品をスキップ:");
            var skippedProducts = products.Skip(2);
            foreach (var product in skippedProducts)
            {
                Console.WriteLine(product);
            }

            // Take() - 指定した数の要素を取得
            Console.WriteLine("\n----- Take() -----");
            Console.WriteLine("最初の3つの商品を取得:");
            var takenProducts = products.Take(3);
            foreach (var product in takenProducts)
            {
                Console.WriteLine(product);
            }

            // SkipWhile() - 条件を満たす間、要素をスキップ
            Console.WriteLine("\n----- SkipWhile() -----");
            Console.WriteLine("価格が50,000円以上の商品をスキップ（価格順）:");
            var skipWhileProducts = products.OrderBy(p => p.Price).SkipWhile(p => p.Price < 50000);
            foreach (var product in skipWhileProducts)
            {
                Console.WriteLine($"{product.Name}: {product.Price}円");
            }

            // TakeWhile() - 条件を満たす間、要素を取得
            Console.WriteLine("\n----- TakeWhile() -----");
            Console.WriteLine("価格が50,000円未満の商品を取得（価格順）:");
            var takeWhileProducts = products.OrderBy(p => p.Price).TakeWhile(p => p.Price < 50000);
            foreach (var product in takeWhileProducts)
            {
                Console.WriteLine($"{product.Name}: {product.Price}円");
            }

            Console.WriteLine("\n===== 集計系メソッド =====");

            // Count() - 要素数を取得
            Console.WriteLine("\n----- Count() -----");
            Console.WriteLine($"商品の総数: {products.Count()}");
            Console.WriteLine($"10,000円以上の商品数: {products.Count(p => p.Price >= 10000)}");

            // Sum() - 合計
            Console.WriteLine("\n----- Sum() -----");
            Console.WriteLine($"全商品の合計価格: {products.Sum(p => p.Price)}円");
            Console.WriteLine($"全商品の合計在庫数: {products.Sum(p => p.Stock)}個");

            // Average() - 平均
            Console.WriteLine("\n----- Average() -----");
            Console.WriteLine($"商品の平均価格: {products.Average(p => p.Price)}円");
            Console.WriteLine($"商品の平均在庫数: {products.Average(p => p.Stock)}個");

            // Min() - 最小値
            Console.WriteLine("\n----- Min() -----");
            Console.WriteLine($"最も安い商品の価格: {products.Min(p => p.Price)}円");
            Console.WriteLine($"最も安い商品: {products.OrderBy(p => p.Price).First().Name}");

            // Max() - 最大値
            Console.WriteLine("\n----- Max() -----");
            Console.WriteLine($"最も高い商品の価格: {products.Max(p => p.Price)}円");
            Console.WriteLine($"最も高い商品: {products.OrderByDescending(p => p.Price).First().Name}");

            // First() - 最初の要素を取得
            Console.WriteLine("\n----- First() -----");
            Console.WriteLine("最初の商品:");
            Console.WriteLine(products.First());
            Console.WriteLine("カテゴリが「アクセサリー」の最初の商品:");
            Console.WriteLine(products.First(p => p.Category == "アクセサリー"));

            // Last() - 最後の要素を取得
            Console.WriteLine("\n----- Last() -----");
            Console.WriteLine("最後の商品:");
            Console.WriteLine(products.Last());
            Console.WriteLine("カテゴリが「電子機器」の最後の商品:");
            Console.WriteLine(products.Last(p => p.Category == "電子機器"));

            // FirstOrDefault() - 最初の要素、または既定値を取得
            Console.WriteLine("\n----- FirstOrDefault() -----");
            var firstExpensiveProduct = products.FirstOrDefault(p => p.Price > 200000);
            Console.WriteLine("価格が200,000円を超える最初の商品:");
            Console.WriteLine(firstExpensiveProduct == null ? "該当なし" : firstExpensiveProduct.ToString());

            // LastOrDefault() - 最後の要素、または既定値を取得
            Console.WriteLine("\n----- LastOrDefault() -----");
            var lastCheapProduct = products.LastOrDefault(p => p.Price < 3000);
            Console.WriteLine("価格が3,000円未満の最後の商品:");
            Console.WriteLine(lastCheapProduct == null ? "該当なし" : lastCheapProduct.ToString());

            // Single() - 唯一の要素を取得
            Console.WriteLine("\n----- Single() -----");
            try
            {
                var laptopProduct = products.Single(p => p.Name == "ノートパソコン");
                Console.WriteLine("ノートパソコンの商品情報:");
                Console.WriteLine(laptopProduct);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"エラー: {ex.Message}");
            }

            // SingleOrDefault() - 唯一の要素、または既定値を取得
            Console.WriteLine("\n----- SingleOrDefault() -----");
            var tabletProduct = products.SingleOrDefault(p => p.Name == "タブレット");
            Console.WriteLine("タブレットの商品情報:");
            Console.WriteLine(tabletProduct == null ? "該当なし" : tabletProduct.ToString());

            var nonExistingProduct = products.SingleOrDefault(p => p.Name == "テレビ");
            Console.WriteLine("テレビの商品情報:");
            Console.WriteLine(nonExistingProduct == null ? "該当なし" : nonExistingProduct.ToString());

            // Any() - 条件を満たす要素が存在するか判定
            Console.WriteLine("\n----- Any() -----");
            bool hasExpensiveProducts = products.Any(p => p.Price > 90000);
            Console.WriteLine($"90,000円を超える商品は存在しますか？: {(hasExpensiveProducts ? "はい" : "いいえ")}");

            bool hasVeryExpensiveProducts = products.Any(p => p.Price > 200000);
            Console.WriteLine($"200,000円を超える商品は存在しますか？: {(hasVeryExpensiveProducts ? "はい" : "いいえ")}");

            // All() - すべての要素が条件を満たすか判定
            Console.WriteLine("\n----- All() -----");
            bool allProductsInStock = products.All(p => p.Stock > 0);
            Console.WriteLine($"すべての商品の在庫はありますか？: {(allProductsInStock ? "はい" : "いいえ")}");

            bool allProductsCheap = products.All(p => p.Price < 50000);
            Console.WriteLine($"すべての商品は50,000円未満ですか？: {(allProductsCheap ? "はい" : "いいえ")}");

            // Contains() - 指定した要素が含まれるか判定
            Console.WriteLine("\n----- Contains() -----");
            var laptop = products.First();
            bool containsLaptop = products.Contains(laptop);
            Console.WriteLine($"製品リストに「{laptop.Name}」は含まれていますか？: {(containsLaptop ? "はい" : "いいえ")}");

            Console.WriteLine("\n===== セット操作系メソッド =====");

            // セット操作のデモ用の追加データ
            var additionalProducts = new List<Product>
            {
                new Product { Id = 5, Name = "タブレット", Category = "電子機器", Price = 60000, Stock = 15 },
                new Product { Id = 7, Name = "スピーカー", Category = "オーディオ", Price = 12000, Stock = 25 },
                new Product { Id = 8, Name = "イヤホン", Category = "アクセサリー", Price = 7000, Stock = 35 }
            };

            // Union() - 和集合
            Console.WriteLine("\n----- Union() -----");
            var unionProducts = products.Union(additionalProducts, new ProductComparer());
            Console.WriteLine("製品の和集合（重複を除去）:");
            foreach (var product in unionProducts)
            {
                Console.WriteLine(product);
            }

            // Intersect() - 積集合
            Console.WriteLine("\n----- Intersect() -----");
            var intersectProducts = products.Intersect(additionalProducts, new ProductComparer());
            Console.WriteLine("製品の積集合（両方のリストに存在する製品）:");
            foreach (var product in intersectProducts)
            {
                Console.WriteLine(product);
            }

            // Except() - 差集合
            Console.WriteLine("\n----- Except() -----");
            var exceptProducts = products.Except(additionalProducts, new ProductComparer());
            Console.WriteLine("製品の差集合（最初のリストにのみ存在する製品）:");
            foreach (var product in exceptProducts)
            {
                Console.WriteLine(product);
            }

            // Concat() - 連結
            Console.WriteLine("\n----- Concat() -----");
            var concatProducts = products.Concat(additionalProducts);
            Console.WriteLine("製品の連結（重複を含む）:");
            foreach (var product in concatProducts)
            {
                Console.WriteLine(product);
            }
        }
    }

    // Union(), Intersect(), Except()でオブジェクトの同一性を判断するための比較クラス
    public class ProductComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null) || ReferenceEquals(y, null)) return false;
            return x.Id == y.Id;
        }

        public int GetHashCode(Product obj)
        {
            if (ReferenceEquals(obj, null)) return 0;
            return obj.Id.GetHashCode();
        }
    }
}