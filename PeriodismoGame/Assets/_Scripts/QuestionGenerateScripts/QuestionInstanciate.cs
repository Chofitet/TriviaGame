using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionInstanciate : MonoBehaviour
{
    [SerializeField] TMP_Text question;
    [SerializeField] TMP_Text A1;
    [SerializeField] TMP_Text A2;
    [SerializeField] GameObject A3;
    [SerializeField] GameObject A4;
    [SerializeField] GameObject Grid;
    [SerializeField] GameObject Rotator;
    
    public void CompleteText(List<string> Q, int numAnswers, bool isRotate)
    {
        question.text = Q[0];
        A1.text = Q[1];
        A2.text = Q[2];
        A3.GetComponentInChildren<TMP_Text>().text = Q[3];
        A4.GetComponentInChildren<TMP_Text>().text = Q[4];
        DeleteAnswere(numAnswers);
        if (isRotate) { SetUpScreen(); }
        ShuffleAnswers();
    }
    void DeleteAnswere(int i)
    {
        if (i == 2)
        {
            Destroy(A3.gameObject);
            Destroy(A4.gameObject);
        }
        else if (i == 3) Destroy(A4.gameObject);
    }

    void ShuffleAnswers()
    {
        List<int> indexes = new List<int>();
        List<Transform> items = new List<Transform>();
        for (int i = 0; i < Grid.transform.childCount; ++i)
        {
            indexes.Add(i);
            items.Add(Grid.transform.GetChild(i));
        }

        foreach (var item in items)
        {
            item.SetSiblingIndex(indexes[Random.Range(0, indexes.Count)]);
        }

    }

    void SetUpScreen()
    {
        Rotator.transform.rotation = Rotator.transform.rotation * Quaternion.Euler(0f, 0f, 180f);
    }

}
