using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] interactablePrefabs; 
    [SerializeField] float minInterval = 1.5f;
    [SerializeField] float maxInterval = 3f;
    [SerializeField] float spawnX = 12f;   
    [SerializeField] float minY = -1f;
    [SerializeField] float maxY = 2f;


    [Header("----------------- Difficulty Settings  -----------------")]
    public static float currentSpeed = 5f;
    [SerializeField] float initSpeed = 5f;
    [SerializeField] float maxSpeed = 10f;
    [SerializeField] float speedIncreaseRate = 0.1f;

    void Start()
    {
        currentSpeed = initSpeed;
        StartCoroutine(SpawnLoop());
    }

    void Update()
    {
        currentSpeed = Mathf.Min(currentSpeed + speedIncreaseRate * Time.deltaTime, maxSpeed);
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {   
            // lerp for smoother restart
            float interval = Mathf.Lerp(maxInterval, minInterval, currentSpeed / maxSpeed);
            yield return new WaitForSeconds(interval);

            float y = Random.Range(minY, maxY);
            GameObject prefab = interactablePrefabs[Random.Range(0, interactablePrefabs.Length)];
            Instantiate(prefab, new Vector3(spawnX, y, 0), Quaternion.identity);
        }
    }
}