using Game_Of_Life.Domain;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Game_Of_Life
{
    public partial class MainWindow : Form
    {
        
        Board board;        // Board object
        bool boardFolded;   // The board is folded or not (edges behaviour)

        public MainWindow()
        {
            InitializeComponent();
            Restart();
        }


        //
        // These GUI actions require restart the board
        //
        private void RandomButton_Click(object sender, EventArgs e) { Restart(); }
        private void BoardPictureBoxChangeSize(object sender, EventArgs e) { Restart(); }
        private void CellSizePixelsChanged(object sender, EventArgs e) { Restart(); }
        private void LivingCellsPercentageChanged(object sender, EventArgs e) { Restart(); }
        private void BoardFoldChanged(object sender, EventArgs e)
        {
            boardFolded = BoardFoldCheckBox.Checked;
            Restart();
        }

        // Restart the board with a random distribution (or not)
        private void Restart(bool randomlyDistribute = true)
        {
            board = new Board(BoardPictureBox.Width, BoardPictureBox.Height, (int)CellSizePixels.Value, fold: boardFolded);
            if (randomlyDistribute)
                board.RandomlyDistribute((double)LivingCellsPercentage.Value / 100);
            DrawBoard();
        }

        // Restart the board with a starting configuration
        private void Restart(string startingConfiguration)
        {
            string[] lines = startingConfiguration.Split('\n');
            int yOffset = (board.Rows - lines.Length) / 2;
            int xOffset = (board.Columns - lines[0].Length) / 2;

            Restart(randomlyDistribute: false);
            for (int y = 0; y < lines.Length; y++)
                for (int x = 0; x < lines[y].Length; x++)
                    board.Cells[x + xOffset, y + yOffset].Alive = lines[y].Substring(x, 1) == "X";

            DrawBoard();
        }

        // Timer settings
        private void PlayStopChanged(object sender, EventArgs e) { Timer.Enabled = PlayStopCheckbox.Checked; }
        private void DelayMsChanged(object sender, EventArgs e) { Timer.Interval = (int)DelayMs.Value; }
        private void Timer_Tick(object sender, EventArgs e)
        {
            board.NextStep();
            DrawBoard();
        }


        // This method draws the board in the screen
        // configuring a BitMap that is set in the BoardPictureBox
        private void DrawBoard()
        {
            using Bitmap bmp = new Bitmap(board.Width, board.Height);
            using Graphics gfx = Graphics.FromImage(bmp);
            using SolidBrush brush = new SolidBrush(Color.LightSalmon); //Alive cells color
            gfx.Clear(ColorTranslator.FromHtml("#36443A"));             //Background color

            var cellSize = new Size(board.CellSize, board.CellSize);

            for (int col = 0; col < board.Columns; col++)
            {
                for (int row = 0; row < board.Rows; row++)
                {
                    if (board.Cells[col, row].Alive)
                    {
                        var cellLocation = new Point(col * board.CellSize, row * board.CellSize);
                        var cellRect = new Rectangle(cellLocation, cellSize);
                        gfx.FillRectangle(brush, cellRect);
                    }
                }
            }

            BoardPictureBox.Image?.Dispose();
            BoardPictureBox.Image = (Bitmap)bmp.Clone();
        }

        private void GliderButton_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.GliderPattern);
        }

        private void RowButton_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.RowPattern);
        }

        private void SpaceshipButton_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.SpaceshipPattern);
        }

        private void GliderGunButton_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.GliderGunPattern);
        }

        private void Period15Button_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.Period15Pattern);
        }

        private void PulsarButton_Click(object sender, EventArgs e)
        {
            Restart(GUI.DefaultPatterns.PulsarPattern);
        }
    }
}
