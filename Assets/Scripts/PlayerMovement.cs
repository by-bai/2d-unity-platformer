using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sprite;

    private float dirX = 0f;
    //SerializeField allows editing in Unity Editor
    [SerializeField] private float moveSpeed = 7f; 
    [SerializeField] private float jumpForce = 14f; 

    //int wholeNumber = 16;
    //float decimalNumber = 4.54f;
    //string text = "blabla";
    //bool boolean = true; 

    // Start is called before the first frame update
    private void Start()
    {
        //Debug.Log("Hello, world!");

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    private void Update()
    {
        //Debug.Log("update");

        dirX = Input.GetAxisRaw("Horizontal"); //direction X axis
        // press left -1, press right +1. joystick will have values in between
        // GetAxisRaw goes back to 0 after releasing immediately, GetAxis doesn't

        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y); //horizontal and vertical
            // vector 2 for 2D game, vector 3 for 3D game
            // multiply because if dirX is -1, velocity will be negative and move left. cleaner than using if/else
            // multiplying also provide joystick support. if dirX = -0.5 then move by -3.5
            // rb.velocity.y instead of 0 --> the rigidbody value it has the frame before
        if (Input.GetButtonDown("Jump"))
        {
           rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
        }

        UpdateAnimationState();
        
    }

    private void UpdateAnimationState()
    {
        if (dirX > 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = false; 
        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
            sprite.flipX = true; 
        }
        else
        {
            //0
            anim.SetBool("running", false);
        }
    }
}
