using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TieScreenController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }

    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
        if (obj == GameManager.GameState.Tie)
        {
            SoundManager.SM.WinSound();
            UI.SetActive(true);
        }
        else UI.SetActive(false);
    }
}
