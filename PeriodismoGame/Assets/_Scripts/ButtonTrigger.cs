using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
    [SerializeField] float reloadtime;
    [SerializeField] float points;
    [SerializeField] GameObject Rotator;
    [SerializeField] GameObject DiseablePanel;

    public void RigthAnswere()
    {
        Invoke("DeleteQuestionUI", reloadtime);
        SoundManager.SM.CorrectSound();
        AddPoints(true);
    }
    public void WrongAnswer()
    {
        Invoke("DeleteQuestionUI", reloadtime);
        AddPoints(false);
    }
    void DeleteQuestionUI ()
    {
        Destroy(this.gameObject);
    }

    void AddPoints(bool isRigth)
    {
        if (Rotator.transform.rotation == Quaternion.Euler(0f, 0f, 180f))
        {
            SliderPointsController.SPC.UpdateBar(-points, isRigth, true,reloadtime);
        }
        else
        {
            SliderPointsController.SPC.UpdateBar(points, isRigth, false,reloadtime);
        }
    }

}
