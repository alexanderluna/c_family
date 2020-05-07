using UnityEngine;


public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    [SerializeField] float velocityX = 2f;
    [SerializeField] float velocityY = 20f;
    [SerializeField] AudioClip[] sounds;
    [SerializeField] float randomFactor = 0.2f;

    private Vector2 paddleToBallVector;
    private bool hasStarted = false;
    private Rigidbody2D rigidBody;
    private AudioSource audioSource;


    private void Start()
    {
        paddleToBallVector = transform.position - paddle.transform.position;
        rigidBody = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }


    private void Update()
    {
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 velocityTweak = new Vector2(
            Random.Range(0f, randomFactor),
            Random.Range(0f, randomFactor)
        );
        if (hasStarted)
        {
            AudioClip clip = sounds[Random.Range(0, sounds.Length)];
            audioSource.PlayOneShot(clip);
            rigidBody.velocity += velocityTweak;
        }
    }


    private void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.velocity = new Vector2(
                velocityX,
                velocityY
            );
            hasStarted = true;
        }
    }


    private void LockBallToPaddle()
    {
        Vector2 paddlePosition = new Vector2(
            paddle.transform.position.x,
            paddle.transform.position.y
        );
        transform.position = paddlePosition + paddleToBallVector;
    }
}
