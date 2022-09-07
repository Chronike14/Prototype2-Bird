using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour


{

    private Rigidbody2D rb;

    public float moveSpeed = 5f;

    Vector2 movement;

    System.Random randColor = new System.Random();

    int colorNum;

    string colorString;



    public Sprite One;
    public Sprite Two;
    public Sprite Three;
    public Sprite Four;
    public Sprite Five;
    public Sprite Six;
    public Sprite Seven;
    public Sprite Eight;
    public Sprite Nine;
    public Sprite Ten;
    public Sprite Eleven;
    public Sprite Twelve;
    public Sprite Thirteen;
    public Sprite Fourteen;
    public Sprite Fivteen;
    public Sprite Sixteen;

    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        RandColor();


    }

    void RandColor() 
    {
        colorNum = randColor.Next(1, 17);
        if (colorNum == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = One;
        }
        if (colorNum == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Two;
        }
        if (colorNum == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Three;
        }
        if (colorNum == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Four;
        }
        if (colorNum == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Five;
        }
        if (colorNum == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Six;
        }
        if (colorNum == 7)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Seven;
        }
        if (colorNum == 8)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Eight;
        }
        if (colorNum == 9)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Nine;
        }
        if (colorNum == 10)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Ten;
        }
        if (colorNum == 11)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Eleven;
        }
        if (colorNum == 12)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Twelve;
        }
        if (colorNum == 13)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Thirteen;
        }
        if (colorNum == 14)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Fourteen;
        }
        if (colorNum == 15)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Fivteen;
        }
        if (colorNum == 16)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Sixteen;
        }
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
