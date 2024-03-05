using System;

namespace Ex02
{
    class Program{
        static void Main(string[] args){
            string s = "C# Studies";

            for( int i = 0 ; i < s.Length ; i++){
                Console.WriteLine("{0}: {1}", i, s[i]);
            }

            string str = "Hello";

            char[] charArray = str.ToCharArray();

            for( int i = 0 ; i < charArray.Length ; i++ ){
                Console.WriteLine(charArray[i]);
            }

            char[] charArray2 = { 'A', 'B', 'C', 'D' };
            s = new string(charArray2);

             Console.WriteLine(s);

             char c1 = 'A';
             char c2 = (char)(c1 + 3);
             Console.WriteLine(c2);
        }
    }
}