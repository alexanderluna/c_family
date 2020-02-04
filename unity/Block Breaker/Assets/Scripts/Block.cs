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
            DestroyBlock();
    }


    private void CountBreakableBlocks()
    {
        level = FindObjectOfType<Level>();
        if (CompareTag(BlockTag.Breakable))
            level.AddBlock();
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
