using _Scripts.Model.Common;
using UnityEngine;

namespace _Scripts.Model.Cells {
    public sealed class CellButton : Button {
        public override void NotifyController() {
            _controller.MoveToCell(_coordinates);
        }
    }
}