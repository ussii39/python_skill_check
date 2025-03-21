N = int(input())

available_days = []
for i in range(N):
    s, e = map(int, input().split())
    available_days.append([s, e])

min_day = min(sum(available_days, []))
max_day = max(sum(available_days, []))

is_both_available_day = False
for day in range(min_day, max_day + 1, 1):
    available_days_count = 0
    for days in available_days:
        # print(f"{min(days)}日 ~ {max(days)}日の間可能で、{day}日の検索中")
        if day >= min(days) and day <= max(days):
            available_days_count += 1
            # print(f"{day}は可能です")
    # print(available_days_count)
    if N == available_days_count:
        is_both_available_day = True

    # print(is_both_available_day)

print("OK" if is_both_available_day else "NG")
