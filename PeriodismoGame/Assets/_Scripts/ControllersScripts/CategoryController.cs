using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CategoryController : MonoBehaviour
{
    [SerializeField] GameObject UI;
    [SerializeField] TMP_Text text;

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
        if (obj == GameManager.GameState.Category1)
        {
            EnableUI();
            text.text = "SALUD";
            StartCoroutine(Disenable());
        }
        if (obj == GameManager.GameState.Category2)
        {
            EnableUI();
            text.text = "EDUCACION";
            StartCoroutine(Disenable());
        }
        if (obj == GameManager.GameState.Category3)
        {
            EnableUI();
            text.text = "SEGURIDAD";
            StartCoroutine(Disenable());
        }
        if (obj == GameManager.GameState.Category4)
        {
            EnableUI();
            text.text = "GENERAL";
            StartCoroutine(Disenable());
        }
    }

    void EnableUI()
    {
        UI.SetActive(true);
    }
    IEnumerator Disenable()
    {
        yield return new WaitForSeconds(3);
        UI.SetActive(false);
        CounterScriptController.Counter.CallCounter();
        yield return new WaitForSeconds(3);
        GameManager.gameManager.UpdateGameState(GameManager.GameState.TriviaGame);
    }
}
