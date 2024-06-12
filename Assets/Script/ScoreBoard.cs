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
        timeText.text  = string.Format("�ð�: 00 : 00 : 00");
        scoreText.text = string.Format("����: 0");
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
        timeText.text  = string.Format("�ð�: {0}", stringOfTime);
        scoreText.text = string.Format("����: {0}", GameObject.Find("GameScreen").GetComponent<HandButton>().score);

        //if (Time.timeScale == 0)
        //{
        //    finalTime = time;
        //    finalScore = GameObject.Find("GameScreen").GetComponent<HandButton>().score;

        //    �� �ڵ带 ����ϸ� TouchLine -> SaveRecord -> ScroeBoard ������ ���� �ż� �ְ� ��� ������ �� ��.
        //    (���� ���� �� ã��)
        //}
    }
}