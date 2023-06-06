using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    
    public static GameManager gameManager { get; private set; }
    public static event Action<GameState> OnGameStateChanged;
    private void Awake()
    {
        if (gameManager != null && gameManager != this)
        {
            Destroy(this);
        }
        else
        {
            gameManager = this;
        }
    }
    private void Start()
    {
        UpdateGameState(GameState.Category1);
    }
    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.PauseMenu:
                break;
            case GameState.TriviaGame:
                break;
            case GameState.Category1:
                break;
            case GameState.Category2:
                break;
            case GameState.Category3:
                break;
            case GameState.PartialWinner:
                break;
            case GameState.Glosary:
                break;
            case GameState.Winner:
                break;
        }
        OnGameStateChanged?.Invoke(newState);

    }
    public enum GameState
    {
        PauseMenu,
        TriviaGame,
        PartialWinner,
        Glosary,
        Winner,
        Category1,
        Category2,
        Category3,
    }
}