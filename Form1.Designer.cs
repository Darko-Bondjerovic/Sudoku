namespace SudokuNS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.solvePuzzleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flipCandidatesPositionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.showPossibleValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markAllPairsGuessesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPairsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pnlNumbers = new System.Windows.Forms.Panel();
            this.circularProgressBar9 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar8 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar7 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar6 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar5 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar4 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar3 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.AutomFinder = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlNumbers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1042, 1005);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItem7,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.solvePuzzleToolStripMenuItem,
            this.toolStripMenuItem4,
            this.openToolStripMenuItem1,
            this.saveToolStripMenuItem1,
            this.toolStripSeparator2,
            this.flipCandidatesPositionToolStripMenuItem,
            this.lockNumbersToolStripMenuItem,
            this.newToolStripMenuItem1,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fileToolStripMenuItem.Text = "&Puzzle";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 26);
            this.toolStripMenuItem2.Text = "&New";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // solvePuzzleToolStripMenuItem
            // 
            this.solvePuzzleToolStripMenuItem.Name = "solvePuzzleToolStripMenuItem";
            this.solvePuzzleToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.solvePuzzleToolStripMenuItem.Text = "Solve puzzle...";
            this.solvePuzzleToolStripMenuItem.Click += new System.EventHandler(this.solvePuzzleToolStripMenuItem_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(200, 6);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem1.Image")));
            this.openToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.openToolStripMenuItem1.Text = "&Open...";
            this.openToolStripMenuItem1.Click += new System.EventHandler(this.openToolStripMenuItem1_Click);
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.saveToolStripMenuItem1.Text = "&Save As...";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // flipCandidatesPositionToolStripMenuItem
            // 
            this.flipCandidatesPositionToolStripMenuItem.Name = "flipCandidatesPositionToolStripMenuItem";
            this.flipCandidatesPositionToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.flipCandidatesPositionToolStripMenuItem.Text = "Flip candidates position";
            this.flipCandidatesPositionToolStripMenuItem.Click += new System.EventHandler(this.flipCandidatesPositionToolStripMenuItem_Click);
            // 
            // lockNumbersToolStripMenuItem
            // 
            this.lockNumbersToolStripMenuItem.Name = "lockNumbersToolStripMenuItem";
            this.lockNumbersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lockNumbersToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.lockNumbersToolStripMenuItem.Text = "Lock numbers";
            this.lockNumbersToolStripMenuItem.Click += new System.EventHandler(this.lockNumbersToolStripMenuItem_Click_1);
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(203, 26);
            this.newToolStripMenuItem1.Text = "&Clear all numbers...";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(200, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(203, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem1,
            this.showPossibleValuesToolStripMenuItem,
            this.markAllPairsGuessesToolStripMenuItem,
            this.showPairsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.copyToolStripMenuItem.Text = "&Copy numbers";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.pasteToolStripMenuItem.Text = "&Paste numbers";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 6);
            // 
            // showPossibleValuesToolStripMenuItem
            // 
            this.showPossibleValuesToolStripMenuItem.Name = "showPossibleValuesToolStripMenuItem";
            this.showPossibleValuesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.showPossibleValuesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.showPossibleValuesToolStripMenuItem.Text = "Show / hide candidates";
            this.showPossibleValuesToolStripMenuItem.Click += new System.EventHandler(this.showPossibleValuesToolStripMenuItem_Click);
            // 
            // markAllPairsGuessesToolStripMenuItem
            // 
            this.markAllPairsGuessesToolStripMenuItem.Name = "markAllPairsGuessesToolStripMenuItem";
            this.markAllPairsGuessesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.markAllPairsGuessesToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.markAllPairsGuessesToolStripMenuItem.Text = "Mark all pairs guesses";
            this.markAllPairsGuessesToolStripMenuItem.Click += new System.EventHandler(this.markAllPairsGuessesToolStripMenuItem_Click);
            // 
            // showPairsToolStripMenuItem
            // 
            this.showPairsToolStripMenuItem.Name = "showPairsToolStripMenuItem";
            this.showPairsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.showPairsToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.showPairsToolStripMenuItem.Text = "Show pairs of candidates";
            this.showPairsToolStripMenuItem.Click += new System.EventHandler(this.showPairsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Sudoku Puzzle (*.sdp) |*.sdp";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Sudoku Puzzle (*.sdp) |*.sdp";
            // 
            // pnlNumbers
            // 
            this.pnlNumbers.BackColor = System.Drawing.Color.DarkKhaki;
            this.pnlNumbers.Controls.Add(this.circularProgressBar9);
            this.pnlNumbers.Controls.Add(this.circularProgressBar8);
            this.pnlNumbers.Controls.Add(this.circularProgressBar7);
            this.pnlNumbers.Controls.Add(this.circularProgressBar6);
            this.pnlNumbers.Controls.Add(this.circularProgressBar5);
            this.pnlNumbers.Controls.Add(this.circularProgressBar4);
            this.pnlNumbers.Controls.Add(this.circularProgressBar3);
            this.pnlNumbers.Controls.Add(this.circularProgressBar2);
            this.pnlNumbers.Controls.Add(this.circularProgressBar1);
            this.pnlNumbers.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNumbers.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlNumbers.Location = new System.Drawing.Point(935, 24);
            this.pnlNumbers.Name = "pnlNumbers";
            this.pnlNumbers.Size = new System.Drawing.Size(107, 1005);
            this.pnlNumbers.TabIndex = 22;
            // 
            // circularProgressBar9
            // 
            this.circularProgressBar9.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar9.AnimationSpeed = 0;
            this.circularProgressBar9.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar9.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar9.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar9.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar9.InnerMargin = 2;
            this.circularProgressBar9.InnerWidth = -1;
            this.circularProgressBar9.Location = new System.Drawing.Point(3, 848);
            this.circularProgressBar9.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar9.Maximum = 9;
            this.circularProgressBar9.Name = "circularProgressBar9";
            this.circularProgressBar9.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar9.OuterMargin = -20;
            this.circularProgressBar9.OuterWidth = 20;
            this.circularProgressBar9.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar9.ProgressWidth = 20;
            this.circularProgressBar9.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar9.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar9.StartAngle = 270;
            this.circularProgressBar9.Step = 1;
            this.circularProgressBar9.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar9.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar9.SubscriptText = "";
            this.circularProgressBar9.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar9.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar9.SuperscriptText = "";
            this.circularProgressBar9.TabIndex = 75;
            this.circularProgressBar9.Tag = "9";
            this.circularProgressBar9.Text = "8";
            this.circularProgressBar9.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar9.Value = 9;
            // 
            // circularProgressBar8
            // 
            this.circularProgressBar8.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar8.AnimationSpeed = 0;
            this.circularProgressBar8.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar8.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar8.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar8.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar8.InnerMargin = 2;
            this.circularProgressBar8.InnerWidth = -1;
            this.circularProgressBar8.Location = new System.Drawing.Point(3, 742);
            this.circularProgressBar8.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar8.Maximum = 9;
            this.circularProgressBar8.Name = "circularProgressBar8";
            this.circularProgressBar8.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar8.OuterMargin = -20;
            this.circularProgressBar8.OuterWidth = 20;
            this.circularProgressBar8.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar8.ProgressWidth = 20;
            this.circularProgressBar8.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar8.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar8.StartAngle = 270;
            this.circularProgressBar8.Step = 1;
            this.circularProgressBar8.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar8.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar8.SubscriptText = "";
            this.circularProgressBar8.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar8.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar8.SuperscriptText = "";
            this.circularProgressBar8.TabIndex = 74;
            this.circularProgressBar8.Tag = "8";
            this.circularProgressBar8.Text = "8 ";
            this.circularProgressBar8.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar8.Value = 9;
            // 
            // circularProgressBar7
            // 
            this.circularProgressBar7.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar7.AnimationSpeed = 0;
            this.circularProgressBar7.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar7.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar7.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar7.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar7.InnerMargin = 2;
            this.circularProgressBar7.InnerWidth = -1;
            this.circularProgressBar7.Location = new System.Drawing.Point(3, 636);
            this.circularProgressBar7.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar7.Maximum = 9;
            this.circularProgressBar7.Name = "circularProgressBar7";
            this.circularProgressBar7.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar7.OuterMargin = -20;
            this.circularProgressBar7.OuterWidth = 20;
            this.circularProgressBar7.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar7.ProgressWidth = 20;
            this.circularProgressBar7.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar7.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar7.StartAngle = 270;
            this.circularProgressBar7.Step = 1;
            this.circularProgressBar7.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar7.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar7.SubscriptText = "";
            this.circularProgressBar7.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar7.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar7.SuperscriptText = "";
            this.circularProgressBar7.TabIndex = 73;
            this.circularProgressBar7.Tag = "7";
            this.circularProgressBar7.Text = "8 ";
            this.circularProgressBar7.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar7.Value = 9;
            // 
            // circularProgressBar6
            // 
            this.circularProgressBar6.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar6.AnimationSpeed = 0;
            this.circularProgressBar6.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar6.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar6.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar6.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar6.InnerMargin = 2;
            this.circularProgressBar6.InnerWidth = -1;
            this.circularProgressBar6.Location = new System.Drawing.Point(3, 530);
            this.circularProgressBar6.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar6.Maximum = 9;
            this.circularProgressBar6.Name = "circularProgressBar6";
            this.circularProgressBar6.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar6.OuterMargin = -20;
            this.circularProgressBar6.OuterWidth = 20;
            this.circularProgressBar6.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar6.ProgressWidth = 20;
            this.circularProgressBar6.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar6.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar6.StartAngle = 270;
            this.circularProgressBar6.Step = 1;
            this.circularProgressBar6.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar6.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar6.SubscriptText = "";
            this.circularProgressBar6.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar6.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar6.SuperscriptText = "";
            this.circularProgressBar6.TabIndex = 72;
            this.circularProgressBar6.Tag = "6";
            this.circularProgressBar6.Text = "8 ";
            this.circularProgressBar6.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar6.Value = 9;
            // 
            // circularProgressBar5
            // 
            this.circularProgressBar5.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar5.AnimationSpeed = 0;
            this.circularProgressBar5.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar5.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar5.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar5.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar5.InnerMargin = 2;
            this.circularProgressBar5.InnerWidth = -1;
            this.circularProgressBar5.Location = new System.Drawing.Point(3, 424);
            this.circularProgressBar5.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar5.Maximum = 9;
            this.circularProgressBar5.Name = "circularProgressBar5";
            this.circularProgressBar5.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar5.OuterMargin = -20;
            this.circularProgressBar5.OuterWidth = 20;
            this.circularProgressBar5.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar5.ProgressWidth = 20;
            this.circularProgressBar5.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar5.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar5.StartAngle = 270;
            this.circularProgressBar5.Step = 1;
            this.circularProgressBar5.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar5.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar5.SubscriptText = "";
            this.circularProgressBar5.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar5.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar5.SuperscriptText = "";
            this.circularProgressBar5.TabIndex = 71;
            this.circularProgressBar5.Tag = "5";
            this.circularProgressBar5.Text = "8 ";
            this.circularProgressBar5.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar5.Value = 9;
            // 
            // circularProgressBar4
            // 
            this.circularProgressBar4.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar4.AnimationSpeed = 0;
            this.circularProgressBar4.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar4.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar4.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar4.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar4.InnerMargin = 2;
            this.circularProgressBar4.InnerWidth = -1;
            this.circularProgressBar4.Location = new System.Drawing.Point(3, 318);
            this.circularProgressBar4.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar4.Maximum = 9;
            this.circularProgressBar4.Name = "circularProgressBar4";
            this.circularProgressBar4.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar4.OuterMargin = -20;
            this.circularProgressBar4.OuterWidth = 20;
            this.circularProgressBar4.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar4.ProgressWidth = 20;
            this.circularProgressBar4.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar4.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar4.StartAngle = 270;
            this.circularProgressBar4.Step = 1;
            this.circularProgressBar4.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar4.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar4.SubscriptText = "";
            this.circularProgressBar4.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar4.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar4.SuperscriptText = "";
            this.circularProgressBar4.TabIndex = 70;
            this.circularProgressBar4.Tag = "4";
            this.circularProgressBar4.Text = "8 ";
            this.circularProgressBar4.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar4.Value = 9;
            // 
            // circularProgressBar3
            // 
            this.circularProgressBar3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar3.AnimationSpeed = 0;
            this.circularProgressBar3.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar3.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar3.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar3.InnerMargin = 2;
            this.circularProgressBar3.InnerWidth = -1;
            this.circularProgressBar3.Location = new System.Drawing.Point(3, 212);
            this.circularProgressBar3.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar3.Maximum = 9;
            this.circularProgressBar3.Name = "circularProgressBar3";
            this.circularProgressBar3.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar3.OuterMargin = -20;
            this.circularProgressBar3.OuterWidth = 20;
            this.circularProgressBar3.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar3.ProgressWidth = 20;
            this.circularProgressBar3.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar3.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar3.StartAngle = 270;
            this.circularProgressBar3.Step = 1;
            this.circularProgressBar3.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar3.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar3.SubscriptText = "";
            this.circularProgressBar3.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar3.SuperscriptText = "";
            this.circularProgressBar3.TabIndex = 69;
            this.circularProgressBar3.Tag = "3";
            this.circularProgressBar3.Text = "8 ";
            this.circularProgressBar3.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar3.Value = 9;
            // 
            // circularProgressBar2
            // 
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar2.AnimationSpeed = 0;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.Location = new System.Drawing.Point(3, 106);
            this.circularProgressBar2.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar2.Maximum = 9;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar2.OuterMargin = -20;
            this.circularProgressBar2.OuterWidth = 20;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar2.ProgressWidth = 20;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar2.StartAngle = 270;
            this.circularProgressBar2.Step = 1;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TabIndex = 68;
            this.circularProgressBar2.Tag = "2";
            this.circularProgressBar2.Text = "8 ";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar2.Value = 9;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 0;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(3, 0);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Maximum = 9;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.RosyBrown;
            this.circularProgressBar1.OuterMargin = -20;
            this.circularProgressBar1.OuterWidth = 20;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.DarkGreen;
            this.circularProgressBar1.ProgressWidth = 20;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.Size = new System.Drawing.Size(100, 100);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 67;
            this.circularProgressBar1.Tag = "1";
            this.circularProgressBar1.Text = "8 ";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.circularProgressBar1.Value = 9;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15,
            this.toolStripMenuItem16,
            this.toolStripSeparator4,
            this.AutomFinder});
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem7.Text = "&Resolve";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.toolStripMenuItem13.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem13.Text = "Fill only possible values";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.fillOnlyPossibleValuesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.toolStripMenuItem14.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem14.Text = "Fill single numbers";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.findSingleNumbersToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.toolStripMenuItem15.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem15.Text = "Remove Pointing Pair/Triple";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.removePointingPairTripleToolStripMenuItem_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.toolStripMenuItem16.Size = new System.Drawing.Size(245, 22);
            this.toolStripMenuItem16.Text = "Remove Claiming Pair/Triple";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.removeClaimingPairTripleToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // AutomFinder
            // 
            this.AutomFinder.CheckOnClick = true;
            this.AutomFinder.Name = "AutomFinder";
            this.AutomFinder.Size = new System.Drawing.Size(245, 22);
            this.AutomFinder.Text = "Autom. find and fill F5,F6,F7,F8";
            this.AutomFinder.Click += new System.EventHandler(this.automFillSinglesAndPairTripleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 1029);
            this.Controls.Add(this.pnlNumbers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlNumbers.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showPossibleValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showPairsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solvePuzzleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem lockNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markAllPairsGuessesToolStripMenuItem;
        private System.Windows.Forms.Panel pnlNumbers;
        private CircularProgressBar.CircularProgressBar circularProgressBar9;
        private CircularProgressBar.CircularProgressBar circularProgressBar8;
        private CircularProgressBar.CircularProgressBar circularProgressBar7;
        private CircularProgressBar.CircularProgressBar circularProgressBar6;
        private CircularProgressBar.CircularProgressBar circularProgressBar5;
        private CircularProgressBar.CircularProgressBar circularProgressBar4;
        private CircularProgressBar.CircularProgressBar circularProgressBar3;
        private CircularProgressBar.CircularProgressBar circularProgressBar2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem flipCandidatesPositionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem AutomFinder;
    }
}

