using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float velocityX = 2f;
    [SerializeField] float velocityY = 20f;

    private Vector2 paddleToBallVector;
    private bool hasStarted = false;


    private void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }


    private void Update()
    {
        if (!hasStarted) {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }


    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                velocityX,
                velocityY
            );
            hasStarted = true;
        }
    }


    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(
            paddle.transform.position.x,
            paddle.transform.position.y
        );

        transform.position = paddlePosition + paddleToBallVector;
    }
}
