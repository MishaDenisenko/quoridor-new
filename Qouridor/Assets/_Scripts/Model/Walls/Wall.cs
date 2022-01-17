using _Scripts.Model.Cells;
using UnityEngine;

namespace _Scripts.Model.Walls {
    public sealed class Wall {
        public CellPair[] BlockedCellPairs { get; }
        public Coordinates[] OverlappedWalls { get; }

        public Wall(CellPair[] blockedCellPairs, Coordinates[] overlappedWalls) {
            BlockedCellPairs = blockedCellPairs;
            OverlappedWalls = overlappedWalls;
        }
    }
}