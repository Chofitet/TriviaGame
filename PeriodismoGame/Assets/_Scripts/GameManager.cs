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
        UpdateGameState(GameState.MainMenu);
    }
    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.MainMenu:
                break;
            case GameState.PauseMenu:
                break;
            case GameState.CustomizePlayers:
                break;
            case GameState.Instructions:
                break;
            case GameState.SortPlayers:
                break;
            case GameState.TriviaGame:
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
    public void CHangwe()
    {
        UpdateGameState(GameState.TriviaGame);
    }
    public enum GameState
    {
        MainMenu,
        PauseMenu,
        CustomizePlayers,
        Instructions,
        SortPlayers,
        TriviaGame,
        PartialWinner,
        Glosary,
        Winner,
    }
}