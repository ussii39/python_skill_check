# Given an integer array nums and an integer k, return the k most frequent elements within the array.

# The test cases are generated such that the answer is always unique.

# You may return the output in any order.

# Example 1:

# Input: nums = [1,2,2,3,3,3], k = 2

# Output: [2,3]
# Example 2:

# Input: nums = [7,7], k = 1

# Output: [7]
# Constraints:

# 1 <= nums.length <= 10^4.
# -1000 <= nums[i] <= 1000
# 1 <= k <= number of distinct elements in nums.


from collections import Counter


class Solution:
    def topKFrequent(self, nums: list[int], k: int) -> list[int]:

        return list(map(lambda x: x[0], Counter(nums).most_common(k)))


s = Solution()
k = 2
output = [3, 2]
print(s.topKFrequent(nums=[1, 2, 2, 3, 3, 3], k=2))
assert output == s.topKFrequent(nums=[1, 2, 2, 3, 3, 3], k=2)
