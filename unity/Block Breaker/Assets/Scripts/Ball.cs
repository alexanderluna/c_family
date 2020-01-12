using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;

    Vector2 paddleToBallVector;


    void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
    }


    void Update()
    {
        Vector2 paddlePosition = new Vector2(
            paddle.transform.position.x,
            paddle.transform.position.y
        );

        transform.position = paddlePosition + paddleToBallVector;
    }
}
