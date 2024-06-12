using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject rule;
    public GameObject option;

    public AudioClip sfxAudioClip;

    int ClickCount = 0;


    private void Start()
    {
        Screen.SetResolution(1080, 1920, true);
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("GameScene");

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickRule()
    {
        rule.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }
    
    public void OnClickCloseRule()
    {
        rule.SetActive(false);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickOption()
    {
        option.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickCloseOption()
    {
        option.SetActive(false);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    //뒤로가기 버튼으로 앱 종료
    private void ResetCount()
    {
        ClickCount = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ClickCount++;
            if (!IsInvoking("ResetCount"))
            {
                _ShowAndroidToastMessage();
                Invoke("ResetCount", 1.0f);
            }
        }
        else if (ClickCount == 2)
        {
            CancelInvoke("ResetCount");
            Application.Quit();
        }
    }

    private void _ShowAndroidToastMessage(string message = "한 번 더 누르시면 앱을 종료합니다.")
    {
        AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject unityActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");

        if (unityActivity != null)
        {
            AndroidJavaClass toastClass = new AndroidJavaClass("android.widget.Toast");
            unityActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
            {
                AndroidJavaObject toastObject = toastClass.CallStatic<AndroidJavaObject>("makeText", unityActivity, message, 0);
                toastObject.Call("show");
            }));
        }
    }
}