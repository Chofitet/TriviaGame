using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JsonReader : MonoBehaviour
{
    public TextAsset[] JsonEasyQuestions;
    [SerializeField] TMP_Text qText;
    [SerializeField] TMP_Text a1Text;
    [SerializeField] TMP_Text a2Text;
    [SerializeField] TMP_Text a3Text;
    [SerializeField] TMP_Text a4Text;

    public int a;

    private void Awake()
    {
        GameManager.OnGameStateChanged += GameManager_OnGameStateChanged;
    }
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManager_OnGameStateChanged;
    }
    void RefreshList(int i)
    {
        myQuestions = JsonUtility.FromJson<questionsList>(JsonEasyQuestions[i].text);
    }
    private void GameManager_OnGameStateChanged(GameManager.GameState obj)
    {
        if (obj == GameManager.GameState.Category1)
        {
            Debug.Log(obj);
            RefreshList(0);
        }
        if (obj == GameManager.GameState.Category2)
        {
            Debug.Log(obj);
            RefreshList(1);
        }
        if (obj == GameManager.GameState.Category3)
        {
            Debug.Log(obj);
            RefreshList(2);
        }
        if (obj == GameManager.GameState.Category4)
        {
            Debug.Log(obj);
            RefreshList(3);
        }
    }
    [System.Serializable]
    public class Questions
    {
        public string q;
        public string a1;
        public string a2;
        public string a3;
        public string a4;
        public string g1;
        public string g2;
        public string g3;
    }

    public class questionsList
    {
        public List<Questions> questions;
    }
    public questionsList myQuestions = new questionsList();

    public List<string> GetQuestionFromJson()
    {
        int i = Random.Range(0, myQuestions.questions.Count);
        List<string> Q = new List<string>();
        Q.Add(myQuestions.questions[i].q);
        Q.Add(myQuestions.questions[i].a1);
        Q.Add(myQuestions.questions[i].a2);
        Q.Add(myQuestions.questions[i].a3);
        Q.Add(myQuestions.questions[i].a4);
        Q.Add(myQuestions.questions[i].g1);
        Q.Add(myQuestions.questions[i].g2);
        Q.Add(myQuestions.questions[i].g3);
        myQuestions.questions.RemoveAt(i);
        return Q;
    }

    

}
