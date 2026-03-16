using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundLoop : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float resetX = 20f;
    [SerializeField] float destroyX = -20f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < destroyX)
        {
            transform.position = new Vector3(resetX, transform.position.y, transform.position.z);
        }
    }
}
