# https://leetcode.com/problems/two-sum/
def twoSum(nums, target):
    # すべての組み合わせを試す
    for i in range(len(nums)):
        for j in range(i + 1, len(nums)):
            # 2つの数の和がtargetと一致するか確認
            if nums[i] + nums[j] == target:
                return [i, j]

    # 見つからなかった場合
    return []
