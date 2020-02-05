using System.Collections;
using System.Collections.Generic;
using UnityEngine;


struct BlockTag
{
    public const string Breakable = "Breakable";
    public const string Unbreakable = "Unbreakable";
}


public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;
    [SerializeField] GameObject sparklesVFX;
    [SerializeField] int maxHits;
    [SerializeField] int timesHit;

    private Level level;
    private GameSession gameSession;


    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        CountBreakableBlocks();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (CompareTag(BlockTag.Breakable))
            HandleHit();
    }


    private void HandleHit()
    {
        timesHit++;
        if (timesHit >= maxHits)
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


    private void CountBreakableBlocks()
    {
        level = FindObjectOfType<Level>();
        if (CompareTag(BlockTag.Breakable))
            level.AddBlock();
    }
}
