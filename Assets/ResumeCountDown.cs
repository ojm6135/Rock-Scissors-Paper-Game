using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResumeCountDown : MonoBehaviour
{
    public GameObject background;
    public Text countText;

    int count;
    float time;
    float nowTime;


    public void Start()
    {
        count = 0;
        nowTime = Time.realtimeSinceStartup;
        background.SetActive(true);
    }

    public void Update()
    {
        time = Time.realtimeSinceStartup - nowTime;

        if ((int)time == count)
        {
            countText.text = (3 - count).ToString();
            count++;
        }

        if (count == 4)
        {
            countText.text = "";
            Time.timeScale = 1;

            gameObject.SetActive(false);
            background.SetActive(false);
            GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmUnPause();
        }
    }
}