using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CusomisePlayerUIInfo : MonoBehaviour
{
    [SerializeField] Button CreateButton;
    [SerializeField] Button DeleteButtom;
    [SerializeField] Image image;
    CreatePlayerManager CPM;

    private void Start()
    {
        CPM = FindObjectOfType<CreatePlayerManager>();
        AddButtonBehaviour();
    }
    public string GetNamePlayer()
    {
        return GetComponentInChildren<TMP_InputField>().text.ToString();
    }
    public Sprite GetAvatar()
    {
        return image.sprite;
    }

    void AddButtonBehaviour()
    {
        CreateButton.onClick.AddListener(CPM.FillScriptableObject);
        DeleteButtom.onClick.AddListener(Delete);
    }
    void Delete ()
    {
        Destroy(gameObject);
    }


    
}
