A, B, N = map(int, input().split())
total_cost = A  # 最初の片道運賃

prev_y_day = 0
first_internship = True


def computed_min_price(days: int) -> int:
    moving_cost = A * 2  # 往復運賃
    hotel_cost = days * B  # ホテル滞在費
    return min(moving_cost, hotel_cost)  # より安い方を選択


for _ in range(N):
    x, y = map(int, input().split())

    if not first_internship:
        # 前回のインターンシップ終了日と今回の開始日の間の日数
        gap_days = x - prev_y_day
        if gap_days > 0:
            # ホテル滞在か帰宅かの安い方を選択
            total_cost += computed_min_price(gap_days)
    else:
        first_internship = False

    prev_y_day = y

# 最後のインターンシップから帰宅する片道運賃を加算
total_cost += A

print(total_cost)
