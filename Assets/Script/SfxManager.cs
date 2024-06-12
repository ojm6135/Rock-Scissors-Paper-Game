using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SfxManager : MonoBehaviour
{
    public Slider sfxSlider;

    public AudioMixer mixer;


    public static SfxManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
    }

    private void Start()
    {
        sfxSlider.value = PlayerPrefs.GetFloat("SfxVolume", 0.5f);
    }

    public void SfxVolume(float val)
    {
        mixer.SetFloat("SfxVolume", Mathf.Log10(val) * 20);
        PlayerPrefs.SetFloat("SfxVolume", val);
    }

    public void SfxPlay(string sfxName, AudioClip sfx)
    {
        GameObject go = new GameObject(sfxName + "Sound");
        DontDestroyOnLoad(go);
        AudioSource audioSource = go.AddComponent<AudioSource>();
        audioSource.outputAudioMixerGroup = mixer.FindMatchingGroups("SFX")[0];
        audioSource.clip = sfx;
        audioSource.Play();

        Destroy(go, sfx.length);
    }
}