using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseButton : MonoBehaviour
{
    public GameObject option;
    public GameObject countDown;
    public AudioClip sfxAudioClip;
    public Text countText;

    int count;
    float nowTime;
    float time;


    public void OnClickPause()
    {
        Time.timeScale = 0;

        countDown.SetActive(false);
        option.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
        GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmPause();
    }

    public void OnClickCloseOption()
    {
        option.SetActive(false);
        countDown.SetActive(true);

        countDown.GetComponent<ResumeCountDown>().Start();
        countDown.GetComponent<ResumeCountDown>().Update();

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickGoToMain()
    {
        SceneManager.LoadScene("MainMenuScene");

        Time.timeScale = 1;

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
        GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmStop();
    }
}
