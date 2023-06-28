using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSceneController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] float gameTime;
    [SerializeField] PlayersInfo Play1;
    [SerializeField] PlayersInfo Play2;
    [SerializeField] Slider slider;
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
        if (GameManager.gameManager.GiveCurrentState() == GameManager.GameState.TriviaGame)
        {
            Debug.Log("counter" + slider.value);
            CounterScriptController.Counter.CallCounter();
        }
        yield return new WaitForSeconds(3);
        GetPartialPointsOtherWay();
        yield return new WaitForSeconds(0.3f);
        GameManager.gameManager.UpdateGameState(GameManager.GameState.PartialWinner);
    }

    float P1Partial;
    float P2Partial;
    public void GetPartialPoints()
    {
        P1Partial = 0;
        P2Partial = 0;
        if (slider.value > 50 && slider.value < 100)
        {
            P1Partial = slider.value;
            P2Partial = (slider.value - 100) * -1;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }
        if (slider.value < 50 && slider.value > 0)
        {
            P2Partial = (slider.value - 100) * -1;
            P1Partial = slider.value;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }
        if (slider.value == 50)
        {
            P1Partial = 50;
            P2Partial = 50;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }

        if (slider.value >= 100)
        {
            P1Partial = 200;
            Play1.AddPoints(P1Partial);
        }
        if (slider.value <= 0)
        {
            P2Partial = 200;
            Play2.AddPoints(P2Partial);
        }

        slider.value = 50;
    }

    public void GetPartialPointsOtherWay()
    {
        P1Partial = 0;
        P2Partial = 0;
        if (slider.value > 50 && slider.value < 100)
        {
            P1Partial = slider.value - 50;
            P2Partial = 0;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }
        if (slider.value < 50 && slider.value > 0)
        {
            P2Partial = (50 - slider.value);
            P1Partial = 0;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }
        if (slider.value == 50)
        {
            P1Partial = 0;
            P2Partial = 0;
            Play1.AddPoints(P1Partial);
            Play2.AddPoints(P2Partial);
        }

        if (slider.value >= 100)
        {
            P1Partial = 100;
            Play1.AddPoints(P1Partial);
           // CounterScriptController.Counter.notCounter();
        }
        if (slider.value <= 0)
        {
            P2Partial = 100;
            Play2.AddPoints(P2Partial);
           // CounterScriptController.Counter.notCounter();
        }

        slider.value = 50;
    }

    public float GetPartialPlayersPoints(int i)
    {
        if (i == 1)
        {
            return P1Partial;
        }
        else if (i == 2)
        {
            return P2Partial;
        }
        return 0;
    }
}
