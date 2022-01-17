using _Scripts.Model.Common;

namespace _Scripts.Model.Walls {
    public sealed class WallButton : Button {
        public override void NotifyController() {
            _controller.PlaceWall(_coordinates);
        }
    }
}