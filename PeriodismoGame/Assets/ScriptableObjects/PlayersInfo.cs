using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "newPlayer", fileName = "PlayersInfo")]
public class PlayersInfo : ScriptableObject
{
    public string _name;
    public float _points = 0;
    public Sprite _avatar;
    public void SetUp(string n, Sprite i)
    {
        _name = n;
        _avatar = i;
    }

    public float GetPoints()
    {
        return _points;
    }
    public Sprite GetAvatar()
    {
        return _avatar;
    }
    public string GetName()
    {
        return _name;
    }
    public void AddPoints(float p)
    {
       _points += p;
    }

    public void RestartPoints()
    {
        _points = 0;
    }
}
