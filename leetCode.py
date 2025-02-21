from collections import Counter


class Solution:
    def wordPattern(self, pattern: str, s: str) -> bool:
        words = s.split()

        # パターンと単語の数が異なる場合はFalse
        if len(pattern) != len(words):
            return False

        # 双方向のマッピングを保持
        char_to_word = {}
        word_to_char = {}

        # パターンと単語を同時に走査
        for char, word in zip(pattern, words):
            if char not in char_to_word:
                if word in word_to_char:
                    return False
                char_to_word[char] = word
                word_to_char[word] = char
            elif char_to_word[char] != word:
                return False

        print(char_to_word)
        print(word_to_char)
        return True


s = Solution()
test_cases = [
    {"pattern": "abba", "s": "dog cat cat dog", "expected": True},
    {"pattern": "abba", "s": "dog cat cat fish", "expected": False},
    {"pattern": "aaaa", "s": "dog cat cat dog", "expected": False},
]
for test in test_cases:
    # assert test["expected"] == s.wordPattern(test["pattern"], test["s"])
    print(s.wordPattern(test["pattern"], test["s"]))
