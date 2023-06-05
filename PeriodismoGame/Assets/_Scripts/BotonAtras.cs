using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonAtras : MonoBehaviour
{

    public void VolverAtras()
    {
        SceneManager.LoadScene("Menu");
    }

    
}
