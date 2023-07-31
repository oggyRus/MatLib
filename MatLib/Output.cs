using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatLibs
{
    public static class Output
    {
        public static void Print(string output)
        {
            foreach (char c in output)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
    }
}