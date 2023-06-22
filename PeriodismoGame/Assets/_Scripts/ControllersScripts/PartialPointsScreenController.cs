using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartialPointsScreenController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    private int CategoryCount;
    

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
        if(obj == GameManager.GameState.PartialWinner)
        {
            UI.SetActive(true);
        }
        else UI.SetActive(false);
    }

    public void SetNextCategory()
    {
        CategoryCount += 1;

        switch (CategoryCount)
        {
            case 1:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category2);
                break;
            case 2:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category3);
                break;
            case 3:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Category4);
                break;
            case 4:
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Winner);
                break;

        }
    }

    
}
