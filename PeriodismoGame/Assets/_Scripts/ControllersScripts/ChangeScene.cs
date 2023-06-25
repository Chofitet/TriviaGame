using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class ChangeScene : MonoBehaviour
{
    [SerializeField] string SceneToChange;
    [SerializeField] GameManager.GameState gameState;
    [SerializeField] float pitch = 0.95f;

    private void OnEnable()
    {
        gameObject.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        gameObject.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
    }
    public void SceneChange()
    {
        SoundManager.SM.ButtonSound(pitch);
        Invoke("ColdDown", 0.2f);
    }

    public void ChangeGameState()
    {
        GameManager.gameManager.UpdateGameState(gameState);
    }

    void ColdDown()
    {
        SceneManager.LoadScene(SceneToChange);
    }

}
