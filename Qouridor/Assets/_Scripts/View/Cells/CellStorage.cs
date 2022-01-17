using _Scripts.Model.Cells;
using UnityEngine;

namespace _Scripts.View.Cells {
    public sealed class CellStorage : Storage<CellVisual> {
        protected override int AmountOfColumns => CellsManager.AmountOfColumns;
    }
}