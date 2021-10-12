using System.Collections.Generic;
using System.Linq;

namespace Game_Of_Life.Domain
{
	public class Cell
	{

		// This boolean field indicates if the cell is alive or not
		private bool _alive;
		// This boolean field indicates if the cell will be alive or not in the next Step
		private bool _aliveNextStep;
		// This list contains the 8 neighbours of the current cell
		public readonly List<Cell> neighbours = new List<Cell>();

		//Getters and setters
        public bool Alive { get => _alive; set => _alive = value; }
        public bool AliveNextStep { get => _aliveNextStep; set => _aliveNextStep = value; }

        // Calculates if the cell will be alive or not in the next step
        public void CalculateNextLiveStatus()
        {
			// Any live cell with two or three live neighbours survives.
			// Any dead cell with three live neighbours becomes a live cell.
			// All other live cells die in the next generation. Similarly, all other dead cells stay dead.

			int neighboursAlive = neighbours.Where(n => n.Alive).Count();

			if (Alive)
				AliveNextStep = neighboursAlive == 2 || neighboursAlive == 3;
			else
				AliveNextStep = neighboursAlive == 3;
		}

		// Updates live status of the cell
		public void NextStep()
        {
			Alive = AliveNextStep;
        }
	}
}

