using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeliveryQuestions : MonoBehaviour
{
    JsonReader JR;
    FourQuestionType QType;
    private void Start()
    {
        JR = GetComponent<JsonReader>();
        QType = GetComponent<FourQuestionType>();
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
    }
}
