using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreensFlowManager : MonoBehaviour
{
    [SerializeField] GameObject gameScreen;
    [SerializeField] GameObject CounterScreen;
    [SerializeField] GameObject PartialPointsScreen;
    int CategoryCount = 5;
    public static ScreensFlowManager SFM { get; private set; }
    private void Awake()
    {
        if (SFM != null && SFM != this)
        {
            Destroy(this);
        }
        else
        {
            SFM = this;
        }
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
        
    }
    private void Start()
    {
        gameScreen.SetActive(false);
    }
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }
    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
       
    }

    public void d()
    {
        GameManager.gameManager.UpdateGameState(GameManager.GameState.TriviaGame);
    }

    public void EnableCounterScreen()
    {
        CounterScreen.SetActive(true);
        Invoke("EnableGameScreen", 3);
    }

    void EnableCounterScreenToEnd()
    {
        CounterScreen.SetActive(true);
        Invoke("EnablePartialPoints", 3);
    }

    void EnablePartialPoints()
    {
        CounterScreen.SetActive(false);
        PartialPointsScreen.SetActive(true);
    }
    private void EnableGameScreen()
    {
        gameScreen.SetActive(true);
        CounterScreen.SetActive(false);
        Invoke("EnableCounterScreenToEnd", 5);
    }

    public void RestartGameFlow()
    {
        EnableCategoryScreen();
    }

    void EnableCategoryScreen()
    {
        CategoryCount += 1;

        switch (CategoryCount)
        {
            case 0:
                break;
            case 1:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category1);
                break;
            case 2:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category2);
                break;
            case 3:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category3);
                break;
        }
        PartialPointsScreen.SetActive(false);
    }
}
