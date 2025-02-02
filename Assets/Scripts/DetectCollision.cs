using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            print("Scene restarted");
            Time.timeScale = 1f;
        }
    }
}
