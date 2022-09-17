using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour


{

    private Rigidbody2D rb;
    private float camSpeed = 5.0f;
    public float moveSpeed = 5.0f;

    Vector2 movement;

    System.Random randColor = new System.Random();
    System.Random randSize = new System.Random();
    int randX;
    int randY;
    int randZ;
    System.Random randSpeedNum = new System.Random();
    int randSpeed;


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

    public Sprite Egg;

    public bool isEgg;
    

    // Start is called before the first frame update
    void Start()
    {

        rb = gameObject.GetComponent<Rigidbody2D>();
        RandColor();

        randX = randSize.Next(4, 11);
        randY = randSize.Next(randX - 2, randX + 2);
        randZ = randSize.Next(randX - 2 , randX + 2);

        rb.gameObject.transform.localScale = new Vector3(randX, randY, 0);

        randSpeed = randSpeedNum.Next(4, 10);

        moveSpeed = randSpeed + camSpeed;

        isEgg = false;

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

    void becomeEgg() 
    {
        isEgg = true;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Egg;
        rb.gameObject.transform.localScale = new Vector3(5, 5, 5);
        Time.timeScale = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tree"))
        {
            becomeEgg();
            print("hey");
        }
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if (Input.GetKey("escape"))
        {
            Application.Quit();
            print("Escape");
        }

        if (Input.GetKeyDown("space")) 
        {
            if (isEgg == false)
            {
                becomeEgg();
            }
                else if (isEgg == true)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                    print("Scene restarted");
                    Time.timeScale = 1f;
                }

        }
    }

    void FixedUpdate()
    {
        if(isEgg == false) 
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        
    }
}
