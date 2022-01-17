using System;
using UnityEngine;

namespace _Scripts.Model.Cells {
    public readonly struct CellPair {
        public readonly Coordinates FirstCell;
        public readonly Coordinates SecondCell;

        public CellPair(Coordinates firstCell, Coordinates secondCell) {
            FirstCell = firstCell;
            SecondCell = secondCell;
        }
        
        public Coordinates this[int index] {
            get {
                return index switch {
                    0 => FirstCell,
                    1 => SecondCell,
                    _ => throw new ArgumentOutOfRangeException()
                };
            }
        }

        public bool Equals(CellPair cellPair) {
            return FirstCell.Equals(cellPair.FirstCell) && SecondCell.Equals(cellPair.SecondCell)
                   || FirstCell.Equals(cellPair.SecondCell) && SecondCell.Equals(cellPair.FirstCell);
        }
        public bool Contains(Coordinates coordinates) {
            return FirstCell.Equals(coordinates) || SecondCell.Equals(coordinates);
        }
    }
}