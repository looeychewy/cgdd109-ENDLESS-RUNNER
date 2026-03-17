using System.Collections;
using UnityEngine;

// Hitting obstacle cam shake effect
public class CameraShake : MonoBehaviour
{
    public static CameraShake Instance;

    void Awake()
    {
        Instance = this;
    }

    public IEnumerator Shake(float duration = 0.3f, float magnitude = 0.1f)
    {
        Vector3 original = transform.position;
        float elapsed = 0f;

        while (elapsed < duration)
        {
            transform.position = original + (Vector3)Random.insideUnitCircle * magnitude;
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }
        transform.position = original;
    }
}