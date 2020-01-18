using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    private Level level;


    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.AddBlock();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(
            breakSound,
            Camera.main.transform.position
        );
        Destroy(gameObject);
        level.RemoveBlock();
    }
}
