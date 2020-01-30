using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 64;
    [SerializeField] int currentScore = 0;


    private void Update()
    {
        Time.timeScale = gameSpeed;
    }


    public void AddScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }
}
