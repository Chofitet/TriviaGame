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
        if (PI == null)
        {
            PI = GetComponent<WinnerSelector>().WinnerPlayer();
            if (PI == null)
            {
                GameManager.gameManager.UpdateGameState(GameManager.GameState.Tie);
                return;
            }
        }
        Imageplayer.sprite = PI.GetAvatar();
        Nameplayer.text = PI.GetName();
        if (Pointsplayer == null) return;
        Pointsplayer.text = PI.GetPoints().ToString("F0");
    }
}
