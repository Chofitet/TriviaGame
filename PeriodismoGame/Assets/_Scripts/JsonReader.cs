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

    [System.Serializable]
    public class questionsList
    {
        public List<Questions> questions;
    }
    public questionsList myQuestions = new questionsList();

    private void Start()
    {
        myQuestions = JsonUtility.FromJson<questionsList>(JsonEasyQuestions.text);
        reload();
    }

    public void reload()
    {
        int i = Random.Range(0, myQuestions.questions.Count);
        qText.text = myQuestions.questions[i].q;
        a1Text.text = myQuestions.questions[i].a1;
        a2Text.text = myQuestions.questions[i].a2;
        a3Text.text = myQuestions.questions[i].a3;
        a4Text.text = myQuestions.questions[i].a4;
        myQuestions.questions.RemoveAt(i);
    }

}
