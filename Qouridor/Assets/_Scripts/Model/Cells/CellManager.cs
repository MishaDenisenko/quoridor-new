using UnityEngine;

namespace _Scripts.Model.Cells {
    public sealed class CellsManager {
        public const int AmountOfRows = 9;
        public const int AmountOfColumns = 9;
        
        private readonly ModelCommunication _model;

        public Cell[,] Cells { get; }

        public CellsManager(ModelCommunication model) {
            _model = model;
            
            Cells = new Cell[AmountOfRows, AmountOfColumns];
            
            InitializeCellField();
        }

        public Cell this[Coordinates cellCoordinates] => Cells[cellCoordinates.Row, cellCoordinates.Column];

        public bool CellIsBusy(Coordinates cell) {
            return Cells[cell.Row, cell.Column].IsBusy;
        }
        public bool CellIsReal(Coordinates cell) {
            return cell.Row < AmountOfRows
                   & cell.Row >= 0
                   & cell.Column < AmountOfColumns
                   & cell.Column >= 0; 
        }
        public bool WallIsBetweenCells(Coordinates firstCell, Coordinates secondCell) {
            CellPair cellPair = new CellPair(firstCell, secondCell);
            
            foreach (CellPair blockedCellPair in _model.WallsManager.BlockedCellPairs) {
                if (blockedCellPair.Equals(cellPair)) return true;
            }

            return false;
        }
        
        private void InitializeCellField() {
            for (int i = 0; i < AmountOfRows; i++) {
                for (int j = 0; j < AmountOfColumns; j++) {
                    Cells[i, j] = new Cell();
                }
            }
        }
    }
}