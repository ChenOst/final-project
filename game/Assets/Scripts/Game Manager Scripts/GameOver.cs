using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject _gameOverCanvas;

    public bool GameIsOver = false;

    public void EndGame()
    {
        GameIsOver = true;
        _gameOverCanvas.SetActive(true);
        DisableKeyboard.IsInputEnabled = false;
    }
}
