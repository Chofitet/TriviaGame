using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlosaryManager : MonoBehaviour
{
    List<string> Glosary = new List<string>();
    public void AddGlosary(string G)
    {
        Glosary.Add(G);
    } 

    public void DeleteGlosary ()
    {
        Glosary.Clear();
    }

    public void ShowGlosary()
    {
        foreach(string s in Glosary)
        {
            Debug.Log(s);
        }
    }
}
