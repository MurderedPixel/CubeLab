using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float jumpForce; //dont touch this, its not meant to be edited
    public float defaultJumpForce = 15f; //touch this
    public Vector3 boxcastSizeLower;
    private Vector2 boxcastDirection = Vector2.down;
    private Rigidbody2D rb;
    public bool grounded = false;
    public bool reversedGravity = false;
    public bool onStickyWall = false;
    public BoxCollider2D playerCollider;
    [SerializeField] private LayerMask groundLayerMask;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {   //transform-movement
        /*
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;
        */
        //velocity-movement   
        float inputHorizontal = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputHorizontal * movementSpeed, rb.velocity.y);
    }

    private void Update()
    {
        if(onStickyWall == false)
        {
            if(IsGrounded() && Input.GetButtonDown("Jump") || IsGrounded() && Input.GetKeyDown("w"))
            {
                rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
        }

        if(rb.transform.position.y < -0.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

        if(Input.GetKey("r"))
        {
            FindObjectOfType<playerCollision>().die();
        }

        if(reversedGravity == true)
        {
            jumpForce = -defaultJumpForce;
            boxcastDirection = Vector2.up;
        }

        if(reversedGravity == false)
        {
            jumpForce = defaultJumpForce;
            boxcastDirection = Vector2.down;
        }

    }

    private bool IsGrounded()
    {
        float extraHeightText = 0.1f;
        RaycastHit2D raycastHit = Physics2D.BoxCast(playerCollider.bounds.center, playerCollider.bounds.size - boxcastSizeLower, 0f, boxcastDirection, extraHeightText, groundLayerMask);
        return raycastHit.collider != null;
    }
}