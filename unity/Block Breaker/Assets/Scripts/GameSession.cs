using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    [Range(0.1f, 10f)][SerializeField] float gameSpeed = 1f;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int pointsPerBlockDestroyed = 64;
    [SerializeField] int currentScore = 0;
    [SerializeField] bool autoPlayIsEnabled = false;


    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }


    private void Update()
    {
        Time.timeScale = gameSpeed;
    }


    public void ResetGameStatus()
    {
        Destroy(gameObject);
    }


    public void AddScore()
    {
        currentScore += pointsPerBlockDestroyed;
        scoreText.text = currentScore.ToString();
    }


    public bool AutoPlayIsEnabled()
    {
        return autoPlayIsEnabled;
    }
}
