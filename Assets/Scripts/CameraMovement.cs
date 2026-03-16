using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float Speed => InteractableSpawner.currentSpeed;

    void Update()
    {
        transform.position += Vector3.left * InteractableSpawner.currentSpeed * Time.deltaTime;
    }
}
