# coding: utf-8
# 自分の得意な言語で
# Let's チャレンジ！！
N = int(input())

continue_weight_down_day_count = 0
max_continue_weight_down_day_count = 0
continue_weight_up_day_count = 0
max_continue_weight_up_day_count = 0
weights = [int(input()) for _ in range(N)]
prev_weight = weights[0]
for i in range(1, N):
    if prev_weight > weights[i]:
        continue_weight_down_day_count += 1
        # print(f"{i}日は体重が減少しました。")
        continue_weight_up_day_count = 0
    elif prev_weight < weights[i]:
        continue_weight_up_day_count += 1
        # print(f"{i}日は体重が減少しました。")
        continue_weight_down_day_count = 0
    else:
        continue_weight_up_day_count = 0
        continue_weight_down_day_count = 0
    max_continue_weight_down_day_count = max(
        max_continue_weight_down_day_count, continue_weight_down_day_count
    )
    max_continue_weight_up_day_count = max(
        max_continue_weight_up_day_count, continue_weight_up_day_count
    )
    prev_weight = weights[i]
print(max_continue_weight_down_day_count, max_continue_weight_up_day_count)
