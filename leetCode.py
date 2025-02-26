class Solution:
    def reverseVowels(self, s: str) -> str:
        vowels = set(["a", "e", "i", "o", "u", "A", "E", "I", "O", "U"])
        s_list = list(s)  # 文字列をリストに変換（Pythonの文字列は不変なため）

        # 二つのポインタを使用
        left, right = 0, len(s) - 1

        while left < right:
            # 左側のポインタを母音が見つかるまで移動
            if s_list[left].lower() not in vowels:
                left += 1
                continue

            # 右側のポインタを母音が見つかるまで移動
            if s_list[right].lower() not in vowels:
                right -= 1
                continue

            # 両方のポインタが母音を指している場合、交換する
            s_list[left], s_list[right] = s_list[right], s_list[left]

            # ポインタを進める
            left += 1
            right -= 1

        # リストを文字列に戻す
        return "".join(s_list)


# テスト
str = "IceCreAm"
s = Solution()
result = s.reverseVowels(str)
print(result)  # 'AceCreIm' と出力されるはず
