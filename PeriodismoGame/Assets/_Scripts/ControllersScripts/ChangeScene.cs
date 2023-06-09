using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string SceneToChange;
    [SerializeField] GameManager.GameState gameState;

    public void SceneChange()
    {
        SceneManager.LoadScene(SceneToChange);
    }

    public void ChangeGameState()
    {
        GameManager.gameManager.UpdateGameState(gameState);
    }

}
