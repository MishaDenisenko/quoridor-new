using _Scripts.Model.PlayerLogic;
using _Scripts.View.UserInterface;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.View {
    public sealed class VictoryManager : MonoBehaviour {
        [Header("References")]
        [SerializeField] private ViewCommunication _view;

        [Header("Objects")] 
        [SerializeField] private GameObject _container;
        [SerializeField] private TMP_Text _winnerText;

        [Header("Settings")]
        [SerializeField] private Vector3 _startPosition;
        [SerializeField] private Vector3 _finishPosition;
        [SerializeField] private float _speed;
        
        public void ShowVictory(PlayerColor winner) {
            _view.CellHighlighter.UnhighlightAllCells();
            
            HandleUiElements();
            
            _winnerText.text = winner + " player won!";
        }

        private void HandleUiElements() {
            _container.SetActive(true);

            StartCoroutine(ObjectMover.Move(_winnerText.transform, _startPosition, _finishPosition, _speed));
        }
    }
}