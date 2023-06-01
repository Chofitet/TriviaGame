using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(menuName = "newPlayer", fileName = "Player")]
public class PlayersInfo : ScriptableObject
{
    public string _name = "defaul";
    int _points = 0;
     Sprite _avatar;
     public List<int> MachGroup;
    public void SetUp(string n, Sprite i)
    {
        _name = n;
        _avatar = i;
    }

    public void AddPoints(int p)
    {
       _points += p;
    }
}
