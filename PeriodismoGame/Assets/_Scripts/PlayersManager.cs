using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersManager : MonoBehaviour
{
    List<PlayersInfo> players;
    public static PlayersManager PsM { get; private set; }
  
    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= sortPlayers;
    }
    private void Awake()
    {
        if (PsM != null && PsM != this)
        {
            Destroy(this);
        }
        else PsM = this;
        GameManager.OnGameStateChanged += sortPlayers;
    }

    public void AssingPlayer(PlayersInfo p)
    {
        players.Add(p);
    }

    public void sortPlayers(GameManager.GameState obj)
    {
        if(obj == GameManager.GameState.SortPlayers)
        {
            int numPlayers = players.Count;

            switch (numPlayers)
            {
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
            }
        }
        
    }

    void sadas()
    {
        int Machnum = 0;
        int exitWhile = 0;
        foreach(PlayersInfo p in players)
        {
          List<PlayersInfo> PlayersAux = players;
          PlayersInfo randomMach = players[Random.Range(0, players.Count)];
          while(p == randomMach)
          {
                int pl = Random.Range(0, PlayersAux.Count);
                randomMach = PlayersAux[pl];
                PlayersAux.RemoveAt(pl);
                exitWhile += 1;
                if (exitWhile > 20) return;
          }
            exitWhile = 0;
          while (p.MachGroup[0] == randomMach.MachGroup[0] || p.MachGroup[1] == randomMach.MachGroup[1] || p.MachGroup[0] == randomMach.MachGroup[1])
          {
                int pl = Random.Range(0, PlayersAux.Count);
                randomMach = PlayersAux[pl];
                PlayersAux.RemoveAt(pl);
          }
            exitWhile = 0;
            while (p.MachGroup[0] != p.MachGroup[1])
          {
                int pl = Random.Range(0, PlayersAux.Count);
                randomMach = PlayersAux[pl];
                PlayersAux.RemoveAt(pl);
          }
            exitWhile = 0;
            p.MachGroup.Add(Machnum);
            randomMach.MachGroup.Add(Machnum);
            Machnum += 1;
        }
    }

    public void payers()
    {
        sadas();

        foreach (PlayersInfo p in players)
        {
            Debug.Log(p._name + " : " + p.MachGroup[0] + " , " + p.MachGroup[1]);
        }
    }

}
