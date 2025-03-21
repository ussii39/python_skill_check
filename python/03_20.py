def main():
    # 入力を取得
    H, W, X = map(int, input().split())

    # H行のテキストを読み込む
    grid = []
    for _ in range(H):
        grid.append(input())

    # すべての行を連結して一つの文字列にする
    single_string = ""
    for line in grid:
        single_string += line

    # 新しい幅Xで文字列を分割する
    result = []
    for i in range(0, len(single_string), X):
        result.append(single_string[i : i + X])

    # 結果を出力
    for line in result:
        print(line)


if __name__ == "__main__":
    main()
