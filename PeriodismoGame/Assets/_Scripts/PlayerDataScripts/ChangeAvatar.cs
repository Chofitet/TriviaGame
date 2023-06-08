using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAvatar : MonoBehaviour
{
    [SerializeField] Sprite[] AvatarsImg;
    Image image;
    int i = 0;
    private void Start()
    {
        image = GetComponent<Image>();
    }
    
    public void Next()
    {
        i += 1;
        if (AvatarsImg.Length <= i) i = 0;
        Debug.Log(i);
        image.sprite = AvatarsImg[i];
    }

    public void Back()
    {
        i -= 1;
        Debug.Log(i);
        if (0 > i) i = AvatarsImg.Length - 1;
        image.sprite = AvatarsImg[i];
    }
}
