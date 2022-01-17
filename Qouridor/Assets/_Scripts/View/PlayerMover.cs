using System;
using _Scripts.Model.PlayerLogic;
using _Scripts.View.Cells;
using UnityEngine;

namespace _Scripts.View {
    public sealed class PlayerMover : MonoBehaviour {
        [Header("References")]
        [SerializeField] private ViewCommunication _view;
        
        [Header("Objects")]
        [SerializeField] private Transform _whitePlayer;
        [SerializeField] private Transform _blackPlayer;

        private Transform GetPlayer(PlayerColor playerColor) {
            return playerColor switch {
                PlayerColor.White => _whitePlayer,
                PlayerColor.Black => _blackPlayer,
                _ => throw new ArgumentOutOfRangeException(nameof(playerColor), playerColor, null)
            };
        }
        public void MovePlayerToCell(PlayerColor playerColor, Coordinates cellCoordinates) {
            Transform player = GetPlayer(playerColor);

            CellVisual cell = _view.CellStorage[cellCoordinates];
            Vector3 newPosition = cell.Position;
            player.position = newPosition;
            
        }
    }
}