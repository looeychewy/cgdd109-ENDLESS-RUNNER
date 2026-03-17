using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Separate camMovement script to differentiate cloud and ground speed

public class CloudMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
