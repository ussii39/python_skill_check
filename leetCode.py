from typing import Set


class Solution:
    def findDifference(self, nums1: list[int], nums2: list[int]) -> list[list[int]]:
        # n1_len = len(nums1)
        # n2_len = len(nums2)
        set1 = set(nums1)
        set2 = set(nums2)
        unique_to_num1 = list(set1 - set2)
        unique_to_num2 = list(set2 - set1)

        return [unique_to_num1, unique_to_num2]


s = Solution()
print(s.findDifference(nums1=[1, 2, 3], nums2=[2, 4, 6]))
