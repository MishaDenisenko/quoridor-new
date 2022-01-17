using System.Collections;
using System.Collections.Generic;
using _Scripts.Model.PlayerLogic;
using UnityEngine;

public interface IView {
    void ShowAvailableMoves(IEnumerable<Coordinates> cells);
    void ShowAvailableJumps(IEnumerable<Coordinates> jumps);
    void ShowAvailableWalls(IEnumerable<Coordinates> walls);
        
    void MovePlayerToCell(Player player, Coordinates cell);
    void JumpPlayerToCell(Player player, Coordinates cell);
    void PlaceWall(Player player, Coordinates wall);

    void EndGame(PlayerColor winner);
}
