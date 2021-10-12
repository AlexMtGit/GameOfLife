using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.Domain
{
    public class Board
    {
        
        private Cell[,] _cells; // 2D array that represents cells grid
        private int _cellSize;  // Integer that represents cell size (in pixels)

        // Getters
        public Cell[,] Cells { get => _cells; }
        public int CellSize { get => _cellSize; }
        public int Columns { get => _cells.GetLength(0); }  // Grid's columns number
        public int Rows { get => _cells.GetLength(1); }     // Grid's rows number
        public int Width { get => Columns * CellSize; }     // Grid's width (in pixels)
        public int Height { get => Rows * CellSize; }       // Grid's height (in pixels)

        // Board builder.
        // The 4th parameter indicates if the edges are connected as if the board is folded.
        //      If it is false, the board is not folded and the edges are not taken into account.
        public Board(int width, int height, int cellSize, bool fold = true)
        {
            _cellSize = cellSize;

            _cells = new Cell[width / cellSize, height / cellSize];
            for (int x = 0; x < Columns; x++)
                for (int y = 0; y < Rows; y++)
                    Cells[x, y] = new Cell();

            InitializeNeighbours(fold);
        }

        // This method is responsible for properly establishing the neighbours of each cell
        private void InitializeNeighbours(bool fold)
        {
            for (int x = 0; x < Columns; x++)
            {
                for (int y = 0; y < Rows; y++)
                {
                    // Determining whether the cell is an edge or not
                    bool lE = (x == 0);
                    bool rE = (x == Columns - 1);
                    bool tE = (y == 0);
                    bool bE = (y == Rows - 1);
                    bool isEdge = lE | rE | tE | bE;

                    if ((fold == false) && isEdge)
                        continue;

                    int xL = lE ? Columns - 1 : x - 1;  // Left neighbour position
                    int xR = rE ? 0 : x + 1;            // Right neighbour position
                    int yT = tE ? Rows - 1 : y - 1;     // Top neighbour position
                    int yB = bE ? 0 : y + 1;            // Bottom neighbour position

                    // Adding the neightbour to the cell
                    Cells[x, y].neighbours.Add(Cells[xL, yT]);
                    Cells[x, y].neighbours.Add(Cells[x, yT]);
                    Cells[x, y].neighbours.Add(Cells[xR, yT]);
                    Cells[x, y].neighbours.Add(Cells[xL, y]);
                    Cells[x, y].neighbours.Add(Cells[xR, y]);
                    Cells[x, y].neighbours.Add(Cells[xL, yB]);
                    Cells[x, y].neighbours.Add(Cells[x, yB]);
                    Cells[x, y].neighbours.Add(Cells[xR, yB]);
                }
            }
        }

        // This method can be used to randomly initialise the cells of the board.
        // The number of live cells depends on the liveStep threshold.
        public void RandomlyDistribute(double liveStep)
        {
            Random random = new Random();

            foreach (var cell in Cells)
                cell.Alive = random.NextDouble() < liveStep;
        }

        // Updates the live status of all cells on the board
        public void NextStep()
        {
            foreach (var cell in Cells)
                cell.CalculateNextLiveStatus();
            foreach (var cell in Cells)
                cell.NextStep();
        }

    }
}
