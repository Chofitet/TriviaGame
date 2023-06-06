using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PartialPointsScreenController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    private int CategoryCount;
    [SerializeField] Slider slider;
    [SerializeField] PlayersInfo Play1;
    [SerializeField] PlayersInfo Play2;

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
            GetPartialPoints();
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
        }
    }

    void GetPartialPoints()
    { 
        if(slider.value > 50 && slider.value < 100)
        {
            Play1.AddPoints(slider.value - 50);
        }
        if(slider.value < 50 && slider.value > 0)
        {
            Play2.AddPoints((slider.value * -1) + 50);
        }

        if (slider.value >= 100)
        {
            Play1.AddPoints(100);
        }
        if (slider.value <= 0)
        {
            Play2.AddPoints(100);
        }

    }
}
