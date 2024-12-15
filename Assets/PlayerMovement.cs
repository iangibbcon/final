using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
    {
    public float moveSpeed = 5f; // variable so I can change the movespeed if I want
    private Rigidbody2D rb;     // does this work?
    private Vector2 movement;
    private SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
     void Start() 
     {
     rb = GetComponent<Rigidbody2D>();

     spriteRenderer = GetComponent<SpriteRenderer>();
     
        if (rb == null)
        {
            Debug.LogError("put rigidbody on the playerobj"); //debuh reminder
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = 0f;
        movement.y = 0f; //trying a new movement system
        // all 4 directions
        // NOT GetKeyDown
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movement.x = 1f;
            spriteRenderer.flipX = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            movement.x = -1f;
            spriteRenderer.flipX = true;
        }
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
       //     movement.y = 1f;
        //}
        //if (Input.GetKey(KeyCode.DownArrow))
       //{
       //     movement.y = -1f;
       // }
    } 
      

void FixedUpdate()
    {
        // if rigidbody works(isn't null), use this to modify movespeed
        if (rb != null)
        {
            rb.velocity = movement * moveSpeed;
        }
    }
    }
