using System.Collections.Generic;
using System.Linq;
using _Scripts.View;
using _Scripts.View.Walls;
using UnityEngine;

namespace _Scripts.Model.Walls {
    public sealed class WallController : MonoBehaviour {
        [SerializeField] private ViewCommunication _view;

        private List<WallVisual> _placedWalls;

        private void Awake() {
            _placedWalls = new List<WallVisual>();
        }

        public void PlaceWall(Coordinates wallCoordinates) {
            WallVisual wall = _view.WallStorage[wallCoordinates];
            
            wall.HandlePlace();
            _placedWalls.Add(wall);

            DisableAllWalls();
        }
        public void EnableWalls(IEnumerable<Coordinates> wallCoordinates) {
            DisableAllWalls();
            
            foreach (Coordinates wallCoordinate in wallCoordinates) {
                WallVisual wall = _view.WallStorage[wallCoordinate];
                wall.Enable();
            }
        }

        private void DisableAllWalls() {
            foreach (WallVisual wall in _view.WallStorage.Except(_placedWalls)) {
                wall.Disable();
            }
        }
    }
}