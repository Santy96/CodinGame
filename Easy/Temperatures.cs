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
        int V = 0;
        int n = int.Parse(Console.ReadLine()); // the number of temperatures to analyse
        string[] inputs = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            int t = int.Parse(inputs[i]); // a temperature expressed as an integer ranging from -273 to 5526
            if (V == 0 && t != '\0')
                V = t;
            V = CalculoAuxiliar.ValorMasCercanoACeroPriorizandoPositivos(t,V);
        }

        // Write an action using Console.WriteLine()
        // To debug: Console.Error.WriteLine("Debug messages...");

        Console.WriteLine(V);
    }
}
class CalculoAuxiliar
{
    public static int ValorMasCercanoACeroPriorizandoPositivos(int x, int y)
    {
        if (Math.Abs(x) <= Math.Abs(y))
            if (!(x == y * -1 && x < 0))
                return x;
            else
                return y;
        else
            return y;
    }
}
