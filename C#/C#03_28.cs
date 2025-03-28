using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Read N, X, Y from first line
        // N = number of prices
        // X, Y = parameters for calculation
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = inputs[0];
        int X = inputs[1];
        int Y = inputs[2];
        
        // Create a list to store prices
        List<int> prices = new List<int>();
        
        // Read N prices and add them to the list
        for (int i = 0; i < N; i++)
        {
            int p = int.Parse(Console.ReadLine());
            prices.Add(p);
        }
        
        // Sort the prices after all prices have been added
        // prices.Sort();
        List<int> descendingPrices = prices.OrderByDescending(x => x).ToList();

        
        // Print the sorted prices
        
        
        for (int i = 0; i < N; i++)
        {
            if (i + 1 == X)
            {
               descendingPrices.RemoveRange(N-Y, Y); 
            }
        }
        Console.WriteLine(descendingPrices.Sum());
        
        // int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        // int[] newArray = array.Where((item, index) => index < 3 || index > 5).ToArray();
    }
}