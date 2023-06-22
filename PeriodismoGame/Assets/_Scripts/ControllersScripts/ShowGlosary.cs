using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGlosary : MonoBehaviour
{
    [SerializeField] GameObject UIGlosary;
    private void Start()
    {
        List<string> AuxList = GlosaryManager.Glosary;
        
        foreach(string s in AuxList)
        {
           GameObject UI = Instantiate(UIGlosary, transform);
           UI.GetComponent<SetGlosaryText>().SetText(s);
           UI.transform.SetParent(transform);

        }
    }
}
