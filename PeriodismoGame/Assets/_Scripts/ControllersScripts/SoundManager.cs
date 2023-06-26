using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundManager : MonoBehaviour
{
    [Header("Prefabs sonidos")]

    public GameObject buttonSound;
    public GameObject correctSound;
    public GameObject counterSound;
    public GameObject winSound;

    public static SoundManager SM { get; private set; }
    private void Awake()
    {
        
        if (SM != null && SM != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            SM = this;
            DontDestroyOnLoad(SM);
        }
        
    }

    void NewSound(GameObject prefabs, Vector3 posición, float duración = 5f, float ModificarPitch = 1)
    {

        GameObject obj = Instantiate(prefabs, posición, Quaternion.identity);
        obj.GetComponent<AudioSource>().pitch = ModificarPitch;
        Destroy(obj, duración);

    }
    public void ButtonSound(float ModificarPitch)
    {
        NewSound(buttonSound, Camera.main.transform.position, 5 , ModificarPitch);
    }
    public void CorrectSound()
    {
        NewSound(correctSound, Camera.main.transform.position, 5);
    }
    public void CounterSound()
    {
        NewSound(counterSound, Camera.main.transform.position, 10);
    }
    public void WinSound()
    {
        NewSound(winSound, Camera.main.transform.position, 10);
    }

}
