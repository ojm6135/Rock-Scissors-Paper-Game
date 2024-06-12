using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderSetting : MonoBehaviour
{
    public Slider bgmSlider;
    Slider sfxSlider;


    private void Awake()
    {
        //Debug.Log("!");
        //Debug.Log(bgmSlider.value);
        //bgmSlider.value = PlayerPrefs.GetFloat("BgmVolume", 0.5f);
        //SoundManager.instance.mixer.SetFloat("BgmVolume", Mathf.Log10(bgmSlider.value) * 20);
    }
}