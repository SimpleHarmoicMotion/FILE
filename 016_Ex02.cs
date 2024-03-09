namespace Ex02
{
    class Program
    {
        static double GetData( ref int a, ref double b)
        {
            return ++a * ++b;
        }

        static bool GetData( int a, int b, out int c, out int d)
        {
            c = a + b;
            d = a - b;
            return true;
        }

        static void Main(string[] args)
        {
            int x = 1;
            double y = 1.0;
            double ret = GetData(ref x, ref y);

            int c, d;
            bool bret = GetData(10, 20, out c, out d); 
        }
    }
}