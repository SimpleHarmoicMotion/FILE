using System;

namespace Ex02{
    class CSVar{
        const int MAX_VAL = 1024;

        readonly int Max;
        public CSVar(){
            Max = 1;
        }
        public void print(){
            Console.WriteLine(MAX_VAL);
            Console.WriteLine(Max);
        }
    }

    class Program{
        static void Main(string[] args){
            CSVar obj = new CSVar();
            obj.print();
        }
    }
}