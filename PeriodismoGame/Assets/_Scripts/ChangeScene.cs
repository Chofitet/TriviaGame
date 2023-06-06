using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string SceneToChange;

    public void Change()
    {
        GameManager.gameManager.UpdateGameState(GameManager.GameState.Category1);
        SceneManager.LoadScene(SceneToChange);
        
    }

}
