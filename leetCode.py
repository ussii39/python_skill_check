# https://leetcode.com/problems/kids-with-the-greatest-number-of-candies/submissions/?envType=study-plan-v2&envId=leetcode-75の問題
import unittest
from typing import List


class Solution:
    def kidsWithCandies(self, candies: List[int], extraCandies: int) -> List[bool]:
        has_heighest_candies = [False] * len(candies)
        heigjest = max(candies)
        for i in range(len(candies)):
            if candies[i] + extraCandies >= heigjest:
                has_heighest_candies[i] = True
        return has_heighest_candies


class TestKidsWithCandies(unittest.TestCase):
    def setUp(self):
        self.solution = Solution()

    def test_example_case(self):
        # 基本的なテストケース
        candies = [12, 1, 12]
        extra_candies = 10
        expected = [True, False, True]
        self.assertEqual(
            self.solution.kidsWithCandies(candies, extra_candies), expected
        )

    def test_all_same_values(self):
        # すべての子供が同じ数のキャンディを持っている場合
        candies = [5, 5, 5, 5]
        extra_candies = 1
        expected = [True, True, True, True]
        self.assertEqual(
            self.solution.kidsWithCandies(candies, extra_candies), expected
        )

    def test_minimum_length(self):
        # 最小の長さ（n=2）の場合
        candies = [1, 2]
        extra_candies = 1
        expected = [True, True]
        self.assertEqual(
            self.solution.kidsWithCandies(candies, extra_candies), expected
        )

    def test_maximum_values(self):
        # 制約の最大値を使用したテスト
        candies = [100] * 100  # 長さ100の配列
        extra_candies = 50  # 最大のextraCandies
        expected = [True] * 100
        self.assertEqual(
            self.solution.kidsWithCandies(candies, extra_candies), expected
        )

    def test_constraints(self):
        # 制約チェック用のテスト
        candies = [1, 2, 3]
        extra_candies = 5

        # 配列の長さチェック
        self.assertTrue(2 <= len(candies) <= 100)

        # candies[i]の値チェック
        for candy in candies:
            self.assertTrue(1 <= candy <= 100)

        # extraCandiesの値チェック
        self.assertTrue(1 <= extra_candies <= 50)


if __name__ == "__main__":
    unittest.main(argv=["first-arg-is-ignored"], exit=False)

# 入力: candies = [12,1,12]、extraCandies = 10
# 出力: [true,false,true]

# 制約:
# n == candies.length
# 2 <= n <= 100
# 1 <= candies[i] <= 100
# 1 <= extraCandies <= 50
