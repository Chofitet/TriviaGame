using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEditor;

public class CreatePlayerManager : MonoBehaviour
{
    [SerializeField] PlayersInfo player;
    [SerializeField] Image image;

    public void DataToScriptablesObjects()
    {
        //var player = ScriptableObject.CreateInstance<PlayersInfo>();
        Debug.Log(player);
        player.SetDirty();
        player.SetUp(GetComponentInChildren<TMP_InputField>().text.ToString(), image.sprite);
        player.RestartPoints();
    }


}
