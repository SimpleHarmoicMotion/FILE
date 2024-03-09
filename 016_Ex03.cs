using System;

namespace Ex03
{
    class Program
    {
        int Calc(int a, int b, string calcType = "+")
        {
            switch(calcType){
                case "+":
                    return a + b;
                case "-":
                   return a - b;
                case "*":
                    return a * b;
                case "/":
                   return a / b;
                default:
                    throw new ArithmeticException();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int ret = p.Calc(1,2);
            Console.WriteLine(ret);
            ret = p.Calc(1,2,"*");
            Console.WriteLine(ret);
        }
    }
}