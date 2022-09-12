using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private float spawnPosX = 12;
    private float spawnRangeY = 5;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomObstacle()
    {
        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        Vector2 spawnpos = new Vector2(spawnPosX, Random.Range(-spawnRangeY, spawnRangeY));
        Instantiate(obstaclePrefabs[obstacleIndex], spawnpos, obstaclePrefabs[obstacleIndex].transform.rotation);
    }
    
}
