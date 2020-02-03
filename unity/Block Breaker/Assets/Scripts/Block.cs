using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject sparklesVFX;

    private Level level;
    private GameSession gameSession;


    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        level = FindObjectOfType<Level>();
        level.AddBlock();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }


    private void DestroyBlock()
    {
        PlaySFX();
        Destroy(gameObject);
        TriggerSparklesVFX();
        level.RemoveBlock();
        gameSession.AddScore();
    }


    private void PlaySFX()
    {
        AudioSource.PlayClipAtPoint(
            breakSound,
            Camera.main.transform.position
        );
    }


    private void TriggerSparklesVFX()
    {
        GameObject sparkles = Instantiate(
            sparklesVFX,
            transform.position,
            transform.rotation
        );
        Destroy(sparkles, 1f);
    }
}
