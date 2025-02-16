# Encode and Decode Strings
# Design an algorithm to encode a list of strings to a single string. The encoded string is then decoded back to the original list of strings.

# Please implement encode and decode

# Example 1:

# Input: ["neet","code","love","you"]

# Output:["neet","code","love","you"]
# Example 2:

# Input: ["we","say",":","yes"]

# Output: ["we","say",":","yes"]
# Constraints:

# 0 <= strs.length < 100
# 0 <= strs[i].length < 200
# strs[i] contains only UTF-8 characters.


class Solution:

    def encode(self, strs: list[str]) -> str:
        # 各文字列の長さと内容を "長さ#文字列" の形式で連結
        return "".join(f"{len(s)}#{s}" for s in strs)

    def decode(self, s: str) -> list[str]:
        # 4#neet4#code4#love3#you
        result = []
        i = 0
        while i < len(s):
            j = i

            while s[j] != "#":
                j += 1
            length = int(s[i:j])

            result.append(s[j + 1 : j + 1 + length])

            i = j + 1 + length

        return result


# Output:["neet","code","love","you"]
s = Solution()
input = ["neet", "code", "love", "you"]
assert input == s.decode(s.encode(input))
