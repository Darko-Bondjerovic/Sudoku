using System;
using System.Linq;
using System.Collections.Generic;

namespace SudokuNS
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            new ClmPntTests().Execute();
            new FindAllTests().Execute();
        }
    }
}

    

