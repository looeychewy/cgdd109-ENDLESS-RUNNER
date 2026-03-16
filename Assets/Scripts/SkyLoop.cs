using UnityEngine;

public class SkyLoop : MonoBehaviour
{
    [SerializeField] float resetX = 20f;
    [SerializeField] float destroyX = -20f;

    void Update()
    {
        if (transform.position.x < destroyX)
        {
            transform.position = new Vector3(resetX, transform.position.y, transform.position.z);
        }
    }
}
