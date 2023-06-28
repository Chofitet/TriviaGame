using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomPoliticalPartySelector : MonoBehaviour
{
    [SerializeField] string[] PartyName;
    [SerializeField] Sprite[] PartyImage;
    [SerializeField] string[] PartyPersonName;

    [SerializeField] TMP_Text Nametxt;
    [SerializeField] TMP_Text NameParticaltxt;
    [SerializeField] TMP_Text PersonNametxt;
    [SerializeField] Image image;
    private void Start()
    {
        int i = Random.Range(0,PartyName.Length);
        NameParticaltxt.text = PartyName[i];
        Nametxt.text = "El partido " + PartyName[i] + " está buscando jefe de campaña";
        PersonNametxt.text = PartyPersonName[i];
        image.sprite = PartyImage[i];
    }
}
