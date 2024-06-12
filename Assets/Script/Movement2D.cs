using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    private float moveSpeed;
    private Vector3 moveDirection;


    public void Setup(Vector3 direction)
    {
        moveDirection = direction;
    }

    void Start()
    {
        moveSpeed = 5.0f;
    }

    private void Update()
    {
        if (GameObject.Find("GameScreen").GetComponent<HandButton>().score >= 100)
        {
            moveSpeed = 6.0f;
        }

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}