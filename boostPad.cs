using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostPad : MonoBehaviour
{
    public Rigidbody2D rb;
    public float boostForce = 10f;
    //pm means it's from the PlayerMovement script
    private float pmDefaultJumpForce;
    private bool pmReversedGravity;

    //the bounce thingy
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            pmDefaultJumpForce = other.GetComponent<PlayerMovement>().defaultJumpForce;
            pmReversedGravity = other.GetComponent<PlayerMovement>().reversedGravity;


            other.GetComponent<PlayerMovement>().defaultJumpForce += boostForce;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().defaultJumpForce = pmDefaultJumpForce;
        }
        
    }

}