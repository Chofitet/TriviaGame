using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonInstrucciones : MonoBehaviour
{
    public void CargarNivel()
    {
        SceneManager.LoadScene("Instrucciones");
    }
}
