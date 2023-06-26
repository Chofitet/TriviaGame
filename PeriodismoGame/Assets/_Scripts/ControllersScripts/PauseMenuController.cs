using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] GameObject UIPause;
    [SerializeField] GameObject UIPanel;

    public void OnPause()
    {
        UIPause.SetActive(true);
        UIPanel.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        UIPanel.transform.DOScale(new Vector3(1, 1, 1), 1f).SetEase(Ease.OutBack);
        
    }
    public void ScapePause()
    {
        UIPause.SetActive(false);
    }
}
