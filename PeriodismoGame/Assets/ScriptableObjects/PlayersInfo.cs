using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "newPlayer", fileName = "Player")]
public class PlayersInfo : ScriptableObject
{
    string _name;
    float _points = 0;
     Sprite _avatar;
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
