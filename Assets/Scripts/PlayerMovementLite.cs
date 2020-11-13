using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerMovementLite : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    public float sprintSpeed;
    public float jumpSpeed;
    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public float groundedMemory; 
    float prevTimeGrounded;
    public float fallMultiplier = 2.5f; 
    public float lowJumpMultiplier = 10f;

    public float horizontalMove = 0f;
    float x;

    int defaultAddedJumps = 0;
    int addedJumps;

    //public VectorVal startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //transform.position = startingPosition.initialVal;
    }

    // Update is called once per frame
    void Update()
    {
        //horizontal and jump movement

        //sprinting 
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)){
            x = Input.GetAxis("Horizontal") * sprintSpeed;
        }
        //no sprinting
        else{
            x = Input.GetAxis("Horizontal");
        }
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || Time.time - 
        prevTimeGrounded <= groundedMemory))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }
        if (addedJumps > 0){
            if(Input.GetKeyDown(KeyCode.Space)) {
                rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
                addedJumps=0;
            }
        }
        BetterJump();
        CheckIfGrounded();
    }

    void FixedUpdate(){
        rb.velocity = new Vector2(x * speed, rb.velocity.y);
    }

    void OnTriggerEnter2D(Collider2D collision){
        if (collision.tag == "greenStar"){
            addedJumps=1;
        }
    }

    void BetterJump(){
    if (rb.velocity.y < 0) {
        rb.velocity += Vector2.up * Physics2D.gravity * (fallMultiplier - 1) * Time.deltaTime;
    } else if (rb.velocity.y > 0 && !Input.GetKey(KeyCode.Space)) {
        rb.velocity += Vector2.up * Physics2D.gravity * (lowJumpMultiplier - 1) * Time.deltaTime;
    }   
    }
    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (collider != null)
        {
            isGrounded = true;
            addedJumps = defaultAddedJumps;
        }
        else
        {
            if(isGrounded){
                prevTimeGrounded = Time.time;
            }
            isGrounded = false;
        }
    }
}
