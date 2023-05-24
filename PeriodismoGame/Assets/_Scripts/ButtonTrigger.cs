using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] float reloadtime;
    
    public void _Invoke()
    {
        Invoke("DeleteQuestionUI", reloadtime);
    }

    void DeleteQuestionUI ()
    {
        Destroy(this.gameObject);
    }
}
