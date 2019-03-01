using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        List<int> horsesStrength = new List<int>();
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int pi = int.Parse(Console.ReadLine());
            horsesStrength.Add(pi);
        }
        
        horsesStrength.Sort();
        int Difference = Math.Abs(horsesStrength.ElementAt(0) - horsesStrength.ElementAt(1));
        
        for (int i = 1; i < N; i++)
        {
            int Aux = Math.Abs(horsesStrength.ElementAt(i) - horsesStrength.ElementAt(i-1));
            if (Aux < Difference)
                Difference = Aux;
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(Difference);
    }
}
