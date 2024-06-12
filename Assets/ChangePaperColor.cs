using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangePaperColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject paperImage;


    public void OnPointerDown(PointerEventData eventData)
    {
        paperImage.GetComponent<Image>().color = new Color32(183, 180, 0, 255);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        paperImage.GetComponent<Image>().color = new Color32(255, 250, 0, 255);
    }
}