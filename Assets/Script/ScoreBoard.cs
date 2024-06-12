using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public Text timeText;
    public Text scoreText;

    int second = 0;
    int minute = 0;
    int hour   = 0;
    public float time = 0.0f;
    public string stringOfTime;


    void Start()
    {
        timeText.text  = string.Format("시간: 00 : 00 : 00");
        scoreText.text = string.Format("점수: 0");
    }

    void Update()
    {
        time += Time.deltaTime;

        second =    (int)time % 60;
        minute =  ( (int)time / 60) % 60;
        hour   = (( (int)time / 60) / 60) % 12;

        string s = second.ToString().PadLeft(2, '0');
        string m = minute.ToString().PadLeft(2, '0');
        string h = hour.ToString().PadLeft(2, '0');

        stringOfTime   = string.Format("{0} : {1} : {2}", h, m, s);
        timeText.text  = string.Format("시간: {0}", stringOfTime);
        scoreText.text = string.Format("점수: {0}", GameObject.Find("GameScreen").GetComponent<HandButton>().score);

        //if (Time.timeScale == 0)
        //{
        //    finalTime = time;
        //    finalScore = GameObject.Find("GameScreen").GetComponent<HandButton>().score;

        //    이 코드를 사용하면 TouchLine -> SaveRecord -> ScroeBoard 순서로 실행 돼서 최고 기록 갱신이 안 됨.
        //    (아직 이유 못 찾음)
        //}
    }
}