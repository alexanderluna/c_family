using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int min = 1;
    [SerializeField] int max = 1000;
    [SerializeField] TextMeshProUGUI guessText;

    int guess = 500;


    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        NextGuess();
    }


    void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }


    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

}