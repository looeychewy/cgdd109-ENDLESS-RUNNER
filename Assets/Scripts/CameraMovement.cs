using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
