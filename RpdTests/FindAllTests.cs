using System;

namespace SudokuNS
{
    public class FindAllTests
    {
        const string gameA = "6...415....9.834..4......8...4.591..51.....3.29...........7..5......82....6....7.";
        const string gameB = "....38.5..8...59....6..178..4.3..86.6.5.7....2.81.........87.19..4.1...8.2..9.67.";
        
        const string game1 = "59.7..4..8..4..3..7.6..3.2.23.56.......83...6.8.2.9.....43..67.....74....7....14.";
        const string game2 = "...53..8..4.89...59..1.....67.2.....83....7..5.1...2..1.9..7..4....1837..8....619";

        //PointingPairTriple
        const string game3 = ".4...9368..648....598673412...13...49.4....3....9468..4.5....8...9..4.5....895.47";
        
        public void Execute()
        {
            Console.WriteLine("[GROUP] Find all tests ");
            CheckFindAllTest(game1);
            CheckFindAllTest(game2);
            CheckFindAllTest(game3);
            CheckFindAllTest(gameA);
            CheckFindAllTest(gameB);
        }
        
        public void CheckFindAllTest(string game)
        {
            Console.WriteLine($"[TEST] Test {game.Substring(0,16)}");
            var su = new Sudoku();
            su.SetGameString(game);
            su.ConsoleWrite = (s) => { Console.Write(s); };
            su.RunFindSingles = true;
            su.FindAllSingles();
        }
    }
}