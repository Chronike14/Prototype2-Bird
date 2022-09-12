using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class MoveForward : MonoBehaviour
{

    System.Random randSpeed = new System.Random();

    public float speed = 10.0f;

    float[] speeds = { 3f, 4f, 5f};

    public int randSpeedNum;

    // Start is called before the first frame update
    void Start()
    {
        randSpeedNum = randSpeed.Next(0, 3);
        speed = speeds[randSpeedNum];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    { 
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
