using System;
using System.Linq;
class Program
{
    static int calc_cost(int A, int B, int day)
    {
        int movingCost = A * 2;
        int hotelCost = B * day;
        return Math.Min(movingCost, hotelCost);
    }
    
    static void Main()
    {
        int[] inputs = Console.ReadLine().Split().Select(input => int.Parse(input)).ToArray();
        int A = inputs[0], B = inputs[1], N = inputs[2];
        int totalCost = A;
        int prev_y_day = 0;
        bool isFirstDayIntership = true;
        
        for(int i = 0; i < N; i++)
        {
            int[] days = Console.ReadLine().Split().Select(d => int.Parse(d)).ToArray();
            int x = days[0], y = days[1];
            if (!isFirstDayIntership)
            {
                int gapDays = x - prev_y_day;
                // Console.WriteLine(gapDays);
                if (gapDays > 0)
                {
                    totalCost += calc_cost(A, B, gapDays);
                }
            }
            else
            {
                isFirstDayIntership = false;
            }
            
            prev_y_day = y;
            // Console.WriteLine($"{x},{y}");
        }
        totalCost += A;
        Console.WriteLine(totalCost);
        // Console.WriteLine($"{A},{B},{N}");
    }
}