# https://paiza.jp/career/challenges/732/page/result

N, X = map(int, input().split())
slimes = list(map(int, input().split()))

# スライムの大きさをソート
slimes.sort()

# 取り込んだスライムのカウント
count = 0

# 現在の大きさ
current_size = X

# 最も大きいスライム
biggest_slime = slimes[-1]

# 現在の大きさが最も大きいスライムを超えるまでループ
while current_size <= biggest_slime and slimes:
    # 取り込めるスライムの中で最も大きいスライムを探す
    near_num = -1
    for slime in slimes:
        if slime <= current_size:
            near_num = slime
        else:
            break

    # 取り込めるスライムが見つからなかった場合、終了
    if near_num == -1:
        break

    # そのスライムを取り込む
    current_size += near_num
    slimes.remove(near_num)
    count += 1

# 現在の大きさが最も大きいスライムを超えていればカウントを出力
if current_size > biggest_slime:
    print(count)
else:
    print(-1)
