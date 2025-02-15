class Solution:
    def canPlaceFlowers(self, flowerbed: list[int], n: int) -> bool:
        # 両隣が0であるかどうか判定する => Trueの場合は1を代入
        # 代入した回数も計る
        # 代入した回数とnがイコールならTrue
        # print(max((len(list(g)) for k, g in groupby(flowerbed) if k == 0), default=0))
        prev = 0
        count = 0

        for i in range(0, len(flowerbed)):
            print(flowerbed[prev : i + 2])

            if all(num == 0 for num in flowerbed[prev : i + 2]):
                # print(i, prev)
                flowerbed[i] = 1
                count += 1

            prev = i
        print(count)
        return count == n


solution = Solution()
print(solution.canPlaceFlowers(flowerbed=[0, 0, 1, 0, 0], n=1))
