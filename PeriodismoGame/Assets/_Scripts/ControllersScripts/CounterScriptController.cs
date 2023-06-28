using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScriptController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    bool _notCounter;
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
        if(!_notCounter)
        {
            UI.SetActive(true);
            SoundManager.SM.CounterSound();
            Invoke("enableCounter", 3);
            _notCounter = false;
        }
    }

   public void enableCounter()
    {
        UI.SetActive(false);
    }

    public void notCounter()
    {
        _notCounter = true;
    }

}
