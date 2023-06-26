using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowCorrectAnswer : MonoBehaviour
{
    [SerializeField]Button btnCorrectAns;
    [SerializeField] float h;
    [SerializeField] float s;
    [SerializeField] float v;
    public void OnClick()
    {
      Debug.Log("enter");
      ColorBlock colors = btnCorrectAns.colors;
        colors.normalColor = Color.HSVToRGB(0.170f, 1f, 0.78f);
      btnCorrectAns.colors = colors;
    }
}
