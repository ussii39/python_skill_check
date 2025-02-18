# https://leetcode.com/problems/isomorphic-strings/?envType=study-plan-v2&envId=top-interview-150
from collections import defaultdict


class Solution:
    def isIsomorphic(self, s: str, t: str) -> bool:
        s_d = defaultdict(str)
        t_d = defaultdict(str)
        t_len = len(t)
        s_len = len(s)
        if t_len != s_len:
            return False
        for i in range(t_len):
            if not s_d[s[i]] and not t_d[t[i]]:
                s_d[s[i]] = t[i]
                t_d[t[i]] = s[i]

            elif s_d[s[i]] != t[i] or t_d[t[i]] != s[i]:
                return False
        return True


test_cases = [
    {"s": "egg", "t": "add", "expected_value": True},
    {"s": "foo", "t": "bar", "expected_value": False},
    {"s": "paper", "t": "title", "expected_value": True},
]
s = Solution()
for case in test_cases:
    print(s.isIsomorphic(case["s"], case["t"]))
