using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentQController : MonoBehaviour
{
    [SerializeField] GameObject QParent;

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
        if(obj == GameManager.GameState.TriviaGame)
        {
            QParent.SetActive(true);
        }
        else
        {
            QuestionInstanciate[] Questions = QParent.GetComponentsInChildren<QuestionInstanciate>();
            if (Questions == null) return;
            foreach (QuestionInstanciate q in Questions)
            {
                Destroy(q.gameObject);
            }
            QParent.SetActive(false);
        }
            
    }
}
