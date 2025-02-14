import pytest


input1 = """
4 5
2 0 0 0 1
0 2 0 0 0
0 1 0 3 0
0 0 1 0 0
2 3
##.
#.#
""".strip()

output1 = """
6
""".strip()

input2 = """
7 7
1 0 1 0 1 0 1
0 2 0 2 0 2 0
1 0 3 0 3 0 1
0 2 0 4 0 2 0
1 0 3 0 3 0 1
0 2 0 2 0 2 0
1 0 1 0 1 0 1
5 5
..#..
.###.
#####
.###.
..#..
""".strip()

output2 = """
24
""".strip()

# 1. 通常は購入金額の 1 ％（小数点以下切り捨て）とする
# 2. ただし、3 のつく日は購入金額の 3 ％（小数点以下切り捨て）とする
# 3. ただし、5 のつく日は購入金額の 5 ％（小数点以下切り捨て）とする
import math


def main():
    H, W = map(int, input().split())

    sea_position = [[(i, j) for j in range(1, W)] for i in range(1, H)]
    grid = [list(map(int, input().split())) for _ in range(H)]

    R, C = map(int, input().split())

    net = [["#"] * C for _ in range(R)]
    # print(grid)
    # print(sea_position[R][C])
    for i in range(R):
        row = list("".join(input()))
        net[i] = row
    # マッチする位置の合計値を保存
    match_sums = []
    # すべての 2×3 の範囲をチェック
    for i in range(H - R + 1):  # 高さ
        for j in range(W - C + 1):  # 幅
            total_sum = 0  # 対応する数字の合計値

            # パターンと一致する部分の数字を合計

            for x in range(R):
                for y in range(C):
                    if net[x][y] == "#":  # `#` の部分のみ加算
                        # total_sum += sea_position[i + x][j + y]
                        total_sum += grid[i + x][j + y]
            # 結果を保存
            match_sums.append(total_sum)

    print(max(match_sums))


# 以下は固定
def test_main(monkeypatch) -> None:
    check(monkeypatch, main, input1, output1)
    check(monkeypatch, main, input2, output2)


def check(monkeypatch, func: None, input: str, output: str) -> None:
    import io

    stdin = io.StringIO(input)
    stdout = io.StringIO()

    with monkeypatch.context() as m:
        m.setattr("sys.stdin", stdin)
        m.setattr("sys.stdout", stdout)
        func()

    assert stdout.getvalue() == output + "\n"


if __name__ == "__main__":
    pytest.main([__file__])
