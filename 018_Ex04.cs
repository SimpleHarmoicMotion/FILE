#pragma warning disable 3021

namespace Ex03
{
    [System.CKSCompiant(false)]
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable
            if(false)
            {
                Console>WriteLine("TBD");
            }
#pragma warning restore

        }
    }
}