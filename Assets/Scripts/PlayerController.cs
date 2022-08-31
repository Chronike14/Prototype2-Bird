using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    public GameObject rb;
{
    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent("RigidBody2D");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
