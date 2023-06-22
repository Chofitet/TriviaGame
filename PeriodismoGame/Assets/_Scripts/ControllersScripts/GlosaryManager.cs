using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlosaryManager : MonoBehaviour
{

    public static List<string> Glosary = new List<string>();

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
            DeleteGlosary();
        }
    }

    public void AddGlosary(string G)
    {
        Glosary.Add(G);
    } 

    public void DeleteGlosary ()
    {
        Glosary.Clear();
    }

}
