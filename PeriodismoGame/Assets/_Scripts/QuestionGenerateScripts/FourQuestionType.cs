using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourQuestionType : MonoBehaviour
{
    [SerializeField] GameObject Parent;
    [SerializeField] GameObject QuestionsUI;
    public void ConstructUI(List<string> Q, int numQuestions, bool isRotate)
    {
            GameObject UI = Instantiate(QuestionsUI);
            UI.GetComponent<QuestionInstanciate>().CompleteText(Q, numQuestions, isRotate);
            UI.gameObject.transform.SetParent(Parent.transform);
    }
    
    
}
