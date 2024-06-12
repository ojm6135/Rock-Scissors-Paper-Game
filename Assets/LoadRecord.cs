using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadRecord : MonoBehaviour
{
    public Text bestTimeText;
    public Text bestScoreText;

    void Start()
    {
        bestTimeText.text  = PlayerPrefs.GetString("stringOfBestTime", "00 : 00 : 00");
        bestScoreText.text = PlayerPrefs.GetInt("bestScore").ToString();
    }
}
