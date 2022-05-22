using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedPad : MonoBehaviour
{
    public float verticalBoostForce = 0f;
    public float horizontalBoostForce = 10f;
    
    //the bounce thingy
    void OnTriggerStay2D(Collider2D other){
        other.attachedRigidbody.velocity = new Vector2(horizontalBoostForce, verticalBoostForce);
    }
}
