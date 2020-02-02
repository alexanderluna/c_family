using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    private Level level;
    private GameSession gameStatus;


    private void Start()
    {
        gameStatus = FindObjectOfType<GameSession>();
        level = FindObjectOfType<Level>();
        level.AddBlock();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }


    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(
            breakSound,
            Camera.main.transform.position
        );
        Destroy(gameObject);
        level.RemoveBlock();
        gameStatus.AddScore();
    }
}
