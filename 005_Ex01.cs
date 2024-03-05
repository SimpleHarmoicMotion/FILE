using System;

namespace Ex01{
    class Program{
        static void Main(string[] args){
            string s1 = "C#";
            string s2 = "programming";

            char c1 = 'A';
            char c2 = 'B';

            string s3 = s1 + " " + s2;
            Console.WriteLine("String: {0}", s3);

            string s3ss = s3.Substring(1, 5);
            Console.WriteLine("Substring: {0}",s3ss);
        }
    }
}