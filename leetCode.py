# すべての大文字を小文字に変換し、英数字以外の文字をすべて削除した後、前後どちらで読んでも同じになるフレーズは回文です。英数字には、文字と数字が含まれます。

# 文字列が与えられた場合s、trueそれが回文であれば を返し、falseそうでない場合は を返します。


# 例1:

# 入力: s = "A man, a plan, a canal: Panama"
# 出力: true
# 説明: "amanaplanacanalpanama" は回文です。
# 例2:

# 入力: s = "race a car"
# 出力: false
# 説明: "raceacar" は回文ではありません。
# 例3:

# 入力: s = " "
# 出力: true
# 説明: s は、英数字以外の文字を削除した後の空の文字列 "" です。
# 空の文字列は前後どちらから読んでも同じなので、回文になります。


# 制約:

# 1 <= s.length <= 2 * 105
# s印刷可能な ASCII 文字のみで構成されます。

import re


class Solution:
    def isPalindrome(self, s: str) -> bool:
        string = "".join(s.split())
        pattern = f"[^a-zA-Z0-9]"
        text = re.sub(pattern, "", string).lower()

        reversed_text = "".join(reversed(text))
        return text == reversed_text


s = Solution()
expected_output = True
assert expected_output == s.isPalindrome(s="A man, a plan, a canal: Panama")
