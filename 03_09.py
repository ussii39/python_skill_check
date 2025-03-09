# coding: utf-8
# 自分の得意な言語で
# Let's チャレンジ！！
# ・カードの枚数 M と、シャッフルを行う回数 N がそれぞれ整数で半角スペース区切りで与えられます。
M, N = map(int, input().split())

# print(M,N)

mid = M // 2
cards = [i for i in range(1, M + 1)]
# print(cards[:mid],cards[mid:])

for _ in range(N):
    indexes = []
    right = cards[:mid]
    left = cards[mid:]
    for i in range(0, mid):
        # print(i)
        indexes.append(str(left[i]))
        indexes.append(str(right[i]))
        # print(indexes)
        # right[i],left[i] = left[i],right[i]
        # print(right,left)
    # print(indexes)
    cards = indexes

print(" ".join(cards))
