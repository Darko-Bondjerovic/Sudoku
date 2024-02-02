using System;
using System.Linq;
using System.Collections.Generic;

//Tests to find Claiming ("locked kandidates type 2")
// and Pointing Pair-Triple

namespace SudokuNS
{
    public class ClmPntTests
    {
        public Sudoku sudoku = null;
        public Claiming cla = null;

        //ClaimingPairTriple:
        const string game1 = "59.7..4..8..4..3..7.6..3.2.23.56.......83...6.8.2.9.....43..67.....74....7....14.";
        const string game2 = "...53..8..4.89...59..1.....67.2.....83....7..5.1...2..1.9..7..4....1837..8....619";

        //PointingPairTriple
        const string game3 = ".4...9368..648....598673412...13...49.4....3....9468..4.5....8...9..4.5....895.47";

        public void InitClaiming(string gameStr)
        {
            sudoku = new Sudoku();
            sudoku.SetGameString(gameStr);
            cla = new Claiming(sudoku);
            cla.box = 5;
            cla.candy = 7;
            cla.ConsoleWrite = (s) => { Console.Write(s); };
        }

        public void Execute()
        {
            Console.WriteLine("[GROUP] Cla Pnt Tests");
            
            Test_Box_First_Cells_coords();
            
            Test3FieldsList(1, 0);
            Test3FieldsList(6, 1);
            
            InitClaiming(game1);
            TestMake3FieldsList(5,0);
            TestMake3FieldsList(5,1);
            
            InitClaiming(game1);
            TestGetCandySum(5,0,7);
            TestGetCandySum(5,1,7);

            InitClaiming(game1);
            TestRemoveOneClaiming();

            //must initialize game again, prev test have delete claimings
            InitClaiming(game1);
            TestRemoveAllClaimnigs();

            InitClaiming(game2);
            TestRemoveAllClaimnigs();

            InitClaiming(game3);
            cla.box = 4;
            cla.candy = 5;
            TestFindPointing();
            TestRemoveOnePointing();
            
            //must initialize game again, prev test have delete pointings
            InitClaiming(game3);
            TestRemoveAllPointings();
        }

        public void Print(string str = "")
        {
            Console.WriteLine(str);
        }

        public void Test_Box_First_Cells_coords()
        {
            Print("[TEST] Box First Cells coords");
            
            var count = 0;
            for (int box = 0; box < 9; box++)
            {
                var fj = 3 * (box / 3);
                var fi = 3 * (box % 3);

                Console.Write($"{box}:[{fj},{fi}]  ");
                
                if ((box+1) % 3 == 0)
                    Print();
            }
        }
        
        public void Test3FieldsList(int box, int kind)
        {
            Print($"[TEST] 3 fields list, box: {box} kind: {kind}");

            var fj = 3 * (box / 3);
            var fi = 3 * (box % 3);
            
            var indx = 0;
            
            var y = fj + indx;
            var x = fi + indx;
            
            Print($"y:{y}, x:{x}");

            var start = kind == 0 ? fi : fj;
            
            Print($"start: {start}");

            var newLine = kind == 0? "" : "\n";
            for (int n = start; n < start + 3; n++)
            {
                if (kind == 0) x = n; else y = n;
                Console.Write($"[{y},{x}]" + newLine );
            }

        }
        
        public void TestMake3FieldsList(int box, int kind)
        {
            Print($"[TEST] 3 Fields List in box: {box} kind: {kind}");
            
            cla.box = box;
            cla.kind = kind;
            
            for(int indx=0; indx<3; indx++)
            {
                PrintIndexList(indx, cla.Make3FieldsList(indx));
                Print();
            }
        }
        
        public void TestGetCandySum(int box, int kind, int candy)
        {
            cla.box = box;
            cla.kind = kind;
            cla.candy = candy;
            
            Print($"[TEST] Sum for {cla}");
            
            for(int indx=0; indx<3; indx++)
            {
                var list = cla.Make3FieldsList(indx);
                Print($" indx: {indx} -> SUM: {cla.GetCandySum(list)}");
            }
        }
        
        public void PrintIndexList(int indx, List<Pair> list)
        {
            Console.Write($"indx: {indx} -> [{string.Join("|", list)}]");
        }
        
        public void PrintPairList(List<Pair> list)
        {
            if (list == null)
            {
                Print("Argument list is null.");
                return;
            }
            
            var line = new string('-', 10);
            
            Print(line);
            Print(string.Join("\n", list));
            Print(line);
            var sum = cla.GetCandySum(list);
            Print($"{sum}");
            Print(line);
        }

        public void TestRemoveOneClaiming()
        {
            Print("[TEST] TestRemoveOneClaiming");
            
            cla.kind = 1;
            
            cla.RemoveOneClaiming();
        }

        public void TestRemoveAllClaimnigs()
        {
            Print("[TEST] TestRemoveAllClaimnigs");
            cla.RemoveAll();
        }

        public void TestFindPointing()
        {
            Print("[TEST] TestFindPointing");
            Print(cla.ToString());
            PrintPairList(cla.FindToRemovePointing());
        }
        
        public void TestRemoveOnePointing()
        {
            Print("[TEST] TestRemoveOnePointing");
            cla.RemoveOnePointing();
        }
        
        public void TestRemoveAllPointings()
        {
            Print("[TEST] TestRemoveAllPointings");
            cla.RemoveAll(false);
        }
    }
}