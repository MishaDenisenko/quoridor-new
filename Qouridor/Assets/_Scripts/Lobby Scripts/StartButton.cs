using UnityEngine;

namespace _Scripts.Lobby_Scripts {
    public class StartButton : MonoBehaviour {
        public GameObject buttonContainer;
        
        public void StratButton() {
            gameObject.SetActive(false);
            buttonContainer.SetActive(true);
        }
    }
}