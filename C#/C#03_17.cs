using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    // Q
    // N_1
    // ...
    // N_Q
    static List<int> FindAllDivisors(int n)
    {
        List<int> d = new List<int>();
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0){
                d.Add(i);
            }
        }
        return d;
    }

    static int SumOfProperDivisors(int n)
    {
        List<int> divisors = FindAllDivisors(n);
        int sum = 0;
        foreach(int divisor in divisors)
        {
            sum += divisor;
        }
        return sum;
    }
    
    static void Main()
    {
        int Q = int.Parse(Console.ReadLine());
        for(int i = 0; i < Q; i++)
        {
            int N = int.Parse(Console.ReadLine());
            int S = SumOfProperDivisors(N);
            
            // 完全数かほぼ完全数かを判定
            if (N == S)
            {
                Console.WriteLine("perfect");    // 完全数
            }
            else if (Math.Abs(N - S) == 1)
            {
                Console.WriteLine("nearly");     // ほぼ完全数
            }
            else
            {
                Console.WriteLine("neither");    // どちらでもない
            }
        }
    }
    
}