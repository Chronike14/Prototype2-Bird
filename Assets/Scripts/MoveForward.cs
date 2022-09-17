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

    bool eggTime;

    private Rigidbody2D _rbody;


    // Start is called before the first frame update
    void Start()
    {
        randSpeedNum = randSpeed.Next(0, 3);
        speed = speeds[randSpeedNum];
        if (gameObject.tag == "Tree") 
        {
            speed = 3f;
        }

        eggTime = false;

        _rbody = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D (Collider2D other) 
    { 
        if (other.gameObject.CompareTag("Player")) 
        {
            eggTime = true;
            print("egg time");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (gameObject.tag == "Tree") 
        {
            if(eggTime == true) 
            {
                _rbody.velocity = new Vector3(0, 0, 0);
            }
        }
        
    }

    void FixedUpdate() 
    { 
        if (eggTime == false) 
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }

    }
}
