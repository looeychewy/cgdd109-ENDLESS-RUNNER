using UnityEngine;

public class ScrollAndDespawn : MonoBehaviour
{
    [SerializeField] float speed = 5f;  
    [SerializeField] float despawnX = -15f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < despawnX)
            gameObject.SetActive(false);
    }
}