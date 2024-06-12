using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BgmManager : MonoBehaviour
{
    public AudioSource bgm;
    public AudioMixer mixer;
    public Slider bgmSlider;


    void Start()
    {
        bgmSlider.value = PlayerPrefs.GetFloat("BgmVolume", 0.5f);
    }

    public void BgmVolume(float val)
    {
        mixer.SetFloat("BgmVolume", Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("BgmVolume", val);
    }

    public void BgmStop()
    {
        bgm.Stop();
    }

    public void BgmPause()
    {
        bgm.Pause();
    }

    public void BgmUnPause()
    {
        bgm.UnPause();
    }
}
