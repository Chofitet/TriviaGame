using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        yield return new WaitForSeconds(1);
        image.sprite = dos;
        yield return new WaitForSeconds(1);
        image.sprite = uno;
    }
}
