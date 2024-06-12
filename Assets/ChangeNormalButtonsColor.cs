using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeNormalButtonsColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject buttonImage;


    public void OnPointerDown(PointerEventData eventData)
    {
        buttonImage.GetComponent<Image>().color = new Color32(54, 54, 54, 255);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonImage.GetComponent<Image>().color = new Color32(56, 56, 56, 255);
    }
}
