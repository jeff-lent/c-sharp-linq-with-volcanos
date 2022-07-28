using System;

namespace VolcanoProject
{
    class Program
    {
        static void Main(string[] args)
        {
            VolcanoAnalyzer va = new VolcanoAnalyzer();
            va.loadVolcanoes();
            System.Console.WriteLine(va.numVolcanoes());
        }
    }
}