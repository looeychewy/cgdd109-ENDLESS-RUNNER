using UnityEngine;

public class CollectEffect : MonoBehaviour
{
    public static CollectEffect Instance;
    ParticleSystem ps;

    void Awake()
    {
        Instance = this;
        ps = GetComponent<ParticleSystem>();
    }

    public void Play(Vector3 position)
    {
        transform.position = position;
        gameObject.SetActive(true);
        ps.Play();
    }
}