using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameResult : MonoBehaviour
{
    public Text resultTimeText;
    public Text resultScoreText;

    public AudioClip sfxAudioClip;


    void Start()
    {
        ScoreBoard scoreBoard = GameObject.Find("GameScreen").GetComponent<ScoreBoard>();
        HandButton handButton = GameObject.Find("GameScreen").GetComponent<HandButton>();

        resultTimeText.text  = scoreBoard.stringOfTime;
        resultScoreText.text = handButton.score.ToString();
    }

    public void OnClickGoToMain()
    {
        SceneManager.LoadScene("MainMenuScene");
        Time.timeScale = 1;

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickRetry()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }
}
