using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuController : MonoBehaviour
{
    [SerializeField] GameObject UIPause;

    public void OnPause()
    {
        UIPause.SetActive(true);
    }
    public void ScapePause()
    {
        UIPause.SetActive(false);
    }
}
