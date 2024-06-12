using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ChangeRockColor : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject rockImage;

    
    public void OnPointerDown(PointerEventData eventData)
    {
        rockImage.GetComponent<Image>().color = new Color32(44, 82, 192, 255);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        rockImage.GetComponent<Image>().color = new Color32(66, 113, 253, 255);
    }
}