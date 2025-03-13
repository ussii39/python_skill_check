using System;
using System.Linq;
class Program
{
    static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
          // N
          // t_1 e_1 m_1 s_1 j_1 g_1
          // t_2 e_2 m_2 s_2 j_2 g_2
          // ...
          // t_N e_N m_N s_N j_N g_N
          // 全科目の合計得点が 350 点以上
          // 理系の受験者の場合は理系 2 科目 (数学、理科) の合計得点が 160 点以上
          // 文系の受験者の場合は文系 2 科目 (国語、地理歴史) の合計得点が 160 点以上
        int N = int.Parse(Console.ReadLine());
        int passed_count = 0;

        for (int t = 1; t <= N; t++)
        {
            string[] values = Console.ReadLine().Split(' ');
            string t_1 = values[0];
            
            // 残りの値を数値に変換
            int[] numbers = values.Skip(1).Select(int.Parse).ToArray();
            int e_1 = numbers[0];
            int m_1 = numbers[1];
            int s_1 = numbers[2];
            int j_1 = numbers[3];
            int g_1 = numbers[4];
            
            int sub_score = 0;
            int all_sub_score = e_1 + m_1 + s_1 + j_1 + g_1;

            if (t_1 == "s")
            {
                sub_score += m_1 + s_1;
            }
            else if (t_1 == "l")
            {
                sub_score += j_1 + g_1;
            }
            
            if (all_sub_score >= 350 && sub_score >= 160)
            {
                passed_count += 1;
            }
        }
        
        Console.WriteLine(passed_count);
    }
}