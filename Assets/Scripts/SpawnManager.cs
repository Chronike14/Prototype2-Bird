using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    public GameObject tree;
    private float startDelay = 1;
    public float spawnInterval = 1.5f;
    private Vector2 screenBounds;
    private int clock = 0;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        clock ++;
    }

    void SpawnRandomObstacle()
    {
        if (clock <= 1800)
            {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

            GameObject a = Instantiate(obstaclePrefabs[obstacleIndex]) as GameObject;
            a.transform.position = new Vector2(screenBounds.x * 2, Random.Range(-screenBounds.y, screenBounds.y));
            }
            else if (clock >= 1800)
                {
                GameObject b = Instantiate(tree) as GameObject;
                b.transform.position = new Vector2(screenBounds.x * 4, Random.Range(-screenBounds.y, screenBounds.y));
                }
        }
    
}
