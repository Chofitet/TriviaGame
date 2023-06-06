using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSceneController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] float gameTime;
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
        if (obj == GameManager.GameState.TriviaGame)
        {
            UI.SetActive(true);
            StartCoroutine(GameEnd());
        }
        else UI.SetActive(false);
    }

    IEnumerator GameEnd()
    {
        yield return new WaitForSeconds(gameTime);
        CounterScriptController.Counter.CallCounter();
        yield return new WaitForSeconds(3);
        GameManager.gameManager.UpdateGameState(GameManager.GameState.PartialWinner);
    }
}
