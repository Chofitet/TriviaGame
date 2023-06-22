using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SetGlosaryText : MonoBehaviour
{
    [SerializeField] TMP_Text text;

    public void SetText(string s)
    {
        text.text = s;
    }
}
