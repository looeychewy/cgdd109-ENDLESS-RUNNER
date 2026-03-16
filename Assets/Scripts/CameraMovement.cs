using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    public float Speed => speed;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
