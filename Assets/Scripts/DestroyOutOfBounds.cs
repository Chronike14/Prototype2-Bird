using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{

    public Camera MainCamera;
    private Vector2 screenBounds;
    private float leftSide;
    
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = MainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, MainCamera.transform.position.z));
        leftSide = screenBounds.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < leftSide - 12.0)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
