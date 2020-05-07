using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthUnits = 16f;

    private GameSession gameSession;
    private Ball ball;


    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        ball = FindObjectOfType<Ball>();
    }


    private void Update()
    {
        Vector2 paddlePosition = new Vector2(
            transform.position.x,
            transform.position.y
        );
        paddlePosition.x = Mathf.Clamp(GetXPosition(), minX, maxX);
        transform.position = paddlePosition;
    }


    private float GetXPosition()
    {
        if (gameSession.AutoPlayIsEnabled())
            return ball.transform.position.x;
        else
            return Input.mousePosition.x / Screen.width * screenWidthUnits;
    }
}
