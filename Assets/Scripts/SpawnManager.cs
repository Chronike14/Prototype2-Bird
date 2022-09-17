using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    public GameObject tree;
    public Camera MainCamera;
    public int seconds = 20;
    private float startDelay = 0.5f;
    public float spawnInterval = 1.0f;
    private Vector2 screenBounds;
    private int clock = 0;

    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        clock ++;
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
    }

    void SpawnRandomObstacle()
    {
        if (clock <= seconds * 60)
            {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

            GameObject a = Instantiate(obstaclePrefabs[obstacleIndex]) as GameObject;
            a.transform.position = new Vector2(screenBounds.x + 4, Random.Range(-screenBounds.y, screenBounds.y));
            }
            else if (clock >= seconds * 60)
                {
                
                GameObject b = Instantiate(tree) as GameObject;
                b.transform.position = new Vector2(screenBounds.x + 4, screenBounds.y - 6);
                }
        }
    
}
