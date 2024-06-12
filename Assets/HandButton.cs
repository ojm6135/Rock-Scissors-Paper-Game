using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandButton : MonoBehaviour
{
    public GameObject BackgroundRock;
    public GameObject BackgroundScissors;
    public GameObject BackgroundPaper;
    public GameObject option;
    public GameObject gameOver;

    public AudioClip sfxAudioClip;

    public int score = 0;


    public void OnClickRock()
    {
        RandomSpawn randomSpawn = GameObject.Find("SpawnPoint").GetComponent<RandomSpawn>();
        
        if (randomSpawn.CloneList.Count > 0)
        {
            if (randomSpawn.CloneList[0].name == "Scissors(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                ++score;
            }
            else if (randomSpawn.CloneList[0].name == "Rock(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                if (score > 0)
                {
                    --score;
                }
            }
            else if (randomSpawn.CloneList[0].name == "Paper(Clone)")
            {
                Time.timeScale = 0;

                gameOver.SetActive(true);
                gameOver.GetComponent<GameOver>().Start();
                gameOver.GetComponent<GameOver>().Update();

                GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmStop();
            }
        }

        BackgroundScissors.SetActive(false);
        BackgroundPaper.SetActive(false);
        BackgroundRock.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickScissors()
    {
        RandomSpawn randomSpawn = GameObject.Find("SpawnPoint").GetComponent<RandomSpawn>();

        if (randomSpawn.CloneList.Count > 0)
        {
            if (randomSpawn.CloneList[0].name == "Paper(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                ++score;
            }
            else if (randomSpawn.CloneList[0].name == "Scissors(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                if (score > 0)
                {
                    --score;
                }
            }
            else if (randomSpawn.CloneList[0].name == "Rock(Clone)")
            {
                Time.timeScale = 0;

                gameOver.SetActive(true);
                gameOver.GetComponent<GameOver>().Start();
                gameOver.GetComponent<GameOver>().Update();

                GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmStop();
            }
        }

        BackgroundRock.SetActive(false);
        BackgroundPaper.SetActive(false);
        BackgroundScissors.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }

    public void OnClickPaper()
    {
        RandomSpawn randomSpawn = GameObject.Find("SpawnPoint").GetComponent<RandomSpawn>();

        if (randomSpawn.CloneList.Count > 0)
        {
            if (randomSpawn.CloneList[0].name == "Rock(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                ++score;
            }
            else if (randomSpawn.CloneList[0].name == "Paper(Clone)")
            {
                Destroy(randomSpawn.CloneList[0]);
                randomSpawn.CloneList.RemoveAt(0);

                if (score > 0)
                {
                    --score;
                }
            }
            else if (randomSpawn.CloneList[0].name == "Scissors(Clone)")
            {
                Time.timeScale = 0;

                gameOver.SetActive(true);
                gameOver.GetComponent<GameOver>().Start();
                gameOver.GetComponent<GameOver>().Update();

                GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmStop();
            }
        }

        BackgroundRock.SetActive(false);
        BackgroundScissors.SetActive(false);
        BackgroundPaper.SetActive(true);

        SfxManager.instance.SfxPlay("Button", sfxAudioClip);
    }
}