using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject result;
    public AudioClip sfxAudioClip;

    float time;
    float nowTime;


    public void Start()
    {
        nowTime = Time.realtimeSinceStartup;
        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void Update()
    {
        time = Time.realtimeSinceStartup - nowTime;

        if (time >= 0.5f)
        {
            result.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
