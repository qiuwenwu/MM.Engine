﻿using MM.Engine;
using System;
using System.Diagnostics;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        public static PY eng = new PY();

        static void Main(string[] args)
        {
            PY.Init();
            Cache.runPath = Directory.GetCurrentDirectory() + "\\";
            Load();
            //RunFile();
            //RunCode();
            Console.ReadLine();
        }

        private static void RunCode()
        {
            string code = @"
def Main(param1 = None, param2 = None, param3 = None):
    return 'test'";
            string fun = "Main";
            object param1 = 1;
            object param2 = 2;
            object param3 = 3;

            var ret = eng.RunCode(code, fun, param1, param2, param3);
            Debug.WriteLine(ret);
            Debug.WriteLine(eng.GetEx());
        }

        private static void RunFile()
        {
            string file = Cache.runPath + "script\\test.py";
            string fun = "Main";
            object param1 = 1;
            object param2 = 2;
            object param3 = 3;

            var ret = eng.RunFile(file, fun, param1, param2, param3);
            Debug.WriteLine(ret);
            Debug.WriteLine(eng.GetEx());
        }

        private static void Load()
        {
            string file = Cache.runPath + "script\\py\\test1.py";
            var bl = eng.Load(file);
        }
    }
}