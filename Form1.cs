using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SudokuNS
{
    public partial class Form1 : Form
    {
        Sudoku sudoku;
               
        private CircularProgressBar.CircularProgressBar[] bars = 
            new CircularProgressBar.CircularProgressBar[Sudoku.MAX_COUNTERS];

        public Form1()
        {
            InitializeComponent();

            foreach (Control control in pnlNumbers.Controls)
            {
                var indx = ctrlTagToInt(control);

                if (control is CircularProgressBar.CircularProgressBar)
                {
                    //chkNums[indx] = control as Button;
                    var bar = control as CircularProgressBar.CircularProgressBar;
                    var tag = ctrlTagToInt(bar);
                    bar.Text = tag.ToString();
                    bar.Value = 0;
                    bar.Maximum = 9;
                    bar.Click += buttonNumberClick;
                    bar.ProgressWidth = 10;                    
                    bar.OuterWidth = 0; // default 20
                    bars[tag - 1] = bar;
                }
            }

            this.Height = Screen.PrimaryScreen.WorkingArea.Height - 20;
            this.Width = this.Height + 60;                
        }

        private int ctrlTagToInt(Control control)
        {
            //return Int32.Parse(control.Tag.ToString());
            return Convert.ToInt32(control.Tag);
        }

        private void buttonNumberClick(object sender, EventArgs e)
        {
            var tag = ctrlTagToInt(sender as Control);

            //if (tag == 0)
            //    sudoku.HidePossibleFields(); // clear colors
            //else if (tag == 10)
            //    sudoku.MarkPairsCandidates();
            //else
            //
            sudoku.MarkFieldsBy(tag);
            RepaintPictureBox();
        }

        private void ClearBarsCircle()
        {
            foreach (var b in bars)
                b.OuterWidth = 0;
        }

        private void DisplayCounts(SortedDictionary<int, int> dict)
        {
            for (int i = 1; i < dict.Count; i++)
            {
                var value = dict[i];
                if (-1 < value && value < 10)
                    bars[i - 1].Value = dict[i];
            }                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
            sudoku.GenerateGame();
        }

        private void InitializeGame()
        {
            sudoku = new Sudoku();

            sudoku.RequestRepaint = () => RepaintPictureBox();
            sudoku.DisplayInfo = (s) => DisplayInfo(s);
            sudoku.DisplayError = (s) => DisplayErrorBox(s);
            sudoku.DisplayCounts = (s) => DisplayCounts(s);
            sudoku.DoMarkField = (s) => MarkFieldCircle(s);

            sudoku.RunFindSingles = AutomFinder.Checked;

            ClearBarsCircle();
        }

        private void MarkFieldCircle(int tag)
        {
            ClearBarsCircle();
            bars[tag - 1].OuterWidth = 20;
        }

        private void DisplayInfo(string info)
        {            
            MessageBox.Show(info);        
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            sudoku.Draw(e.Graphics, 0);
        }

        private void RepaintPictureBox()
        {
            pictureBox1.Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                ClearBarsCircle();

            sudoku.KeyPress(e.KeyCode);
        }

        private void pictureBox1_SizeChanged(object sender, EventArgs e)
        {
            RepaintPictureBox();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Clear all fields?", "Sudoku",
                    MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
                return;

            
            InitializeGame();
            RepaintPictureBox();            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Copyleft © 2021 by Darko Bondjerovic\n " +
                "https://www.youtube.com/@rapidtdd\n" +
                "\nCtrl+C / Ctrl+V - copy / paste sudoku numbers.\n" +
                "\nSelect number with mouse right click.\n" +
                "\nWhen number is selected, app will display" +
                "\nfree cels for that number.\n" +
                "\nAdd / delete candidate: " +
                "\n- Select number, Holl ALT + right mouse button" +
                "\n- Hold ALT + number \n" +
                "\nMark / demark candidate:" +
                "\n- Select number, Hold CTRL + right mouse button" +
                "\n- Hold CTRL + number\n" +
                "\nBackspace / Ctrl+Z for undo operation." +
                "\nESC - deselect number, clear colors.",
                "About Sudoku 2.0", MessageBoxButtons.OK);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sudoku.GetGameString());
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var text = Clipboard.GetText();
            if (!sudoku.SetGameString(text))
                DisplayErrorBox("The clipboard does not contain a valid puzzle.\n" + text);
            else if (sudoku.RunFindSingles)
                sudoku.FindAllSingles();

            RepaintPictureBox();
        }

        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            try
            {
                sudoku.LoadAllData(openFileDialog1.FileName);
                ClearBarsCircle();
            }
            catch
            {
                DisplayErrorBox("Error: read data from file!");
            }

            RepaintPictureBox();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                sudoku.SaveAllData(saveFileDialog1.FileName);
            }
            catch
            {
                DisplayErrorBox("Error: save data into file!");
            }
        }

        private static void DisplayErrorBox(string s)
        {
            MessageBox.Show(s, "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void showPossibleValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.ShowCandidates = !sudoku.ShowCandidates;
            RepaintPictureBox();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sudoku.GenerateGame();
            ClearBarsCircle();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            sudoku.SetLocation(me.Location, me.Button == MouseButtons.Left);
            RepaintPictureBox();
        }

        private void fillOnlyPossibleValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.FillOnlyPossibleValues();
            RepaintPictureBox();
        }

        private void findSingleNumbersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.FindAllSingles();
        }        

        private void showPairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearBarsCircle();
            sudoku.MarkPairsCandidates();
            RepaintPictureBox();
        }

        private void solvePuzzleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            sudoku.SolvePuzzle();
        }

        private void lockNumbersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show(
                    "Lock numbers?", "Sudoku",
                    MessageBoxButtons.YesNo);
            if (answer == DialogResult.No)
                return;

            sudoku.LockNumbers();
        }       

        private void markAllPairsGuessesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.MarkAllPairsGuesses();
        }

        private void removeClaimingPairTripleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.RemovePairTriple();
            RepaintPictureBox();
        }

        private void removePointingPairTripleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.RemovePairTriple(false);
            RepaintPictureBox();
        }

        private void automFillSinglesAndPairTripleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender == AutomFinder)
                sudoku.RunFindSingles = AutomFinder.Checked;
        }

        private void flipCandidatesPositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sudoku.NumericalCandyPosition = !sudoku.NumericalCandyPosition;
            RepaintPictureBox();
        }
    }
}
