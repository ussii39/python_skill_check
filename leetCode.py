# https://leetcode.com/problems/find-the-highest-altitude/description/?envType=study-plan-v2&envId=leetcode-75
from typing import List


class Solution:
    def largestAltitude(self, gain: List[int]) -> int:
        start = 0
        maxAltitude = 0
        if len(gain) == 0:
            return 0
        for i in gain:
            start += i
            print(start)
            print(maxAltitude)
            if start > maxAltitude:
                maxAltitude = start
        return maxAltitude


s = Solution()
s.largestAltitude(gain=[-5, 1, 5, 0, -7])
