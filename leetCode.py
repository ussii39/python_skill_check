# https://leetcode.com/problems/maximum-average-subarray-i/?envType=study-plan-v2&envId=leetcode-75
from typing import List


class Solution:
    def findMaxAverage(self, nums: List[int], k: int) -> float:
        # 最初のウィンドウの平均値を初期値とする
        max_number = sum(nums[:k]) / k

        # 残りのウィンドウをスライドして計算
        for i in range(len(nums) - k):
            curr_avg = sum(nums[i + 1 : i + k + 1]) / k
            max_number = max(max_number, curr_avg)

        return max_number


s = Solution()
print(s.findMaxAverage(nums=[5], k=1))  # 5
print(s.findMaxAverage(nums=[-1], k=1))  # -1
print(s.findMaxAverage(nums=[1, 12, -5, -6, 50, 3], k=4))  # 12.75
