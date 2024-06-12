using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveRecord : MonoBehaviour
{  
    void Start()
    {
        ScoreBoard scoreBoard = GameObject.Find("GameScreen").GetComponent<ScoreBoard>();
        HandButton handButton = GameObject.Find("GameScreen").GetComponent<HandButton>();

        if (handButton.score > PlayerPrefs.GetInt("bestScore", -1))
        {
            PlayerPrefs.SetInt("bestScore", handButton.score);
            PlayerPrefs.SetFloat("bestTime", scoreBoard.time);
            PlayerPrefs.SetString("stringOfBestTime", scoreBoard.stringOfTime);

            PlayerPrefs.Save();
        }
        else if (handButton.score == PlayerPrefs.GetInt("bestScore"))
        {
            if (scoreBoard.time < PlayerPrefs.GetFloat("bestTime"))
            {
                PlayerPrefs.SetInt("bestScore", handButton.score);
                PlayerPrefs.SetFloat("bestTime", scoreBoard.time);
                PlayerPrefs.SetString("stringOfBestTime", scoreBoard.stringOfTime);

                PlayerPrefs.Save();
            }
        }
    }
}
