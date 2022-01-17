using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts.Lobby_Scripts {
    public class MainMenu : MonoBehaviour {
        private const int MainSceneId = 1;
        
        
        public void ExitButton() {
            Application.Quit();
        }
        public void ChooseGameMode(int gameMode) {
            GameModeTransmitter.GameMode = (GameMode) gameMode;
        }
    }
}
