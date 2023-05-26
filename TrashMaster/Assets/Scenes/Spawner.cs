using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public List<GameObject> spawnPrefabs = new List<GameObject>();
    public List<Transform> spawnPoints = new List<Transform>();
    public float spawnInterval = 2f;

    private float spawnTimer;

    private void Start()
    {
        spawnTimer = spawnInterval;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0f)
        {
            SpawnObject();
            spawnTimer = spawnInterval;
        }
    }

    private void SpawnObject()
    {
        if (spawnPoints.Count == 0 || spawnPrefabs.Count == 0)
            return;

        int randomPrefabIndex = Random.Range(0, spawnPrefabs.Count);
        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Count);

        GameObject spawnPrefab = spawnPrefabs[randomPrefabIndex];
        Transform spawnPoint = spawnPoints[randomSpawnPointIndex];

        Instantiate(spawnPrefab, spawnPoint.position, Quaternion.identity);
    }
}
