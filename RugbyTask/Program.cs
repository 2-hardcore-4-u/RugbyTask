using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;


class Solution
{
    static void Main(string[] args)
    {
        double N = Double.Parse(Console.ReadLine());
        for (double tries = 0; tries < N / 5 + 1; tries++)
        {
            for (double conversion = 0; conversion < tries + 1; conversion++)
            {
                double penalty = (N - 5 * tries - 2 * conversion) / 3;
                if (penalty >= 0 && penalty == (int)penalty)
                    Console.WriteLine(tries.ToString() + " " + conversion.ToString() + " " + penalty.ToString());
            }
        }
        Console.ReadLine();
    }
}