using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

    
{

    private Rigidbody2D rb;

    public float moveSpeed = 5f;

    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.Translate(Vector2.right * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(-3, rb.velocity.x);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-3, rb.velocity.y);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(3, rb.velocity.y);
        }
        */

        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
