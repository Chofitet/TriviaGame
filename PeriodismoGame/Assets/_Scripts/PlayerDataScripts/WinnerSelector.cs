using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinnerSelector : MonoBehaviour
{
    [SerializeField] PlayersInfo P1;
    [SerializeField] PlayersInfo P2;

    public PlayersInfo WinnerPlayer()
    {
        if (P1.GetPoints() > P2.GetPoints())
        {
            return P1;
        }
        else if (P1.GetPoints() < P2.GetPoints())
        {
            return P2;
        }
        return null;
    }

}
