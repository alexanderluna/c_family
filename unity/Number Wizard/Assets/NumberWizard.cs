using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{

    int min = 1;
    int max = 1000;
    int guess = 500;


    void Start()
    {
        StartGame();
    }


    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;

        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number between " + min + " and " + max);
        Debug.Log("Is it higher or lower than: " + guess + " ?");
        max += 1;
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKey(KeyCode.Return))
        {
            Debug.Log("I guessed it yay");
            StartGame();
        }
    }


    void NextGuess()
    {
        guess = (min + max) / 2;
        Debug.Log("It is higher or lower than: " + guess);
    }

}
