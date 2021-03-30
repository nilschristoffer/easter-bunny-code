using System.Collections.Generic;
using System.Linq;

namespace EasterCodeBunny.Task1B
{
    public static class QueensPuzzle
    {
        public static IEnumerable<List<(int row, int col)>> PossibleQueenFormationSolutions(int boardSize, List<(int row, int col)> placedQueens = null)
        {
            placedQueens ??= new List<(int row, int col)>();

            // return board if all queens are placed
            if (placedQueens.Count == boardSize) return new List<List<(int row, int col)>> { placedQueens };

            var possibleQueensPlacements = new List<List<(int row, int col)>>();
            var row = placedQueens.Count();

            for (var col = 0; col < boardSize; col++)
            {
                // check if queen is already placed in same column
                if (placedQueens.Any(q => q.col == col)) continue;

                // check if queen is already placed in topleft-bottomright diagonal
                if (placedQueens.Any(q => q.col - q.row == col - row)) continue;

                // check if queen is already placed in bottomleft-topright diagonal
                if (placedQueens.Any(q => q.col + q.row == col + row)) continue;

                var newPossibleSolution = placedQueens.Select(q => q).Append((row, col)).ToList();

                possibleQueensPlacements.AddRange(PossibleQueenFormationSolutions(boardSize, newPossibleSolution));
            }

            return possibleQueensPlacements;
        }
    }
}
