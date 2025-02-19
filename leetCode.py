# # https://leetcode.com/problems/isomorphic-strings/?envType=study-plan-v2&envId=top-interview-150
# from collections import defaultdict
from typing import Optional

# class Solution:
#     def isIsomorphic(self, s: str, t: str) -> bool:
#         s_d = defaultdict(str)
#         t_d = defaultdict(str)
#         t_len = len(t)
#         s_len = len(s)
#         if t_len != s_len:
#             return False
#         for i in range(t_len):
#             if not s_d[s[i]] and not t_d[t[i]]:
#                 s_d[s[i]] = t[i]
#                 t_d[t[i]] = s[i]

#             elif s_d[s[i]] != t[i] or t_d[t[i]] != s[i]:
#                 return False
#         return True


# test_cases = [
#     {"s": "egg", "t": "add", "expected_value": True},
#     {"s": "foo", "t": "bar", "expected_value": False},
#     {"s": "paper", "t": "title", "expected_value": True},
# ]
# s = Solution()
# for case in test_cases:
#     print(s.isIsomorphic(case["s"], case["t"]))
# https://leetcode.com/problems/merge-two-sorted-lists/
# Definition for singly-linked list.

from typing import Optional


class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next


class Solution:
    def mergeTwoLists(
        self, list1: Optional[ListNode], list2: Optional[ListNode]
    ) -> Optional[ListNode]:
        # ダミーヘッドを作成（結果のリストを簡単に構築するため）
        dummy = ListNode()
        current = dummy

        # 両方のリストに要素がある間、小さい方を選んで追加
        while list1 and list2:
            if list1.val <= list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next
            current = current.next

        # 残りの要素を追加
        current.next = list1 if list1 else list2

        return dummy.next
