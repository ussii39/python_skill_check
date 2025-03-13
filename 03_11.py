# coding: utf-8
# 自分の得意な言語で
# Let's チャレンジ！！

# N M
# a_1 b_1
# a_2 b_2
# ...
# a_M b_M
import math

N, M = map(int, input().split())

pair = []
for _ in range(M):
    a, b = map(str, input().split())
    pair.append((int(a), b))

# print(pair)


def get_pair(num: int):
    actions = []
    for k, v in pair:
        # print(k,v)
        if num % k == 0:
            actions.append(v)
    if not actions:
        print(num)
    else:
        print(" ".join(actions))


for num in range(1, N + 1):
    get_pair(num)
