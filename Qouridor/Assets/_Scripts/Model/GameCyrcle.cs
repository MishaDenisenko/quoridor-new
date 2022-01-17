using System;
using _Scripts.Model.PlayerLogic;
using UnityEngine;

namespace _Scripts.Model {
    public sealed class GameCycle {
        private readonly ModelCommunication _model;
        
        public event Action<PlayerType, PlayerType> GameStarted;
        public event Action GameStopped;

        public GameCycle(ModelCommunication model) {
            _model = model;
        }

        public void StartNewGame(PlayerType whitePlayer, PlayerType blackPlayer) {
            GameStarted?.Invoke(whitePlayer, blackPlayer);
        }
        public void StopGame() {
            _model.StopGame(GameStopType.Victory);
            GameStopped?.Invoke();
        }
    }
}