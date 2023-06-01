using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class CreatePlayerManager : MonoBehaviour
{
    PlayersInfo newPlayer;
    [SerializeField] GameObject CustomisePlayerUI;
     GameObject UIinstate;
    [SerializeField] GameObject PlayerContein;

    public void FillScriptableObject()
    {
        newPlayer = ScriptableObject.CreateInstance<PlayersInfo>();
        CusomisePlayerUIInfo UIScript = UIinstate.GetComponent<CusomisePlayerUIInfo>();
        newPlayer.SetUp(UIScript.GetNamePlayer(), UIScript.GetAvatar());
        PlayersManager.PsM.AssingPlayer(newPlayer);
    }
    public void InstanciateCustomisePlayerUI()
    {
        UIinstate = Instantiate(CustomisePlayerUI);
        UIinstate.transform.SetParent(PlayerContein.transform);
    }

}
