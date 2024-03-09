#define TEST_ENV

using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verbose = false;
#if (TEST_ENV)
            Console.WriteLine("Test Environment : Verbose option is set.");
            verbose = true;
#else
            Console.WriteLine("Production");
#endif
            if (verbose)
            {
                //...
            }
        }
    }
}