using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public GameObject[] handShape;
    public Transform    spawnPoint;

    private float nowTime;
    public float makeTime;

    public List<GameObject> CloneList = new List<GameObject>();


    void Start()
    {
        makeTime = 0.5f;
        nowTime = Time.time;
    }

    void Update()
    {
        if (GameObject.Find("GameScreen").GetComponent<HandButton>().score >= 100)
        {
            makeTime = 0.416f;
        }

        if (Time.time - nowTime > makeTime)
        {
            nowTime = Time.time;

            int idx = Random.Range(0, 3);
            GameObject Clone = Instantiate(handShape[idx % 3], spawnPoint.position, Quaternion.identity);

            CloneList.Add(Clone);

            Vector3 moveDirection = Vector3.down;
            Clone.GetComponent<Movement2D>().Setup(moveDirection);
        }
    }
}