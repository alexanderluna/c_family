using System;
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
    [SerializeField] Sprite[] hitSprites;
    [SerializeField] int timesHit;

    private Level level;
    private GameSession gameSession;
    private SpriteRenderer spriteRenderer;


    private void Start()
    {
        gameSession = FindObjectOfType<GameSession>();
        spriteRenderer = GetComponent<SpriteRenderer>();
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
        int maxHits = hitSprites.Length + 1;
        if (timesHit >= maxHits)
            DestroyBlock();
        else
            ShowNextSprite();
    }


    private void ShowNextSprite()
    {
        int spriteIndex = timesHit - 1;
        if (hitSprites[spriteIndex] != null)
            spriteRenderer.sprite = hitSprites[spriteIndex];
        else
            Debug.LogError(gameObject.name + " is missing Sprite");
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
