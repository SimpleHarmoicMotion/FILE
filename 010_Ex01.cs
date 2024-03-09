using System;
using System.Collections.Generic;

namespace Ex01
{
    class Program
    {
        static IEnumerable<int> GetNumber()
        {
            yield return 10;
            yield return 20;
            yield return 30;
        }

        static void Main(string[] args)
        {
            foreach (int num in GetNumber())
            {
                Console.WriteLine(num);
            }
        }
    }
}