using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsUISetUp : MonoBehaviour
{
    [SerializeField] PlayersInfo PI;
    [SerializeField] TMP_Text Nameplayer;
    [SerializeField] TMP_Text Pointsplayer;
    [SerializeField] Image Imageplayer;

    private void OnEnable()
    {
        Nameplayer.text = PI.GetName();
        Pointsplayer.text = PI.GetPoints().ToString();
        Imageplayer.sprite = PI.GetAvatar();
    }
}
