using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    public void CargarNivel()
    {
        SceneManager.LoadScene("SeleccionarJugadores");
    }

}
