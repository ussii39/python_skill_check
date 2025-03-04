# coding: utf-8
# 自分の得意な言語で
# Let's チャレンジ！！
import math

k, n = map(int, input().split())

# 1 ~ 9 => * 80%
# 10 <= x  => 0


# 80 ~ 100 A
# 70 ~ 79 B
# 60 ~ 69 C
# 0 ~ 59 D
def judge_rank(point: int) -> str:
    if 80 <= point <= 100:
        return "A"
    elif 70 <= point <= 79:
        return "B"
    elif 60 <= point <= 69:
        return "C"
    else:
        return "D"


def caluc_point(point_per_one_question) -> str:
    for i in range(k):
        d, a = map(int, input().split())
        spended_day = d
        point = 0
        if spended_day <= 0:
            # print(d,a)
            # print(f"原点なしなので,{a*point_per_one_question}")
            point = a * point_per_one_question
        elif 1 <= spended_day <= 9:
            # print(f"{spended_day}日遅れなので、80%減の{math.floor((a*point_per_one_question) * 0.8)}")
            point = math.floor(a * point_per_one_question * 0.8)
        else:
            # print(f"{spended_day}日遅れなので、100%減")
            point = 0
        # print(point)
        print(judge_rank(point))
        # return judge_rank(point)


def main():
    point_per_one_question = 100 // n
    # print(point_per_one_question)
    caluc_point(point_per_one_question)


if __name__ == "__main__":
    main()
