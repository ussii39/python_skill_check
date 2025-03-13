H, W = map(int, input().split())
grid = [input().strip() for _ in range(H)]

# ロープの本数をカウントする変数
rope_count = 0

# 各セルを調べて花壇があるか確認
for i in range(H):
    for j in range(W):
        if grid[i][j] == "#":
            # 上
            if i == 0 or grid[i - 1][j] == ".":
                rope_count += 1
            # 下
            if i == H - 1 or grid[i + 1][j] == ".":
                rope_count += 1
            # 左
            if j == 0 or grid[i][j - 1] == ".":
                rope_count += 1
            # 右
            if j == W - 1 or grid[i][j + 1] == ".":
                rope_count += 1

# 結果を出力
print(rope_count)
