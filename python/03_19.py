from itertools import permutations

a, b, c, d = map(int, input().split())

result = float("-infinity")
cards = list(permutations([a, b, c, d], 4))
for i in range(0, len(cards)):
    mid = len(cards[i]) // 2
    right = cards[i][mid:]
    left = cards[i][:mid]
    # print(right[0],right[1],left[0],left[1])
    # print("".join(list(map(str,right))))
    right_num = "".join(list(map(str, right)))
    left_num = "".join(list(map(str, left)))
    result = max(result, int(right_num) + int(left_num))

print(result)
