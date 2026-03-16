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

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));

            float y = Random.Range(minY, maxY);
            GameObject prefab = interactablePrefabs[Random.Range(0, interactablePrefabs.Length)];
            Instantiate(prefab, new Vector3(spawnX, y, 0), Quaternion.identity);
        }
    }
}