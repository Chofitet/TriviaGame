using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JsonReader : MonoBehaviour
{
    public TextAsset JsonEasyQuestions;
    [SerializeField] TMP_Text qText;
    [SerializeField] TMP_Text a1Text;
    [SerializeField] TMP_Text a2Text;
    [SerializeField] TMP_Text a3Text;
    [SerializeField] TMP_Text a4Text;

    public int a;

    [System.Serializable]
    public class Questions
    {
        public string q;
        public string a1;
        public string a2;
        public string a3;
        public string a4;
    }

    public class questionsList
    {
        public List<Questions> questions;
    }
    public questionsList myQuestions = new questionsList();

    private void Start()
    {
        myQuestions = JsonUtility.FromJson<questionsList>(JsonEasyQuestions.text);
    }

    public List<string> GetQuestionFromJson()
    {
        int i = Random.Range(0, myQuestions.questions.Count);
        List<string> Q = new List<string>();
        Q.Add(myQuestions.questions[i].q);
        Q.Add(myQuestions.questions[i].a1);
        Q.Add(myQuestions.questions[i].a2);
        Q.Add(myQuestions.questions[i].a3);
        Q.Add(myQuestions.questions[i].a4);
        myQuestions.questions.RemoveAt(i);
        return Q;
    }

}
