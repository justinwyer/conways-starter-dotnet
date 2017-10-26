using System;
using System.Collections.Generic;

namespace Conways
{
    class Program
    {
        public static readonly Boolean[][] TestState =
        {
            new [] {false, false, false, false, false},
            new [] {false, true, false, true, false},
            new [] {false, true, false, false, false},
            new [] {false, true, true, true, false},
            new [] {false, false, false, false, false},
        };
        static void Main(string[] args)
        {
            var output = new TextWriterGameOutput(TestState.Length, Console.Out);
            output.Display(TestState);
        }
    }
}
