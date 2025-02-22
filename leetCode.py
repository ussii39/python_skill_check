# https://leetcode.com/problems/happy-number/?envType=study-plan-v2&envId=top-interview-150
class Solution:
    def isHappy(self, n: int) -> bool:
        result = sum([int(num) ** 2 for num in list(str(n))])
        print(result)
        if n == 1:
            return True
        elif 1 == result:
            return True
        elif 9 >= result:
            return False
        else:
            return self.isHappy(n=result)


s = Solution()
print(s.isHappy(n=1111111))
