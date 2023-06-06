using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterScriptController : MonoBehaviour
{
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
    }
    [SerializeField] GameObject UI;
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
