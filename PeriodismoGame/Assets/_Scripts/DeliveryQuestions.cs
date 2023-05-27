using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryQuestions : MonoBehaviour
{
    JsonReader JR;
    FourQuestionType QType;
    [SerializeField] GlosaryManager GM;

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }

    private void Start()
    {
        JR = GetComponent<JsonReader>();
        QType = GetComponent<FourQuestionType>();
    }

    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
       if (obj == GameManager.GameState.TriviaGame)
        {
            GiveQuestion(true);

            GiveQuestion(false);
        }
    }

    public void GiveQuestion(bool isRotate)
    {
        var Q = JR.GetQuestionFromJson();
        if (Q[3] == "")
        {
            QType.ConstructUI(Q, 2, isRotate);
        }
        else if (Q[4] == "")
        {
            QType.ConstructUI(Q, 3, isRotate);
        }
        else
        {
            QType.ConstructUI(Q,4, isRotate);
        }

        if (Q[5] != null)
        {
            GM.AddGlosary(Q[5]);
        }
        if (Q[6] != null)
        {
            GM.AddGlosary(Q[6]);
        }
        if (Q[7] != null)
        {
            GM.AddGlosary(Q[7]);
        }
    }

}
