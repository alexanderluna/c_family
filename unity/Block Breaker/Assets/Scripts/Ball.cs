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
    private Rigidbody2D rigidBody;
    private AudioSource audioSource;


    private void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
        rigidBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
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
            rigidBody.velocity = new Vector2(
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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (hasStarted)
        {
            audioSource.Play();
        }
    }
}
