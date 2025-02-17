# https://leetcode.com/problems/ransom-note/?envType=study-plan-v2&envId=top-interview-150
from collections import Counter


class Solution:
    def canConstruct(self, ransomNote: str, magazine: str) -> bool:
        return not Counter(ransomNote) - Counter(magazine)


s = Solution()
print(s.canConstruct(ransomNote="a", magazine="b"))
