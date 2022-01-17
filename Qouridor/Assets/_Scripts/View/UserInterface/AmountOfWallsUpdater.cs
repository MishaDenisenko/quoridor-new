using System;
using System.Collections;
using System.Collections.Generic;
using _Scripts.Model.PlayerLogic;
using UnityEngine;
using UnityEngine.UI;

public sealed class AmountOfWallsUpdater : MonoBehaviour {
    [SerializeField] private Text _whitePlayerAmountOfWallsCounter;
    [SerializeField] private Text _blackPlayerAmountOfWallsCounter;

    public void UpdateCounter(Player player) {
        Text counter = player.Color switch {
            PlayerColor.White => _whitePlayerAmountOfWallsCounter,
            PlayerColor.Black => _blackPlayerAmountOfWallsCounter,
            _ => throw new ArgumentOutOfRangeException(nameof(player.Type), player.Type, null)
        };

        counter.text = player.AmountOfWalls.ToString();
    }
}
