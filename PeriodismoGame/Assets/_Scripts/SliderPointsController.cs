using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class SliderPointsController : MonoBehaviour
{
    public static SliderPointsController SPC { get; private set; }
    [SerializeField] DeliveryQuestions DQ;
    [SerializeField] PlayersInfo Play1;
    [SerializeField] PlayersInfo Play2;
    private void Awake()
    {
        if (SPC != null && SPC != this)
        {
            Destroy(this);
        }
        else
        {
            SPC = this;
        }
    }

    Slider slider;
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void UpdateBar(float x,bool isRight, bool isRotate, float reloadtime)
    {
        if (isRight)
        {
            float value = slider.value + x;
            slider.DOValue(value, 0.3f);
        }
        StartCoroutine(InvokeQuestion(isRotate, reloadtime));
    }

    public IEnumerator InvokeQuestion (bool b, float sec)
    {
        yield return new WaitForSeconds(sec);
        DQ.GiveQuestion(b);
    }

    private void Update()
    {
        if(slider.value >= 100)
        {
            GameManager.gameManager.UpdateGameState(GameManager.GameState.PartialWinner);
        }
        if(slider.value <= 0)
        {
            GameManager.gameManager.UpdateGameState(GameManager.GameState.PartialWinner);
        }
    }
}
