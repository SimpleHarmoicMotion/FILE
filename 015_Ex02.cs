using System;

namespace Ex02
{
    class Project
    {
        void NullableTest()
        {
            int? a = null;
            int? b = 0;
            int rst = Nullable.Compare<int>(a, b);
            Console.WriteLine(rst);

            double? c = 0.01;
            double? d = 0.0100;
            bool rst2 = Nullable.Equals<double>(c, d);
            Console.WriteLine(rst2);
        }
    }
}