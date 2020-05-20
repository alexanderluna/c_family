using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMove : MonoBehaviour
{
    [SerializeField] Vector2 cameraChange;
    [SerializeField] Vector3 playerChange;

    private CameraMovement cameraMovement;


    private void Start()
    {
        cameraMovement = Camera.main.GetComponent<CameraMovement>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            cameraMovement.ChangePosition(cameraChange, cameraChange);
            collision.transform.position += playerChange;
        }
    }
}
