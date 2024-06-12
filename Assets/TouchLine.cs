using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchLine : MonoBehaviour
{
    public GameObject gameOver;


    public void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;

        gameOver.SetActive(true);
        gameOver.GetComponent<GameOver>().Start();
        gameOver.GetComponent<GameOver>().Update();

        GameObject.Find("BgmManager").GetComponent<BgmManager>().BgmStop();
    }
}