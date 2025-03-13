# https://paiza.jp/career/challenges/724/page/result
import math

N, L = map(int, input().split())

current_lv = L

for _ in range(N):
    enemy_lv = int(input())
    if current_lv > enemy_lv:
        current_lv += math.floor(enemy_lv / 2)
    elif current_lv == enemy_lv:
        continue
    else:
        current_lv = math.floor(current_lv / 2)


print(current_lv)
