using _Scripts.Model.PlayerLogic;
using UnityEngine;

namespace _Scripts.Model {
    public interface IModel {
        void StartNewGame(PlayerType whitePlayer, PlayerType blackPlayer);
        void StopGame(GameStopType gameStopType);

        void MoveCurrentPlayerToCell(Coordinates cell);
        void JumpCurrentPlayerToCell(Coordinates cell);
        void PlaceCurrentPlayerWall(Coordinates wall);
    }
}