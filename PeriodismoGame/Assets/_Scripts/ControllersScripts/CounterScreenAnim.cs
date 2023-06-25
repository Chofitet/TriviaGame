using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CounterScreenAnim : MonoBehaviour
{
   [SerializeField] Sprite uno;
    [SerializeField] Sprite dos;
    [SerializeField] Sprite tres;
    Image image;

    private void OnEnable()
    {
        image = GetComponent<Image>();
        StartCoroutine(ChangeNumber());
    }

    IEnumerator ChangeNumber()
    {
        image.sprite = tres;
        Dotween();
        yield return new WaitForSeconds(1);
        image.sprite = dos;
        Dotween();
        yield return new WaitForSeconds(1);
        image.sprite = uno;
        Dotween();
    }

    void Dotween()
    {
        image.gameObject.transform.localScale = new Vector3(0, 0, 0);
        image.gameObject.transform.DOScale(new Vector3(1, 1, 1), 1).SetEase(Ease.InOutSine);
    }
}
