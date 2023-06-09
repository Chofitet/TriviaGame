using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScriptController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    public static CounterScriptController Counter { get; private set; }
    private void Awake()
    {
        if (Counter != null && Counter != this)
        {
            Destroy(this);
        }
        else
        {
            Counter = this;
        }
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }

    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
        if (obj == GameManager.GameState.PartialWinner)
        {
            enableCounter();
        }
    }
    
    public void CallCounter()
    {
        UI.SetActive(true);
        Invoke("enableCounter", 3);
    }

   void enableCounter()
    {
        UI.SetActive(false);
    }
}
