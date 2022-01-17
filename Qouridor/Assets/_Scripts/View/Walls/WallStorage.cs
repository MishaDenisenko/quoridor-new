using _Scripts.Model.Walls;
using UnityEngine;

namespace _Scripts.View.Walls {
    public sealed class WallStorage : Storage<WallVisual> {
        protected override int AmountOfColumns => WallsManager.AmountOfColumns;
    }
}