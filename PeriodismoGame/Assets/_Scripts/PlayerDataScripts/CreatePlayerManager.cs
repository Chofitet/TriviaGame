using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreatePlayerManager : MonoBehaviour
{
    [SerializeField] PlayersInfo player;
    [SerializeField] Image image;

    public void DataToScriptablesObjects()
    {
        player.SetUp(GetComponentInChildren<TMP_InputField>().text.ToString(), image.sprite);
        player.RestartPoints();
    }


}
