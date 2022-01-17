
using System.Collections.Generic;
using _Scripts.Model.PlayerLogic;
using _Scripts.Model.Walls;
using _Scripts.View.Cells;
using _Scripts.View.Walls;
using UnityEngine;

namespace _Scripts.View {
    public sealed class ViewCommunication : MonoBehaviour, IView {
        [Header("Components")] 
        [SerializeField] private AmountOfWallsUpdater _amountOfWallsUpdater;
        [SerializeField] private PlayerMover _playerMover;
        [SerializeField] private VictoryManager _victoryManager;
        [SerializeField] private WallController _wallController;

        [SerializeField] private CellHighlighter _cellHighlighter;
        [SerializeField] private CellStorage _cellStorage;
        [SerializeField] private WallStorage _wallStorage;

        public CellHighlighter CellHighlighter => _cellHighlighter;
        public CellStorage CellStorage => _cellStorage;
        public WallStorage WallStorage => _wallStorage;

        private List<Coordinates> _cellsToHighlight;

        public void ShowAvailableMoves(IEnumerable<Coordinates> cells) {
            _cellsToHighlight = new List<Coordinates>();
            _cellsToHighlight.AddRange(cells);
        }
        public void ShowAvailableJumps(IEnumerable<Coordinates> jumps) {
            _cellsToHighlight.AddRange(jumps);
            _cellHighlighter.HighlightCells(_cellsToHighlight);
        }
        public void ShowAvailableWalls(IEnumerable<Coordinates> walls) {
            _wallController.EnableWalls(walls);
        }

        public void MovePlayerToCell(Player player, Coordinates cell) {
            _playerMover.MovePlayerToCell(player.Color, cell);
        }
        public void JumpPlayerToCell(Player player, Coordinates cell) {
            MovePlayerToCell(player, cell);
        }
        public void PlaceWall(Player player, Coordinates wall) {
            _wallController.PlaceWall(wall);
            _amountOfWallsUpdater.UpdateCounter(player);
        }

        public void EndGame(PlayerColor winner) {
            _victoryManager.ShowVictory(winner);
        }
    }
}

