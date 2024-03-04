using System;

namespace Ex01{
    class CSVar{
        int gbV;
        const int MAX = 1024;

        public void Method1(){
            int lV;
            lV = 100;

            Console.WriteLine(gbV);
            Console.WriteLine(lV);
        }
    }
    class Ex01{
        static void Main(string[] args){
            CSVar obj = new CSVar();
            obj.Method1();
        }
    }
}