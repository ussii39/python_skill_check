using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public string ReverseVowels(string s)
    {
        // 文字列を配列に変換して操作しやすくする
        char[] charArray = s.ToCharArray();
        
        // 母音を定義（小文字と大文字の両方）
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        
        // 2つのポインタを初期化
        int left = 0;
        int right = s.Length - 1;
        
        while (left < right)
        {
            // 左側の母音を見つける
            while (left < right && !vowels.Contains(charArray[left]))
            {
                left++;
            }
            
            // 右側の母音を見つける
            while (left < right && !vowels.Contains(charArray[right]))
            {
                right--;
            }
            
            // 母音を入れ替える
            char temp = charArray[left];
            charArray[left] = charArray[right];
            charArray[right] = temp;
            
            // ポインタを移動
            left++;
            right--;
        }
        debug(charArray);
        // 配列を文字列に戻す
        return new string(charArray);
    }
}

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string X = input[0];
        string Y = input[1];
        
        int bobTotal = X.Select(x => int.Parse(x.ToString())).Sum();
        int aliceTotal = Y.Select(y => int.Parse(y.ToString())).Sum();
        // Console.WriteLine(bobTotal);
        // Console.WriteLine(aliceTotal);
        int bobScore = bobTotal.ToString().Last();
        int aliceScore = aliceTotal.ToString().Last();
        if (bobScore > aliceScore)
        {
            Console.WriteLine("Bob");
        }
        else if (bobScore < aliceScore)
        {
            Console.WriteLine("Alice");
        }else
        {
            Console.WriteLine("Draw");    
        }
      
    }
}