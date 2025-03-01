from typing import List


class Solution:
    def twoSum(self, nums, target):
        # 見た数字とそのインデックスを記録する辞書
        seen = {}

        # 配列の各数字をチェック
        for i, num in enumerate(nums):
            # 「現在の数字と足してtargetになる数」
            needed = target - num

            # もし必要な数字が既に見つかっていれば
            if needed in seen:
                # 答えを返す
                print(seen)
                return [seen[needed], i]

            # 現在の数字とインデックスを記録
            seen[num] = i
        # 見つからなかった場合
        return []


s = Solution()
print(s.twoSum(nums=[2, 5, 5, 11], target=10))
