from typing import List, Union
from itertools import groupby


class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        # 配列が2以下なら変更の必要なし
        if len(nums) <= 2:
            return len(nums)

        # insertする位置を示すポインタ
        k = 2

        # 3番目の要素から順にチェック
        for i in range(2, len(nums)):
            # 現在の数が2つ前の位置の数と異なれば追加可能
            if nums[i] != nums[k - 2]:
                nums[k] = nums[i]
                k += 1

        return k


s = Solution()

nums: list[int] = [1, 1, 1, 2, 2, 3]

expectedNums: list[Union[int, str]] = [
    1,
    1,
    2,
    2,
    3,
]


k: int = s.removeDuplicates(nums)

assert k == len(expectedNums)

for i in range(k):
    assert nums[i] == expectedNums[i]
