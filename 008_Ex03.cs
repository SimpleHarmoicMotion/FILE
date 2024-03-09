﻿using System;

namespace Ex03
{
    class Program
    {
        static bool verbose = false;
        static bool continueOnError = false;
        static bool logging = false;

        static void Main(string[] args){
            if(args.Length != 1){
                Console.WriteLine("Useage : 008_Ex03.exe option");
                return;
            }

            string option = args[0];
            switch (option.ToLower())
            {
                case "/v":
                case "/verbose":
                    verbose = true;
                    break;
                case "/c":
                    continueOnError = true;
                    break;
                case "/1":
                    logging = true;
                    break;
                default:
                    Console.WriteLine("Unknown argument : {0}", option);
                    break;
            }
        }
    }
}