using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeScissorsColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject scissorsImage;


    public void OnPointerDown(PointerEventData eventData)
    {
        scissorsImage.GetComponent<Image>().color = new Color32(197, 45, 40, 255);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        scissorsImage.GetComponent<Image>().color = new Color32(255, 27, 20, 255);
    }
}