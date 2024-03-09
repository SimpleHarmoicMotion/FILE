using System;
using System.Collections.Generic;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args){
            List<char> keyList = new List<char>();
            ConsoleKeyInfo Key;
            do{
                Key = Console.ReadKey();
                keyList.Add(Key.KeyChar);
            }while(Key.Key != ConsoleKey.Q);
            Console.WriteLine();
            foreach(char ch in keyList){
                Console.Write(ch);
            }  
        }
    }
}