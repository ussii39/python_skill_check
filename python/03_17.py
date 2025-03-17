def find_all_divisors(n):
    """
    整数nのすべての約数を求める関数
    """
    # 約数を保存するリスト
    divisors = []

    # 1からnまでの数をチェック
    for i in range(1, n):
        # もしiでnが割り切れるなら、iはnの約数
        if n % i == 0:
            divisors.append(i)

    return divisors


def sum_of_proper_divisors(n):
    """
    整数nの真の約数（n自身を除く約数）の和を計算する関数
    """
    # すべての約数を見つける
    divisors = find_all_divisors(n)

    # 約数の和を計算する
    return sum(divisors)


# メイン処理
Q = int(input())  # クエリの数を読み込む

for _ in range(Q):
    N = int(input())  # 判定する数を読み込む

    # Nの真の約数の和を計算
    S = sum_of_proper_divisors(N)

    # 完全数かほぼ完全数かを判定
    if N == S:
        print("perfect")  # 完全数
    elif abs(N - S) == 1:
        print("nearly")  # ほぼ完全数
    else:
        print("neither")  # どちらでもない
