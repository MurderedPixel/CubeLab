using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostPad : MonoBehaviour
{
    public float verticalBoostForce = 25f;
    public float horizontalBoostForce = 0f;
    
    //the bounce thingy
    void OnTriggerStay2D(Collider2D other){
        if(other.CompareTag("Player") && Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){

        }
        else{
            other.attachedRigidbody.velocity = new Vector2(horizontalBoostForce, verticalBoostForce);
        }
    }
}