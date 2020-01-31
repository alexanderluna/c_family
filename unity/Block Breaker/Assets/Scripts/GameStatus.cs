using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int pointsPerBlockDestroyed = 64;
    [SerializeField] int currentScore = 0;


    private void Start()
    {
        SetScoreText();   
    }


    private void Update()
    {
        Time.timeScale = gameSpeed;
    }


    private void SetScoreText()
    {
        scoreText.text = currentScore.ToString();
    }


    public void AddScore()
    {
        currentScore += pointsPerBlockDestroyed;
        SetScoreText();
    }
}
