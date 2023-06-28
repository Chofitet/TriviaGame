using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartialPointsDisplay : MonoBehaviour
{
    [SerializeField] GameSceneController GSC;
    [SerializeField] int PlayerNumber;
    TMP_Text text;

    private void OnEnable()
    {
        text = GetComponent<TMP_Text>();
        text.text = GSC.GetPartialPlayersPoints(PlayerNumber).ToString("F0");
    }
}
