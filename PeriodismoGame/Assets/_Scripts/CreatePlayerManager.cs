using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class CreatePlayerManager : MonoBehaviour
{
    [SerializeField] GameObject CustomisePlayerUI;
     GameObject UIinstate;
    [SerializeField] GameObject PlayerContein;
    [SerializeField] List<PlayersInfo> AllScriptablePlayers;
    int i;
    List<PlayersInfo> AUX;
    public void FillScriptableObject()
    {
        CusomisePlayerUIInfo UIScript = UIinstate.GetComponent<CusomisePlayerUIInfo>();
        AllScriptablePlayers[i].SetUp(UIScript.GetNamePlayer(), UIScript.GetAvatar());
        AUX.Add(AllScriptablePlayers[i]);
        i += 1;
    }
    public void InstanciateCustomisePlayerUI()
    {
        UIinstate = Instantiate(CustomisePlayerUI);
        UIinstate.transform.SetParent(PlayerContein.transform);
    }

    public List<PlayersInfo> GetScriptablesPlayers()
    {
        return AUX;
    }
}
